using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning
{
	[AddComponentMenu("XR/Locomotion/Snap Turn Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider.html")]
	public class SnapTurnProvider : LocomotionProvider
	{
		[SerializeField]
		[Tooltip("The number of degrees clockwise to rotate when snap turning clockwise.")]
		private float m_TurnAmount;

		[SerializeField]
		[Tooltip("The amount of time that the system will wait before starting another snap turn.")]
		private float m_DebounceTime;

		[SerializeField]
		[Tooltip("Controls whether to enable left & right snap turns.")]
		private bool m_EnableTurnLeftRight;

		[SerializeField]
		[Tooltip("Controls whether to enable 180° snap turns.")]
		private bool m_EnableTurnAround;

		[SerializeField]
		[Tooltip("The time (in seconds) to delay the first turn after receiving initial input for the turn.")]
		private float m_DelayTime;

		[SerializeField]
		[Tooltip("Reads input data from the left hand controller. Input Action must be a Value action type (Vector 2).")]
		private XRInputValueReader<Vector2> m_LeftHandTurnInput;

		[SerializeField]
		[Tooltip("Reads input data from the right hand controller. Input Action must be a Value action type (Vector 2).")]
		private XRInputValueReader<Vector2> m_RightHandTurnInput;

		private float m_CurrentTurnAmount;

		private float m_TimeStarted;

		private float m_DelayStartTime;

		public float turnAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float debounceTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableTurnLeftRight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableTurnAround
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float delayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool canStartMoving => false;

		public XRBodyYawRotation transformation
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

		public XRInputValueReader<Vector2> leftHandTurnInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> rightHandTurnInput
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

		protected virtual float GetTurnAmount(Vector2 input)
		{
			return 0f;
		}

		protected void StartTurn(float amount)
		{
		}
	}
}
