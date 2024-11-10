namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.XRInputDeviceHapticImpulseProvider.html")]
	[CreateAssetMenu(fileName = "XRInputDeviceHapticImpulseProvider", menuName = "XR/Input Device Haptic Impulse Provider")]
	public class XRInputDeviceHapticImpulseProvider : ScriptableObject, IXRHapticImpulseProvider
	{
		[SerializeField]
		private InputDeviceCharacteristics m_Characteristics;

		private XRInputDeviceHapticImpulseChannelGroup m_ChannelGroup;

		private InputDevice m_InputDevice;

		public IXRHapticImpulseChannelGroup GetChannelGroup()
		{
			return null;
		}

		private void RefreshInputDeviceIfNeeded()
		{
		}
	}
}
