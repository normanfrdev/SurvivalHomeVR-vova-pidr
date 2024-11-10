using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

namespace UnityEngine.XR.Interaction.Toolkit.AR.Inputs
{
	[AddComponentMenu("XR/Input/Screen Space Select Input", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AR.Inputs.ScreenSpaceSelectInput.html")]
	[DefaultExecutionOrder(-30050)]
	public class ScreenSpaceSelectInput : MonoBehaviour, IXRInputButtonReader, IXRInputValueReader<float>, IXRInputValueReader
	{
		[SerializeField]
		private XRInputValueReader<Vector2> m_TapStartPositionInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_DragCurrentPositionInput;

		[SerializeField]
		private XRInputValueReader<float> m_PinchGapDeltaInput;

		[SerializeField]
		private XRInputValueReader<float> m_TwistDeltaRotationInput;

		private bool m_IsPerformed;

		private bool m_WasPerformedThisFrame;

		private bool m_WasCompletedThisFrame;

		private Vector2 m_TapStartPosition;

		public XRInputValueReader<Vector2> tapStartPositionInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> dragCurrentPositionInput
		{
			get
			{
				return null;
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

		protected void Update()
		{
		}

		public bool ReadIsPerformed()
		{
			return false;
		}

		public bool ReadWasPerformedThisFrame()
		{
			return false;
		}

		public bool ReadWasCompletedThisFrame()
		{
			return false;
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
