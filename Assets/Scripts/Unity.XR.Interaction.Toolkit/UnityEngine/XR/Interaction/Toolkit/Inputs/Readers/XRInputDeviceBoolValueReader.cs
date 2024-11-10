namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceBoolValueReader.html")]
	[CreateAssetMenu(fileName = "XRInputDeviceBoolValueReader", menuName = "XR/Input Value Reader/bool")]
	public class XRInputDeviceBoolValueReader : XRInputDeviceValueReader<bool>
	{
		public override bool ReadValue()
		{
			return false;
		}

		public override bool TryReadValue(out bool value)
		{
			value = default(bool);
			return false;
		}

		public XRInputDeviceBoolValueReader()
		{
			((XRInputDeviceValueReader<>)(object)this)._002Ector();
		}
	}
}
