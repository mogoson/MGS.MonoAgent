/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ApplicationAgent.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/29/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using MGS.Singleton;

namespace MGS.MonoAgent
{
    public sealed class ApplicationAgent : MonoSingleton<ApplicationAgent>, IApplicationAgent
    {
        public event Action<bool> OnApplicationFocusEvent;
        public event Action<bool> OnApplicationPauseEvent;
        public event Action OnApplicationQuitEvent;

        private void OnApplicationFocus(bool focus)
        {
            OnApplicationFocusEvent?.Invoke(focus);
        }

        private void OnApplicationPause(bool pause)
        {
            OnApplicationPauseEvent?.Invoke(pause);
        }

        private void OnApplicationQuit()
        {
            OnApplicationQuitEvent?.Invoke();
        }
    }
}