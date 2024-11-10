using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.XR.Haptics
{
	public struct HapticCapabilities
	{
		public readonly uint numChannels
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
		}

		public readonly bool supportsImpulse
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public readonly bool supportsBuffer
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public readonly uint frequencyHz
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
		}

		public readonly uint maxBufferSize
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
		}

		public readonly uint optimalBufferSize
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
		}

		public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize)
		{
		}

		public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize)
		{
		}
	}
}
