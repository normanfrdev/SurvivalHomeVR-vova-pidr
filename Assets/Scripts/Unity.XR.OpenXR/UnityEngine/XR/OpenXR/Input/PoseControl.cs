using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Input
{
	[Obsolete("OpenXR.Input.PoseControl is deprecated. Please use UnityEngine.InputSystem.XR.PoseControl instead.", false)]
	public class PoseControl : InputControl<Pose>
	{
		[Preserve]
		[InputControl(offset = 0u)]
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
		[InputControl(offset = 4u)]
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
		[InputControl(offset = 8u, noisy = true)]
		public Vector3Control position
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
		[InputControl(offset = 20u, noisy = true)]
		public QuaternionControl rotation
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
		[InputControl(offset = 36u, noisy = true)]
		public Vector3Control velocity
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
		[InputControl(offset = 48u, noisy = true)]
		public Vector3Control angularVelocity
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

		public PoseControl()
		{
			((InputControl<TValue>)(object)this)._002Ector();
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override Pose ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Pose);
		}

		public unsafe override void WriteValueIntoState(Pose value, void* statePtr)
		{
		}
	}
}
