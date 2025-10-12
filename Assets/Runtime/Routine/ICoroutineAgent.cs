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

namespace MGS.Agent
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
        /// Start coroutine to invoke the specified action repeatedly each frame with a specified time interval.
        /// </summary>
        /// <param name="seconds">The time interval between invocations.</param>
        /// <param name="tick">The action to invoke.</param>
        /// <param name="arrive">The action to invoke when the timer arrives.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartTimerCoroutine(float seconds, Action<float> tick, Action arrive);

        /// <summary>
        /// Start coroutine to invoke the specified action when the specified condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="action">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartWaitCoroutine(Func<bool> condition, Action action);

        /// <summary>
        /// Start coroutine to invoke the specified action repeatedly each frame until the specified condition is false.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="action">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartUntilCoroutine(Func<bool> condition, Action action);

        /// <summary>
        /// Start coroutine to invoke the specified action after a specified delay seconds.
        /// </summary>
        /// <param name="seconds">The delay in seconds.</param>
        /// <param name="action">The action to invoke.</param>
        /// <returns>The coroutine object.</returns>
        Coroutine StartDelayCoroutine(float seconds, Action action);

        /// <summary>
        /// Starts a Coroutine.
        /// </summary>
        /// <returns></returns>
        Coroutine StartCoroutine(IEnumerator routine);

        /// <summary>
        /// Stops the coroutine stored in routine running on this behaviour.
        /// </summary>
        /// <param name="routine"></param>
        void StopCoroutine(IEnumerator routine);
    }
}