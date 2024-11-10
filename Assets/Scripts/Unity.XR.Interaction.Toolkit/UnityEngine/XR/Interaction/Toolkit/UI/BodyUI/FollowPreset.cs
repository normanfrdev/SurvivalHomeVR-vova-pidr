using System;

namespace UnityEngine.XR.Interaction.Toolkit.UI.BodyUI
{
	[Serializable]
	public class FollowPreset
	{
		[Header("Local Space Anchor Transform")]
		[Tooltip("Local space anchor position for the right hand.")]
		public Vector3 rightHandLocalPosition;

		[Tooltip("Local space anchor position for the left hand.")]
		public Vector3 leftHandLocalPosition;

		[Tooltip("Local space anchor rotation for the right hand.")]
		public Vector3 rightHandLocalRotation;

		[Tooltip("Local space anchor rotation for the left hand.")]
		public Vector3 leftHandLocalRotation;

		[Header("Hand anchor angle constraints")]
		[Tooltip("Reference axis equivalent used for comparisons with the user's gaze direction and the world up direction.")]
		public FollowReferenceAxis palmReferenceAxis;

		[Tooltip("Given that the default reference hand for menus is the left hand, it may be required to mirror the reference axis for the right hand.")]
		public bool invertAxisForRightHand;

		[Tooltip("Whether or not check if the palm reference axis is facing the user.")]
		public bool requirePalmFacingUser;

		[Tooltip("The angle threshold in degrees to check if the palm reference axis is facing the user.")]
		public float palmFacingUserDegreeAngleThreshold;

		private float m_PalmFacingUserDotThreshold;

		[Tooltip("Whether or not check if the palm reference axis is facing up.")]
		public bool requirePalmFacingUp;

		[Tooltip("The angle threshold in degrees to check if the palm reference axis is facing up.")]
		public float palmFacingUpDegreeAngleThreshold;

		private float m_PalmFacingUpDotThreshold;

		[Header("Snap To gaze config")]
		[Tooltip("Whether to snap the following element to the gaze direction.")]
		public bool snapToGaze;

		[Tooltip("The angle threshold in degrees to snap the following element to the gaze direction.")]
		public float snapToGazeAngleThreshold;

		private float m_SnapToGazeDotThreshold;

		[Header("Hide delay config")]
		[Tooltip("The amount of time in seconds to wait before hiding the following element after the hand is no longer tracked.")]
		public float hideDelaySeconds;

		[Header("Smoothing Config")]
		[Tooltip("Whether to allow smoothing of the following element position and rotation.")]
		public bool allowSmoothing;

		[Tooltip("The lower bound of smoothing to apply.")]
		public float followLowerSmoothingValue;

		[Tooltip("The upper bound of smoothing to apply.")]
		public float followUpperSmoothingValue;

		public float palmFacingUserDotThreshold => 0f;

		public float palmFacingUpDotThreshold => 0f;

		public float snapToGazeDotThreshold => 0f;

		public void ApplyPreset(Transform leftTrackingOffset, Transform rightTrackingOffset)
		{
		}

		public void ComputeDotProductThresholds()
		{
		}

		private static float AngleToDot(float angleDeg)
		{
			return 0f;
		}

		public Vector3 GetReferenceAxisForTrackingAnchor(Transform trackingRoot, bool isRightHand)
		{
			return default(Vector3);
		}

		private Vector3 GetLocalAxis(bool isRightHand)
		{
			return default(Vector3);
		}
	}
}
