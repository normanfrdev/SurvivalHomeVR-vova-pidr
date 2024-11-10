namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceInputTrackingStateValueReader.html")]
	[CreateAssetMenu(fileName = "XRInputDeviceInputTrackingStateValueReader", menuName = "XR/Input Value Reader/InputTrackingState")]
	public class XRInputDeviceInputTrackingStateValueReader : XRInputDeviceValueReader<InputTrackingState>
	{
		public override InputTrackingState ReadValue()
		{
			return default(InputTrackingState);
		}

		public override bool TryReadValue(out InputTrackingState value)
		{
			value = default(InputTrackingState);
			return false;
		}

		public XRInputDeviceInputTrackingStateValueReader()
		{
			((XRInputDeviceValueReader<>)(object)this)._002Ector();
		}
	}
}
