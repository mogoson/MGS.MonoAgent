/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MonoAgentTests.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  10/03/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using NUnit.Framework;
using UnityEngine;

namespace MGS.Agent.Tests
{
    public class MonoAgentTests
    {
        [Test]
        public void AgentGoTest()
        {
            var agent = new MonoAgent();
            var go = GameObject.Find(nameof(MonoAgent));
            Assert.IsNotNull(go);

            var mono = agent.Mono;
            Assert.IsNotNull(mono);
        }
    }
}