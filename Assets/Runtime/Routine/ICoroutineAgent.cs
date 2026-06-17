/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ICoroutineAgent.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  10/03/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.Collections;
using UnityEngine;

namespace MGS.MonoAgent
{
    public interface ICoroutineAgent
    {
        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame.
        /// </summary>
        /// <param name="tick">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartTickCoroutine(Action tick);

        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each interval.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="tick"></param>
        /// <returns></returns>
        Coroutine StartTickCoroutine(float interval, Action tick);

        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame with a specified seconds.
        /// </summary>
        /// <param name="seconds">The time seconds.</param>
        /// <param name="tick">The action to invoke.</param>
        /// <param name="arrived">The action to invoke when the timer arrived.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartTimerCoroutine(float seconds, Action<float> tick, Action arrived);

        /// <summary>
        /// Start coroutine to invoke the specified action after the specified delay seconds.
        /// </summary>
        /// <param name="seconds">The delay in seconds.</param>
        /// <param name="arrived">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartDelayCoroutine(float seconds, Action arrived);

        /// <summary>
        /// Start coroutine to invoke the specified action when the specified condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="arrived">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartWaitCoroutine(Func<bool> condition, Action arrived);

        /// <summary>
        /// Start coroutine to wait thread invoke the specified action.
        /// </summary>
        /// <param name="action">Action invoked on background thread.</param>
        /// <param name="arrived"></param>
        /// <returns></returns>
        Coroutine StartThreadRoutine(Action action, Action arrived);

        /// <summary>
        /// Start coroutine on this behaviour.
        /// </summary>
        /// <returns></returns>
        Coroutine StartCoroutine(IEnumerator routine);

        /// <summary>
        /// Stop the coroutine on this behaviour.
        /// </summary>
        /// <param name="routine"></param>
        void StopCoroutine(Coroutine routine);
    }
}