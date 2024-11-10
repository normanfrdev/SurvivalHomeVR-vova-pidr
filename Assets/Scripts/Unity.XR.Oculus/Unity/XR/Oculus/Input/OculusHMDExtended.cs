using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace Unity.XR.Oculus.Input
{
	[Preserve]
	[InputControlLayout(hideInUI = true, displayName = "Oculus Headset (w/ on-headset controls)")]
	public class OculusHMDExtended : OculusHMD
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
