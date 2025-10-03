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
using UnityEngine;

namespace MGS.Agent
{
    public class CoroutineAgent : MonoAgent, ICoroutineAgent
    {
        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame.
        /// </summary>
        /// <param name="tick">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartTickCoroutine(Action tick)
        {
            var routine = RoutineAgent.TickRoutine(tick);
            return Mono.StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame with a specified time interval.
        /// </summary>
        /// <param name="seconds">The time interval between invocations.</param>
        /// <param name="tick">The action to invoke.</param>
        /// <param name="arrive">The action to invoke when the timer arrives.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartTimerCoroutine(float seconds, Action<float> tick, Action arrive)
        {
            var routine = RoutineAgent.TimerRoutine(seconds, tick, arrive);
            return Mono.StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action when the specified condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="action">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartWaitCoroutine(Func<bool> condition, Action action)
        {
            var routine = RoutineAgent.WaitRoutine(condition, action);
            return Mono.StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame until the specified condition is false.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="action">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartUntilCoroutine(Func<bool> condition, Action action)
        {
            var routine = RoutineAgent.UntilRoutine(condition, action);
            return Mono.StartCoroutine(routine);
        }

        /// <summary>
        /// Start coroutine to invoke the specified action after a specified delay seconds.
        /// </summary>
        /// <param name="seconds">The delay in seconds.</param>
        /// <param name="action">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        public Coroutine StartDelayCoroutine(float seconds, Action action)
        {
            var routine = RoutineAgent.DelayRoutine(seconds, action);
            return Mono.StartCoroutine(routine);
        }
    }
}