using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	public class QuaternionControl : InputControl<Quaternion>
	{
		[InputControl(displayName = "X")]
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

		[InputControl(displayName = "Y")]
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

		[InputControl(displayName = "Z")]
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

		[InputControl(displayName = "W")]
		public AxisControl w
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

		public QuaternionControl()
		{
			((InputControl<>)(object)this)._002Ector();
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override Quaternion ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Quaternion);
		}

		public unsafe override void WriteValueIntoState(Quaternion value, void* statePtr)
		{
		}

		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
