using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning
{
	[AddComponentMenu("XR/Locomotion/Continuous Turn Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider.html")]
	public class ContinuousTurnProvider : LocomotionProvider
	{
		[SerializeField]
		[Tooltip("The number of degrees/second clockwise to rotate when turning clockwise.")]
		private float m_TurnSpeed;

		[SerializeField]
		[Tooltip("Reads input data from the left hand controller. Input Action must be a Value action type (Vector 2).")]
		private XRInputValueReader<Vector2> m_LeftHandTurnInput;

		[SerializeField]
		[Tooltip("Reads input data from the right hand controller. Input Action must be a Value action type (Vector 2).")]
		private XRInputValueReader<Vector2> m_RightHandTurnInput;

		private bool m_IsTurningXROrigin;

		public float turnSpeed
		{
			get
			{
				return 0f;
			}
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

		protected void TurnRig(float turnAmount)
		{
		}
	}
}
