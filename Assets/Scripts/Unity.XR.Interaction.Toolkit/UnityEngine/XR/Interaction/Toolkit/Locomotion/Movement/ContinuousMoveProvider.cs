using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement
{
	[AddComponentMenu("XR/Locomotion/Continuous Move Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider.html")]
	public class ContinuousMoveProvider : LocomotionProvider
	{
		[SerializeField]
		[Tooltip("The speed, in units per second, to move forward.")]
		private float m_MoveSpeed;

		[SerializeField]
		[Tooltip("Controls whether to enable strafing (sideways movement).")]
		private bool m_EnableStrafe;

		[SerializeField]
		[Tooltip("Controls whether to enable flying (unconstrained movement). This overrides the use of gravity.")]
		private bool m_EnableFly;

		[SerializeField]
		[Tooltip("Controls whether gravity affects this provider when a Character Controller is used and flying is disabled.")]
		private bool m_UseGravity;

		[SerializeField]
		[Tooltip("The source Transform to define the forward direction.")]
		private Transform m_ForwardSource;

		[SerializeField]
		[Tooltip("Reads input data from the left hand controller. Input Action must be a Value action type (Vector 2).")]
		private XRInputValueReader<Vector2> m_LeftHandMoveInput;

		[SerializeField]
		[Tooltip("Reads input data from the right hand controller. Input Action must be a Value action type (Vector 2).")]
		private XRInputValueReader<Vector2> m_RightHandMoveInput;

		private CharacterController m_CharacterController;

		private bool m_AttemptedGetCharacterController;

		private bool m_IsMovingXROrigin;

		private Vector3 m_VerticalVelocity;

		public float moveSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableStrafe
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableFly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useGravity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform forwardSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XROriginMovement transformation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public XRInputValueReader<Vector2> leftHandMoveInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> rightHandMoveInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Update()
		{
		}

		private Vector2 ReadInput()
		{
			return default(Vector2);
		}

		protected virtual Vector3 ComputeDesiredMove(Vector2 input)
		{
			return default(Vector3);
		}

		protected virtual void MoveRig(Vector3 translationInWorldSpace)
		{
		}

		private void FindCharacterController()
		{
		}
	}
}
