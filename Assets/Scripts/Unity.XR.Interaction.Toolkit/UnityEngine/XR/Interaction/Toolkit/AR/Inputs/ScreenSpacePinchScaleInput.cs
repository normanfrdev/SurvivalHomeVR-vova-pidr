using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

namespace UnityEngine.XR.Interaction.Toolkit.AR.Inputs
{
	[AddComponentMenu("XR/Input/Screen Space Pinch Scale Input", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AR.Inputs.ScreenSpacePinchScaleInput.html")]
	public class ScreenSpacePinchScaleInput : MonoBehaviour, IXRInputValueReader<float>, IXRInputValueReader
	{
		[SerializeField]
		[Tooltip("Enables a rotation threshold that blocks pinch scale gestures when surpassed.")]
		private bool m_UseRotationThreshold;

		[SerializeField]
		[Tooltip("The threshold at which a gestures will be interpreted only as rotation and not a pinch scale gesture.")]
		private float m_RotationThreshold;

		[SerializeField]
		[Tooltip("The input used to read the pinch gap delta value.")]
		private XRInputValueReader<float> m_PinchGapDeltaInput;

		[SerializeField]
		[Tooltip("The input used to read the twist delta rotation value.")]
		private XRInputValueReader<float> m_TwistDeltaRotationInput;

		public bool useRotationThreshold
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float rotationThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public XRInputValueReader<float> pinchGapDeltaInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<float> twistDeltaRotationInput
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

		public float ReadValue()
		{
			return 0f;
		}

		public bool TryReadValue(out float value)
		{
			value = default(float);
			return false;
		}
	}
}
