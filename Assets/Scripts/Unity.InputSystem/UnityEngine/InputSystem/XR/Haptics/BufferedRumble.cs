using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.XR.Haptics
{
	public struct BufferedRumble
	{
		public HapticCapabilities capabilities
		{
			[CompilerGenerated]
			readonly get
			{
				return default(HapticCapabilities);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private InputDevice device
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BufferedRumble(InputDevice device)
		{
		}

		public void EnqueueRumble(byte[] samples)
		{
		}
	}
}
