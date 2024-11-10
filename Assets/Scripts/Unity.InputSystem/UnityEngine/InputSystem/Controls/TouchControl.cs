using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Controls
{
	[InputControlLayout(stateType = typeof(TouchState))]
	public class TouchControl : InputControl<TouchState>
	{
		public TouchPressControl press
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

		public IntegerControl displayIndex
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

		public IntegerControl touchId
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

		public Vector2Control position
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

		public DeltaControl delta
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

		public AxisControl pressure
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

		public Vector2Control radius
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

		public TouchPhaseControl phase
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

		public ButtonControl indirectTouch
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

		public ButtonControl tap
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

		public IntegerControl tapCount
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

		public DoubleControl startTime
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

		public Vector2Control startPosition
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

		public bool isInProgress => false;

		public TouchControl()
		{
			((InputControl<>)(object)this)._002Ector();
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override TouchState ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(TouchState);
		}

		public unsafe override void WriteValueIntoState(TouchState value, void* statePtr)
		{
		}
	}
}
