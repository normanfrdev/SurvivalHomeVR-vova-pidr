using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	public class XRInputDeviceHapticImpulseChannelGroup : IXRHapticImpulseChannelGroup
	{
		private InputDevice m_Device;

		private readonly List<IXRHapticImpulseChannel> m_Channels;

		public int channelCount => 0;

		public IXRHapticImpulseChannel GetChannel(int channel = 0)
		{
			return null;
		}

		public void Initialize(InputDevice device)
		{
		}
	}
}
