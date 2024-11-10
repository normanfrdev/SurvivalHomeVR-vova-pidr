using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace UnityEngine.XR.WindowsMR.Input
{
	[InputControlLayout(displayName = "Windows MR Headset", hideInUI = true)]
	public class WMRHMD : XRHMD
	{
		[InputControl]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[] { "HeadPosition" })]
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[] { "HeadRotation" })]
		public ButtonControl userPresence
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
