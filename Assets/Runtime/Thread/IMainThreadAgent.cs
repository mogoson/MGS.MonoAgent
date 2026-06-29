/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IMainThreadAgent.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/29/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;

namespace MGS.MonoAgent
{
    public interface IMainThreadAgent
    {
        /// <summary>
        /// Enqueue action and it will be invoke by main thread.
        /// </summary>
        /// <param name="action"></param>
        void Enqueue(Action action);
    }
}