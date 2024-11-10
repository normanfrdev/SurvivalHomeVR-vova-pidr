using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace Unity.XR.Oculus.Input
{
	[Preserve]
	[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new string[] { "LeftHand", "RightHand" })]
	public class OculusTouchController : XRControllerWithRumble
	{
		[Preserve]
		[InputControl(aliases = new string[] { "Primary2DAxis", "Joystick" })]
		public Vector2Control thumbstick
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

		[Preserve]
		[InputControl]
		public AxisControl trigger
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

		[Preserve]
		[InputControl]
		public AxisControl grip
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

		[Preserve]
		[InputControl(aliases = new string[] { "A", "X", "Alternate" })]
		public ButtonControl primaryButton
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

		[Preserve]
		[InputControl(aliases = new string[] { "B", "Y", "Primary" })]
		public ButtonControl secondaryButton
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

		[Preserve]
		[InputControl(aliases = new string[] { "GripButton" })]
		public ButtonControl gripPressed
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

		[Preserve]
		[InputControl]
		public ButtonControl start
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

		[Preserve]
		[InputControl(aliases = new string[] { "JoystickOrPadPressed", "thumbstickClick" })]
		public ButtonControl thumbstickClicked
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

		[Preserve]
		[InputControl(aliases = new string[] { "ATouched", "XTouched", "ATouch", "XTouch" })]
		public ButtonControl primaryTouched
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

		[Preserve]
		[InputControl(aliases = new string[] { "BTouched", "YTouched", "BTouch", "YTouch" })]
		public ButtonControl secondaryTouched
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

		[Preserve]
		[InputControl(aliases = new string[] { "indexTouch", "indexNearTouched" })]
		public AxisControl triggerTouched
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

		[Preserve]
		[InputControl(aliases = new string[] { "indexButton", "indexTouched" })]
		public ButtonControl triggerPressed
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

		[Preserve]
		[InputControl(aliases = new string[] { "JoystickOrPadTouched", "thumbstickTouch" })]
		public ButtonControl thumbstickTouched
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

		[Preserve]
		[InputControl(aliases = new string[] { "controllerTrackingState" })]
		public new IntegerControl trackingState
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

		[Preserve]
		[InputControl(aliases = new string[] { "ControllerIsTracked" })]
		public new ButtonControl isTracked
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

		[Preserve]
		[InputControl(aliases = new string[] { "controllerPosition" })]
		public new Vector3Control devicePosition
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

		[Preserve]
		[InputControl(aliases = new string[] { "controllerRotation" })]
		public new QuaternionControl deviceRotation
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

		[Preserve]
		[InputControl(aliases = new string[] { "controllerVelocity" })]
		public Vector3Control deviceVelocity
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

		[Preserve]
		[InputControl(aliases = new string[] { "controllerAngularVelocity" })]
		public Vector3Control deviceAngularVelocity
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

		[Preserve]
		[InputControl(aliases = new string[] { "controllerAcceleration" })]
		public Vector3Control deviceAcceleration
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

		[Preserve]
		[InputControl(aliases = new string[] { "controllerAngularAcceleration" })]
		public Vector3Control deviceAngularAcceleration
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

		protected override void FinishSetup()
		{
		}
	}
}
