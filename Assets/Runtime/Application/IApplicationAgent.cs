/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IApplicationAgent.cs
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
    public interface IApplicationAgent
    {
        event Action<bool> OnApplicationFocusEvent;
        event Action<bool> OnApplicationPauseEvent;
        event Action OnApplicationQuitEvent;
    }
}