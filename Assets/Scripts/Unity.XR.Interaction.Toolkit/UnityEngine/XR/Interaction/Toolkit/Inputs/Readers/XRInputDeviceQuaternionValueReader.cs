namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceQuaternionValueReader.html")]
	[CreateAssetMenu(fileName = "XRInputDeviceQuaternionValueReader", menuName = "XR/Input Value Reader/Quaternion")]
	public class XRInputDeviceQuaternionValueReader : XRInputDeviceValueReader<Quaternion>
	{
		public override Quaternion ReadValue()
		{
			return default(Quaternion);
		}

		public override bool TryReadValue(out Quaternion value)
		{
			value = default(Quaternion);
			return false;
		}

		public XRInputDeviceQuaternionValueReader()
		{
			((XRInputDeviceValueReader<>)(object)this)._002Ector();
		}
	}
}
