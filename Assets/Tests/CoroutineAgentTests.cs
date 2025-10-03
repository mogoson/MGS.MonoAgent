/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  CoroutineAgentTests.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  10/03/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace MGS.Agent.Tests
{
    public class CoroutineAgentTests
    {
        [Test]
        public void AgentGoTest()
        {
            var agent = new CoroutineAgent();
            var go = GameObject.Find(nameof(CoroutineAgent));
            Assert.IsNotNull(go);

            var mono = agent.Mono;
            Assert.IsNotNull(mono);
        }

        [UnityTest]
        public IEnumerator StartTimerCoroutineTest()
        {
            void Tick(float time)
            {
                Debug.Log($"Timer Tick {time}");
            }
            void Arrived()
            {
                Debug.Log("Timer Arrived");
            }

            var agent = new CoroutineAgent();
            var routine = agent.StartTimerCoroutine(1.0f, Tick, Arrived);
            yield return routine;
        }
    }
}