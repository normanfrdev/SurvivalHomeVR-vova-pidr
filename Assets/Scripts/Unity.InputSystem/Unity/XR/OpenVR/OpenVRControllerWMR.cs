using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.OpenVR
{
	[InputControlLayout(displayName = "Windows MR Controller (OpenVR)", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
	public class OpenVRControllerWMR : XRController
	{
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity
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

		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity
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

		[InputControl(aliases = new string[] { "primary2DAxisClick", "joystickOrPadPressed" })]
		public ButtonControl touchpadClick
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

		[InputControl(aliases = new string[] { "primary2DAxisTouch", "joystickOrPadTouched" })]
		public ButtonControl touchpadTouch
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

		[InputControl]
		public ButtonControl gripPressed
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

		[InputControl]
		public ButtonControl triggerPressed
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

		[InputControl(aliases = new string[] { "primary" })]
		public ButtonControl menu
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

		[InputControl]
		public AxisControl trigger
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

		[InputControl]
		public AxisControl grip
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

		[InputControl(aliases = new string[] { "secondary2DAxis" })]
		public Vector2Control touchpad
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

		[InputControl(aliases = new string[] { "primary2DAxis" })]
		public Vector2Control joystick
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
