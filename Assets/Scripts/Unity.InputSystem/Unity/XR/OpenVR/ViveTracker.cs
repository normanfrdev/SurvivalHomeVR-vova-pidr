using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.OpenVR
{
	[InputControlLayout(displayName = "Vive Tracker")]
	public class ViveTracker : TrackedDevice
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

		protected override void FinishSetup()
		{
		}
	}
}
