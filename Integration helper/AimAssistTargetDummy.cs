using System;
using UnityEngine;
using UnityEngine.Events;

namespace Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.Target
{
    /// <summary>
    /// GameObjects with this component can be targeted by the Aim Assist component to adjust the aim.
    /// </summary>
    public class AimAssistTargetDummy : MonoBehaviour
    {
        /// <summary>
        /// Can be invoked when the target is picked up by the aim assist.
        ///
        /// Invoked once when the target is picked up but is not repeatedly invoked while the aim assist lasts.
        /// </summary>
        [Header("Events")]
        public readonly UnityEvent TargetSelected = new UnityEvent();

        /// <summary>
        /// Invoked when the target is no longer picked up by the aim assist.
        /// </summary>
        public readonly UnityEvent TargetLost = new UnityEvent();

        private void Awake()
        {
            // verify that colliders exist on target so aim assist can work
        }

    }
}