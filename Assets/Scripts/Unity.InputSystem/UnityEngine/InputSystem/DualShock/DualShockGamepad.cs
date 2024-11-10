using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Haptics;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.DualShock
{
	[InputControlLayout(displayName = "PlayStation Controller")]
	public class DualShockGamepad : Gamepad, IDualShockHaptics, IDualMotorRumble, IHaptics
	{
		[InputControl(name = "buttonWest", displayName = "Square", shortDisplayName = "Square")]
		[InputControl(name = "buttonNorth", displayName = "Triangle", shortDisplayName = "Triangle")]
		[InputControl(name = "buttonEast", displayName = "Circle", shortDisplayName = "Circle")]
		[InputControl(name = "buttonSouth", displayName = "Cross", shortDisplayName = "Cross")]
		[InputControl]
		public ButtonControl touchpadButton
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

		[InputControl(name = "start", displayName = "Options")]
		public ButtonControl optionsButton
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

		[InputControl(name = "select", displayName = "Share")]
		public ButtonControl shareButton
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

		[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
		public ButtonControl L1
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

		[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
		public ButtonControl R1
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

		[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
		public ButtonControl L2
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

		[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
		public ButtonControl R2
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

		[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
		public ButtonControl L3
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

		[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
		public ButtonControl R3
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

		public new static DualShockGamepad current
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void MakeCurrent()
		{
		}

		protected override void OnRemoved()
		{
		}

		protected override void FinishSetup()
		{
		}

		public virtual void SetLightBarColor(Color color)
		{
		}
	}
}
