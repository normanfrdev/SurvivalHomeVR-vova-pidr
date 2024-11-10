using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = true)]
	public class Pointer : InputDevice, IInputStateCallbackReceiver
	{
		public Vector2Control position
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

		public DeltaControl delta
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

		public Vector2Control radius
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

		public AxisControl pressure
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

		public ButtonControl press
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

		public IntegerControl displayIndex
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

		public static Pointer current
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public override void MakeCurrent()
		{
		}

		protected override void OnRemoved()
		{
		}

		protected override void FinishSetup()
		{
		}

		protected void OnNextUpdate()
		{
		}

		protected void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		void IInputStateCallbackReceiver.OnNextUpdate()
		{
		}

		void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr)
		{
		}

		bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
		{
			return false;
		}
	}
}
