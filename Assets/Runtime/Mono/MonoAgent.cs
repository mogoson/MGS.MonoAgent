/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MonoAgent.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  10/03/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections;
using UnityEngine;

namespace MGS.Agent
{
    public class MonoAgent<T> : IMonoAgent<T> where T : MonoBehaviour
    {
        public T Mono { private set; get; }

        public MonoAgent()
        {
            Mono = new GameObject(GetType().Name).AddComponent<T>();
            Object.DontDestroyOnLoad(Mono);
        }

        public virtual void Dispose()
        {
            Object.Destroy(Mono.gameObject);
            Mono = null;
        }

        /// <summary>
        /// Starts a Coroutine.
        /// </summary>
        /// <returns></returns>
        public Coroutine StartCoroutine(IEnumerator routine)
        {
            return Mono.StartCoroutine(routine);
        }

        /// <summary>
        /// Stops the coroutine stored in routine running on this behaviour.
        /// </summary>
        /// <param name="routine"></param>
        public void StopCoroutine(IEnumerator routine)
        {
            Mono.StopCoroutine(routine);
        }
    }

    public class MonoAgent : MonoAgent<AgentMono> { }

    public class AgentMono : MonoBehaviour { }
}