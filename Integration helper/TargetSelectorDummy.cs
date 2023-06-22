using Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.Target;
using UnityEngine;

namespace Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.TargetSelection
{
    /// <summary>
    /// Finds and selects a given target for the aim assists and invokes events on the target if any are defined.
    ///
    /// Separating the selection can enable you to use multiple aim assists together with no additional performance hit from the target selection process.
    /// 
    /// THIS DUMMY VERSION IS PUBLICLY AVAILABLE SO DEVELOPERS CAN SEE IF THEY COULD INTEGRATE THIS INTO THEIR PROJECT. 
    /// </summary>
    public class TargetSelectorDummy : MonoBehaviour
    {
        [Header("Data for aim assist")]
        [Tooltip("The player's camera that will be aim assisted")]
        public Transform playerCamera;

        [Tooltip("The radius of the aim assist in metres.")]
        public float aimAssistRadius = 0.5f;

        [Tooltip("The near clip distance in metres. Aim assist doesn't work for targets closer than this.")]
        public float nearClipDistance = 0.5f;

        [Tooltip("The far clip distance in metres. Aim assist doesn't work for target further than this. Increasing this takes more computing power.")]
        public float farClipDistance = 50f;

        [Header("Layers")]
        [Tooltip("Layers to take into account during the aim assist.")]
        public LayerMask layerMask;

        public NotifyTargetFound OnTargetSelected { get; } = new NotifyTargetFound();
        public NotifyTargetFound OnTargetLost { get; } = new NotifyTargetFound();

        /// <summary>
        /// The target that is currently found by the selector. Null if currently no targets are found.
        /// 
        /// IN THE DUMMY VERSTION that is used as an example for the integration, it will always be null.
        /// </summary>
        public AimAssistTargetDummy Target { get; private set; }

        private void Awake()
        {
            // verify if player camera is present
        }

        private void FixedUpdate()
        {
            // use target selector
            // manage notifications
            Debug.Log("Selected target and fired notifications.");
        }
    }
}