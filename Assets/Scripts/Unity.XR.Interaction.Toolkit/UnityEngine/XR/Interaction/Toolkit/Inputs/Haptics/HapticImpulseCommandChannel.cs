using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	public class HapticImpulseCommandChannel : IXRHapticImpulseChannel
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

		public UnityEngine.InputSystem.InputDevice device
		{
			[CompilerGenerated]
			get
			{
				return null;
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
