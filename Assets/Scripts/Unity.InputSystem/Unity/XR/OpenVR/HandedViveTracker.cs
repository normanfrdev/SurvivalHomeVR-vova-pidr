using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.OpenVR
{
	[InputControlLayout(displayName = "Handed Vive Tracker", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
	public class HandedViveTracker : ViveTracker
	{
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
		public ButtonControl primary
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

		[InputControl(aliases = new string[] { "JoystickOrPadPressed" })]
		public ButtonControl trackpadPressed
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

		protected override void FinishSetup()
		{
		}
	}
}
