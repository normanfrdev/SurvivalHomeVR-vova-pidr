namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceVector2ValueReader.html")]
	[CreateAssetMenu(fileName = "XRInputDeviceVector2ValueReader", menuName = "XR/Input Value Reader/Vector2")]
	public class XRInputDeviceVector2ValueReader : XRInputDeviceValueReader<Vector2>
	{
		public override Vector2 ReadValue()
		{
			return default(Vector2);
		}

		public override bool TryReadValue(out Vector2 value)
		{
			value = default(Vector2);
			return false;
		}

		public XRInputDeviceVector2ValueReader()
		{
			((XRInputDeviceValueReader<>)(object)this)._002Ector();
		}
	}
}
