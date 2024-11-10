using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Scripting;

namespace UnityEngine.InputSystem.XR
{
	[Preserve]
	[InputControlLayout(stateType = typeof(PoseState))]
	public class PoseControl : InputControl<PoseState>
	{
		public ButtonControl isTracked
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IntegerControl trackingState
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3Control position
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QuaternionControl rotation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3Control velocity
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3Control angularVelocity
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PoseControl()
		{
			((InputControl<>)(object)this)._002Ector();
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override PoseState ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(PoseState);
		}

		public unsafe override void WriteValueIntoState(PoseState value, void* statePtr)
		{
		}

		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
