using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(stateType = typeof(JoystickState), isGenericTypeOfDevice = true)]
	public class Joystick : InputDevice
	{
		private static int s_JoystickCount;

		private static Joystick[] s_Joysticks;

		public ButtonControl trigger
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

		public StickControl stick
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

		public AxisControl twist
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

		public Vector2Control hatswitch
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

		public static Joystick current
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

		public new static ReadOnlyArray<Joystick> all => default(ReadOnlyArray<Joystick>);

		protected override void FinishSetup()
		{
		}

		public override void MakeCurrent()
		{
		}

		protected override void OnAdded()
		{
		}

		protected override void OnRemoved()
		{
		}
	}
}
