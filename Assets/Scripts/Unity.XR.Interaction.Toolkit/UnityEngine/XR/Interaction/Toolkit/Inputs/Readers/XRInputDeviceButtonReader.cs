using UnityEngine.XR.Interaction.Toolkit.Utilities;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[AddComponentMenu("XR/Input/XR Input Device Button Reader", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceButtonReader.html")]
	[DefaultExecutionOrder(-31000)]
	public sealed class XRInputDeviceButtonReader : MonoBehaviour, IXRInputButtonReader, IXRInputValueReader<float>, IXRInputValueReader
	{
		[SerializeField]
		[Tooltip("The value that is read to determine whether the button is down.")]
		private XRInputDeviceBoolValueReader m_BoolValueReader;

		[SerializeField]
		[Tooltip("The value that is read to determine the scalar value that varies from 0 to 1.")]
		private XRInputDeviceFloatValueReader m_FloatValueReader;

		private bool m_IsPerformed;

		private bool m_WasPerformedThisFrame;

		private bool m_WasCompletedThisFrame;

		private readonly UnityObjectReferenceCache<XRInputDeviceBoolValueReader> m_BoolValueReaderCache;

		private readonly UnityObjectReferenceCache<XRInputDeviceFloatValueReader> m_FloatValueReaderCache;

		public XRInputDeviceBoolValueReader boolValueReader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputDeviceFloatValueReader floatValueReader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
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

		private bool TryGetBoolValueReader(out XRInputDeviceBoolValueReader reference)
		{
			reference = null;
			return false;
		}

		private bool TryGetFloatValueReader(out XRInputDeviceFloatValueReader reference)
		{
			reference = null;
			return false;
		}
	}
}
