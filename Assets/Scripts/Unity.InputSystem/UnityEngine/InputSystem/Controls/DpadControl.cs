using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls
{
	public class DpadControl : Vector2Control
	{
		[InputControlLayout(hideInUI = true)]
		public class DpadAxisControl : AxisControl
		{
			public int component
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			protected override void FinishSetup()
			{
			}

			public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
			{
				return 0f;
			}
		}

		internal enum ButtonBits
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}

		[InputControl(name = "x", layout = "DpadAxis", useStateFrom = "right", synthetic = true)]
		[InputControl(name = "y", layout = "DpadAxis", useStateFrom = "up", synthetic = true)]
		[InputControl(bit = 0u, displayName = "Up")]
		public ButtonControl up
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

		[InputControl(bit = 1u, displayName = "Down")]
		public ButtonControl down
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

		[InputControl(bit = 2u, displayName = "Left")]
		public ButtonControl left
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

		[InputControl(bit = 3u, displayName = "Right")]
		public ButtonControl right
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

		public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true)
		{
			return default(Vector2);
		}

		public static Vector2 MakeDpadVector(float up, float down, float left, float right)
		{
			return default(Vector2);
		}
	}
}
