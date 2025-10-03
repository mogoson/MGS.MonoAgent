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
    public class MonoAgent : IMonoAgent
    {
        protected class AgentMono : MonoBehaviour { }

        public MonoBehaviour Mono { private set; get; }

        public MonoAgent()
        {
            Mono = new GameObject(GetType().Name).AddComponent<AgentMono>();
            Object.DontDestroyOnLoad(Mono);
        }

        public virtual void Dispose()
        {
            Object.Destroy(Mono.gameObject);
            Mono = null;
        }
    }
}