using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace Unity.XR.Oculus.Input
{
	[Preserve]
	[InputControlLayout(displayName = "Oculus Remote")]
	public class OculusRemote : InputDevice
	{
		[Preserve]
		[InputControl]
		public ButtonControl back
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
		[InputControl]
		public Vector2Control touchpad
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
