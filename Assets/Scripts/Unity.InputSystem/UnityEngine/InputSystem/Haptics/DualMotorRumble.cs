using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Haptics
{
	internal struct DualMotorRumble
	{
		public float lowFrequencyMotorSpeed
		{
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float highFrequencyMotorSpeed
		{
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isRumbling => false;

		public void PauseHaptics(InputDevice device)
		{
		}

		public void ResumeHaptics(InputDevice device)
		{
		}

		public void ResetHaptics(InputDevice device)
		{
		}

		public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency)
		{
		}
	}
}
