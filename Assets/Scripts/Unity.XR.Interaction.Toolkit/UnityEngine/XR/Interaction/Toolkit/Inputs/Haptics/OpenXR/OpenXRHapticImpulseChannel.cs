using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR
{
	public class OpenXRHapticImpulseChannel : IXRHapticImpulseChannel
	{
		public InputAction hapticAction
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
