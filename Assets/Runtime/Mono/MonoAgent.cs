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
    }

    public class MonoAgent : MonoAgent<AgentMono> { }

    public class AgentMono : MonoBehaviour { }
}