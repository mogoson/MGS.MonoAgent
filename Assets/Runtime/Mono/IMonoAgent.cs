/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IMonoAgent.cs
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
    public interface IMonoAgent<T> : IDisposable where T : MonoBehaviour
    {
        /// <summary>
        /// MonoBehaviour of this agent.
        /// </summary>
        T Mono { get; }
    }
}