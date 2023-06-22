using Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.Target;
using Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.TargetSelection;
using UnityEngine;

namespace Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.AimAssists
{
    /// <summary>
    /// Base class for all aim assist classes that handles the setup of the target selector.
    /// 
    /// THIS DUMMY VERSION IS PUBLICLY AVAILABLE SO DEVELOPERS CAN SEE IF THEY COULD INTEGRATE THIS INTO THEIR PROJECT. 
    /// </summary>
    [RequireComponent(typeof(TargetSelectorDummy))]
    public abstract class AimAssistBaseDummy : MonoBehaviour
    {
        /// <summary>
        /// The current target available from the selector
        /// </summary>
        public AimAssistTargetDummy Target => targetSelector.Target;

        /// <summary>
        /// The radius of the selector in metres
        /// </summary>
        public float AimAssistRadius => targetSelector.aimAssistRadius;

        /// <summary>
        /// The near clip distance of the selector
        /// </summary>
        public float NearClipDistance => targetSelector.nearClipDistance;

        /// <summary>
        /// The far clip distance of the selector
        /// </summary>
        public float FarClipDistance => targetSelector.farClipDistance;

        /// <summary>
        /// The player camera that is used for aiming.
        /// </summary>
        public Transform PlayerCamera => targetSelector.playerCamera;

        public NotifyTargetFound OnTargetFound => targetSelector.OnTargetSelected;

        public NotifyTargetFound OnTargetLost => targetSelector.OnTargetLost;

        [Header("Master switch")]
        [Tooltip("Enable aim assist")]
        public bool aimAssistEnabled = true;

        private TargetSelectorDummy targetSelector;

        protected virtual void Awake()
        {
            SetUpTargetSelector();
        }

        private void SetUpTargetSelector()
        {
            targetSelector = GetComponent<TargetSelectorDummy>();
        }
    }
}
