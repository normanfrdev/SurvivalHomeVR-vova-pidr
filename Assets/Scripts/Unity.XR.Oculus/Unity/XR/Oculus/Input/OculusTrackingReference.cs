using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace Unity.XR.Oculus.Input
{
	[Preserve]
	[InputControlLayout(displayName = "Oculus Tracking Reference")]
	public class OculusTrackingReference : InputDevice
	{
		[Preserve]
		[InputControl(aliases = new string[] { "trackingReferenceTrackingState" })]
		public IntegerControl trackingState
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
		[InputControl(aliases = new string[] { "trackingReferenceIsTracked" })]
		public ButtonControl isTracked
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
		public Vector3Control devicePosition
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
		public QuaternionControl deviceRotation
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
