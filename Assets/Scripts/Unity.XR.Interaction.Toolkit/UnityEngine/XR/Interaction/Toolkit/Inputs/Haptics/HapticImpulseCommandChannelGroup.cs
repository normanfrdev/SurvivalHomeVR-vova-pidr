using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	public class HapticImpulseCommandChannelGroup : IXRHapticImpulseChannelGroup
	{
		private readonly List<IXRHapticImpulseChannel> m_Channels;

		private UnityEngine.InputSystem.InputDevice m_Device;

		public int channelCount => 0;

		public IXRHapticImpulseChannel GetChannel(int channel = 0)
		{
			return null;
		}

		public void Initialize(UnityEngine.InputSystem.InputDevice device)
		{
		}
	}
}
