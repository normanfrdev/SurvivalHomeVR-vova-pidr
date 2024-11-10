using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

namespace UnityEngine.InputSystem.UI
{
	public class ExtendedPointerEventData : PointerEventData
	{
		public InputControl control
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

		public InputDevice device
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

		public int touchId
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

		public UIPointerType pointerType
		{
			[CompilerGenerated]
			get
			{
				return default(UIPointerType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int uiToolkitPointerId
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

		public Vector3 trackedDevicePosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Quaternion trackedDeviceOrientation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ExtendedPointerEventData(EventSystem eventSystem)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal static int MakePointerIdForTouch(int deviceId, int touchId)
		{
			return 0;
		}

		internal static int TouchIdFromPointerId(int pointerId)
		{
			return 0;
		}

		internal void ReadDeviceState()
		{
		}

		private static int GetPenPointerId(Pen pen)
		{
			return 0;
		}

		private static int GetTouchPointerId(TouchControl touchControl)
		{
			return 0;
		}
	}
}
