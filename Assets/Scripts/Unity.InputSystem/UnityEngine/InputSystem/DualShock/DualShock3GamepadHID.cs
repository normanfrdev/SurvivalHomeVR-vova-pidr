using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.DualShock
{
	[InputControlLayout(stateType = typeof(DualShock3HIDInputReport), hideInUI = true, displayName = "PS3 Controller")]
	public class DualShock3GamepadHID : DualShockGamepad
	{
		public ButtonControl leftTriggerButton
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ButtonControl rightTriggerButton
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ButtonControl playStationButton
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected override void FinishSetup()
		{
		}
	}
}
