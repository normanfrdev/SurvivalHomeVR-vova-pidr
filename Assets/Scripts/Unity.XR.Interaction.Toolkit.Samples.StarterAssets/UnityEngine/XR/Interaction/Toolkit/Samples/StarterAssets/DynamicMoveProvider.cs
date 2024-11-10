using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	public class DynamicMoveProvider : ContinuousMoveProvider
	{
		public enum MovementDirection
		{
			HeadRelative = 0,
			HandRelative = 1
		}

		[Space]
		[Header("Movement Direction")]
		[SerializeField]
		[Tooltip("Directs the XR Origin's movement when using the head-relative mode. If not set, will automatically find and use the XR Origin Camera.")]
		private Transform m_HeadTransform;

		[SerializeField]
		[Tooltip("Directs the XR Origin's movement when using the hand-relative mode with the left hand.")]
		private Transform m_LeftControllerTransform;

		[SerializeField]
		[Tooltip("Directs the XR Origin's movement when using the hand-relative mode with the right hand.")]
		private Transform m_RightControllerTransform;

		[SerializeField]
		[Tooltip("Whether to use the specified head transform or left controller transform to direct the XR Origin's movement for the left hand.")]
		private MovementDirection m_LeftHandMovementDirection;

		[SerializeField]
		[Tooltip("Whether to use the specified head transform or right controller transform to direct the XR Origin's movement for the right hand.")]
		private MovementDirection m_RightHandMovementDirection;

		private Transform m_CombinedTransform;

		private Pose m_LeftMovementPose;

		private Pose m_RightMovementPose;

		public Transform headTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform leftControllerTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform rightControllerTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MovementDirection leftHandMovementDirection
		{
			get
			{
				return default(MovementDirection);
			}
			set
			{
			}
		}

		public MovementDirection rightHandMovementDirection
		{
			get
			{
				return default(MovementDirection);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override Vector3 ComputeDesiredMove(Vector2 input)
		{
			return default(Vector3);
		}
	}
}
