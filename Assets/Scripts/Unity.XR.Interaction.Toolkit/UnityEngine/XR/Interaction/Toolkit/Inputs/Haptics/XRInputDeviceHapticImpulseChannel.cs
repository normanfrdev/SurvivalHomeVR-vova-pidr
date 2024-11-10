using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	public class XRInputDeviceHapticImpulseChannel : IXRHapticImpulseChannel
	{
		public int motorChannel
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public InputDevice device
		{
			[CompilerGenerated]
			get
			{
				return default(InputDevice);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool SendHapticImpulse(float amplitude, float duration, float frequency)
		{
			return false;
		}
	}
}
