using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	public class Vector3Control : InputControl<Vector3>
	{
		[InputControl(offset = 0u, displayName = "X")]
		public AxisControl x
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

		[InputControl(offset = 4u, displayName = "Y")]
		public AxisControl y
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

		[InputControl(offset = 8u, displayName = "Z")]
		public AxisControl z
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

		public Vector3Control()
		{
			((InputControl<>)(object)this)._002Ector();
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override Vector3 ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Vector3);
		}

		public unsafe override void WriteValueIntoState(Vector3 value, void* statePtr)
		{
		}

		public unsafe override float EvaluateMagnitude(void* statePtr)
		{
			return 0f;
		}

		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
