using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	public class HapticImpulseSingleChannelGroup : IXRHapticImpulseChannelGroup
	{
		public int channelCount => 0;

		public IXRHapticImpulseChannel impulseChannel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public HapticImpulseSingleChannelGroup(IXRHapticImpulseChannel channel)
		{
		}

		public IXRHapticImpulseChannel GetChannel(int channel = 0)
		{
			return null;
		}
	}
}
