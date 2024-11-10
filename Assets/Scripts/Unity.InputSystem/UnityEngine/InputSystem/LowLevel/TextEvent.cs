using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	public struct TextEvent : IInputEventTypeInfo
	{
		public const int Type = 1413830740;

		[FieldOffset(0)]
		public InputEvent baseEvent;

		[FieldOffset(20)]
		public int character;

		public FourCC typeStatic => default(FourCC);

		public unsafe static TextEvent* From(InputEventPtr eventPtr)
		{
			//IL_0002: Expected I, but got O
			return (TextEvent*)unchecked((nint)null);
		}

		public static TextEvent Create(int deviceId, char character, double time = -1.0)
		{
			return default(TextEvent);
		}

		public static TextEvent Create(int deviceId, int character, double time = -1.0)
		{
			return default(TextEvent);
		}
	}
}
