using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	public class HapticControlActionManager
	{
		private readonly HapticImpulseCommandChannelGroup m_DeviceChannelGroup;

		private readonly OpenXRHapticImpulseChannel m_OpenXRChannel;

		private readonly HapticImpulseSingleChannelGroup m_OpenXRChannelGroup;

		public IXRHapticImpulseChannelGroup GetChannelGroup(InputAction action)
		{
			return null;
		}
	}
}
