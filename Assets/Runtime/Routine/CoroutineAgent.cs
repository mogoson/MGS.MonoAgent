/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  CoroutineAgent.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  10/03/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using MGS.Singleton;
using UnityEngine;

namespace MGS.MonoAgent
{
    public class CoroutineAgent : MonoSingleton<CoroutineAgent>, ICoroutineAgent
    {
        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame.
        /// </summary>
        /// <param name="tick">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartTickCoroutine(Action tick)
        {
            var routine = RoutineAgent.TickRoutine(tick);
            return StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each interval.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="tick"></param>
        /// <returns></returns>
        public Coroutine StartTickCoroutine(float interval, Action tick)
        {
            var routine = RoutineAgent.TickRoutine(interval, tick);
            return StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame with a specified seconds.
        /// </summary>
        /// <param name="seconds">The time seconds.</param>
        /// <param name="tick">The action to invoke.</param>
        /// <param name="arrived">The action to invoke when the timer arrived.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartTimerCoroutine(float seconds, Action<float> tick, Action arrived)
        {
            var routine = RoutineAgent.TimerRoutine(seconds, tick, arrived);
            return StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action after the specified delay seconds.
        /// </summary>
        /// <param name="seconds">The delay in seconds.</param>
        /// <param name="arrived">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartDelayCoroutine(float seconds, Action arrived)
        {
            var routine = RoutineAgent.DelayRoutine(seconds, arrived);
            return StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action when the specified condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="arrived">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartWaitCoroutine(Func<bool> condition, Action arrived)
        {
            var routine = RoutineAgent.WaitRoutine(condition, arrived);
            return StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to wait thread invoke the specified action.
        /// </summary>
        /// <param name="action">Action invoked on background thread.</param>
        /// <param name="arrived"></param>
        /// <returns></returns>
        public Coroutine StartThreadRoutine(Action action, Action arrived)
        {
            var routine = RoutineAgent.ThreadRoutine(action, arrived);
            return StartCoroutine(routine);
        }
    }
}