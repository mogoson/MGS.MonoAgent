/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  RoutineAgent.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  10/03/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.Collections;
using System.Threading;
using UnityEngine;

namespace MGS.MonoAgent
{
    public sealed class RoutineAgent
    {
        /// <summary>
        /// Routine to invoke the specified action repeatedly each frame.
        /// </summary>
        /// <param name="tick">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public static IEnumerator TickRoutine(Action tick)
        {
            while (true)
            {
                tick?.Invoke();
                yield return null;
            }
        }

        /// <summary>
        /// Routine to invoke the specified action repeatedly each interval.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="tick"></param>
        /// <returns></returns>
        public static IEnumerator TickRoutine(float interval, Action tick)
        {
            var yieldIns = new WaitForSeconds(interval);
            while (true)
            {
                tick?.Invoke();
                yield return yieldIns;
            }
        }

        /// <summary>
        /// Routine to invoke the specified action repeatedly each frame with a specified seconds.
        /// </summary>
        /// <param name="seconds">The time seconds.</param>
        /// <param name="tick">The action to invoke.</param>
        /// <param name="arrived">The action to invoke when the timer arrived.</param>
        /// <returns>The coroutine object.</returns>
        public static IEnumerator TimerRoutine(float seconds, Action<float> tick, Action arrived)
        {
            var timer = 0f;
            while (timer < seconds)
            {
                timer += Time.deltaTime;
                tick?.Invoke(timer);
                yield return null;
            }
            arrived?.Invoke();
        }

        /// <summary>
        /// Routine to invoke the specified action after the specified delay seconds.
        /// </summary>
        /// <param name="seconds">The delay in seconds.</param>
        /// <param name="arrived">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public static IEnumerator DelayRoutine(float seconds, Action arrived)
        {
            yield return new WaitForSeconds(seconds);
            arrived?.Invoke();
        }

        /// <summary>
        /// Routine to invoke the specified action when the specified condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="arrived">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public static IEnumerator WaitRoutine(Func<bool> condition, Action arrived)
        {
            while (!condition.Invoke())
            {
                yield return null;
            }
            arrived?.Invoke();
        }

        /// <summary>
        /// Routine to wait thread invoke the specified action.
        /// </summary>
        /// <param name="action">Action invoked on background thread.</param>
        /// <param name="arrived"></param>
        /// <returns></returns>
        public static IEnumerator ThreadRoutine(Action action, Action arrived)
        {
            new Thread(ThreadStart) { IsBackground = true }.Start();
            var isArrived = false;
            void ThreadStart()
            {
                try { action?.Invoke(); }
                catch (Exception ex) { Debug.LogException(ex); }
                finally { isArrived = true; }
            }
            yield return WaitRoutine(() => isArrived, arrived);
        }
    }
}