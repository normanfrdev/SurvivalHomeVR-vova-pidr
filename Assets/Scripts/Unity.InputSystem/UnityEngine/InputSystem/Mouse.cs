using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(stateType = typeof(MouseState), isGenericTypeOfDevice = true)]
	public class Mouse : Pointer, IInputStateCallbackReceiver
	{
		internal static Mouse s_PlatformMouseDevice;

		public DeltaControl scroll
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

		public ButtonControl leftButton
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

		public ButtonControl middleButton
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

		public ButtonControl rightButton
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

		public ButtonControl backButton
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

		public ButtonControl forwardButton
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

		public IntegerControl clickCount
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

		public new static Mouse current
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

		public override void MakeCurrent()
		{
		}

		protected override void OnAdded()
		{
		}

		protected override void OnRemoved()
		{
		}

		public void WarpCursorPosition(Vector2 position)
		{
		}

		protected override void FinishSetup()
		{
		}

		protected new void OnNextUpdate()
		{
		}

		protected new void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		void IInputStateCallbackReceiver.OnNextUpdate()
		{
		}

		void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr)
		{
		}
	}
}
