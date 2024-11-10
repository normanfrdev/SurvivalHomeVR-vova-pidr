namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceVector3ValueReader.html")]
	[CreateAssetMenu(fileName = "XRInputDeviceVector3ValueReader", menuName = "XR/Input Value Reader/Vector3")]
	public class XRInputDeviceVector3ValueReader : XRInputDeviceValueReader<Vector3>
	{
		public override Vector3 ReadValue()
		{
			return default(Vector3);
		}

		public override bool TryReadValue(out Vector3 value)
		{
			value = default(Vector3);
			return false;
		}

		public XRInputDeviceVector3ValueReader()
		{
			((XRInputDeviceValueReader<>)(object)this)._002Ector();
		}
	}
}
