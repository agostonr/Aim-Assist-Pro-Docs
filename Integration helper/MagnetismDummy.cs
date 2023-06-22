using Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.Helper.Controls;
using Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.Model;
using Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.Target;
using UnityEngine;

namespace Agoston_R.Aim_Assist_Pro.Scripts.AimAssistCode.AimAssists
{
    /// <summary>
    /// Compensates for the player's strafe by loosely following the target while it's still in assist range.
    ///
    /// Requires a RigidBody to be present on the player.
    /// 
    /// THIS DUMMY VERSION IS PUBLICLY AVAILABLE SO DEVELOPERS CAN SEE IF THEY COULD INTEGRATE THIS INTO THEIR PROJECT. 
    /// </summary>
    public class MagnetismDummy : AimAssistBaseDummy
    {
        #region Player body and controller references

        // Exposed only to be set conveniently via Inspector. Use player physics for cleaner code. 
        [HideInInspector] public PlayerControlType controlType;
        [HideInInspector] public Rigidbody playerBody;
        [HideInInspector] public CharacterController playerController;

        #endregion

        [Header("Horizontal strafing compensation")]
        [Tooltip("A divisor for the player's strafe movement when they are moving away from the target.")]
        [Min(1.08f)]
        public float horizontalSmoothnessAwayFromTarget = 1.09f;

        [Tooltip(
            "A divisor for the player's strafe movement when they are strafing towards the target. To prevent turning the player away from the target during mirror strafing, it has to be greater than smoothness away from target.")]
        [Min(1.08f)]
        public float horizontalSmoothnessTowardsTarget = 2f;

        [Tooltip(
            "In metres, to avoid stutter when switching immediately between to and away horizontal strafe smoothness this lerps the change over a distance. Has to be less than aim assist radius.")]
        [Min(0.01f)]
        public float lerpDistance = 0.1f;

        [Header("Vertical compensation")]
        [Tooltip("If enabled the assist will compensate for player jumping by tracking the target vertically, smoothed out by a factor.")]
        public bool verticalCompensation;

        [Tooltip("A divisor for the player's pitch to be compensated against.")]
        [Min(1.08f)]
        public float verticalSmoothness = 1.15f;

        private void Start()
        {
            // set up player physics
        }

        /// <summary>
        /// Calculates adjustments for the player's rotation and camera pitch to compensate against strafing or jumping. 
        /// </summary>
        /// <param name="moveInputDelta">The player's movement input delta you would use as an input for movement controls.</param>
        /// <returns>The angles in degrees to change player rotation and camera pitch.</returns>
        public AimAssistResult AssistAim(Vector2 moveInputDelta)
        {
            // doing the aim assist magic, to determine how much to compensate for player movement
            Debug.Log("Calculated Magnetism result.");
            return new AimAssistResult(rotationAdditionInDegrees: 0f, pitchAdditionInDegrees: 0f, turnAddition: Vector3.zero);
        }
    }
}
