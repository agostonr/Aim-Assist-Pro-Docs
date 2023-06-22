using Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.Target;
using UnityEngine;

namespace Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.AimAssists
{
    /// <summary>
    /// Slows down the look input using a curve to ease up aim on the target.
    /// 
    /// THIS DUMMY VERSION IS PUBLICLY AVAILABLE SO DEVELOPERS CAN SEE IF THEY COULD INTEGRATE THIS INTO THEIR PROJECT. 
    /// </summary>
    public class PrecisionAimDummy : AimAssistBaseDummy
    {
        [Header("Sensitivity")]
        [Tooltip("The sensitivity multiplier at the center of the aim assist. This will be lerped from the outer edge of the radius.")]
        [Range(0.001f, 0.99f)]
        public float sensitivityMultiplierAtCenter = 0.18f;

        [Tooltip("The sensitivity multiplier at the edge of the aim assist. This will be eased out back to the original sensitivity when the assist loses the target. " +
            "Has to be more than center multiplier (or will be set to center multiplier).")]
        [Range(0.1f, 0.99f)]
        public float sensitivityMultiplierAtEdge = 0.5f;

        [Header("Ease Out")]
        [Tooltip("The time in seconds to regain the original input sensitivity after leaving the target." +
            "Helps get rid of unnatural, robotic stutter from the aim.")]
        [Min(0.01f)]
        public float timeToRegainOriginalInputSensitivity = 0.5f;

        protected override void Awake()
        {
            base.Awake();
            // manage events for target selector
        }

        private void OnDestroy()
        {
            // tear down events
        }

        /// <summary>
        /// Calculates the slowed down player input delta using the curve.
        ///
        /// Receives a look input delta, returns a modified look input delta.
        ///
        /// Before calculating your rotations from the player input, run that input through this.
        /// </summary>
        /// <param name="lookInputDelta">inputs: the player's look input delta</param>
        /// <returns>the modified look input delta</returns>
        public Vector2 AssistAim(Vector2 lookInputDelta)
        {
            // calculate the slowed down aim input 
            // for this dummy, just return the original
            Debug.Log("Calculated the friction for the aim input.");
            return lookInputDelta;
        }
    }
}
