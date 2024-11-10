using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	public class Vector2Control : InputControl<Vector2>
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

		public Vector2Control()
		{
			((InputControl<>)(object)this)._002Ector();
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override Vector2 ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Vector2);
		}

		public unsafe override void WriteValueIntoState(Vector2 value, void* statePtr)
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
