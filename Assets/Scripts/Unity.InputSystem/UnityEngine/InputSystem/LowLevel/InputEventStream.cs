namespace UnityEngine.InputSystem.LowLevel
{
	internal struct InputEventStream
	{
		private InputEventBuffer m_NativeBuffer;

		private unsafe InputEvent* m_CurrentNativeEventReadPtr;

		private unsafe InputEvent* m_CurrentNativeEventWritePtr;

		private int m_RemainingNativeEventCount;

		private readonly int m_MaxAppendedEvents;

		private InputEventBuffer m_AppendBuffer;

		private unsafe InputEvent* m_CurrentAppendEventReadPtr;

		private unsafe InputEvent* m_CurrentAppendEventWritePtr;

		private int m_RemainingAppendEventCount;

		private int m_NumEventsRetainedInBuffer;

		private bool m_IsOpen;

		public bool isOpen => false;

		public int remainingEventCount => 0;

		public int numEventsRetainedInBuffer => 0;

		public unsafe InputEvent* currentEventPtr => (InputEvent*)unchecked((nint)null);

		public uint numBytesRetainedInBuffer => 0u;

		public InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents)
		{
		}

		public void Close(ref InputEventBuffer eventBuffer)
		{
		}

		public void CleanUpAfterException()
		{
		}

		public unsafe void Write(InputEvent* eventPtr)
		{
		}

		public unsafe InputEvent* Advance(bool leaveEventInBuffer)
		{
			//IL_0002: Expected I, but got O
			return (InputEvent*)unchecked((nint)null);
		}

		public unsafe InputEvent* Peek()
		{
			//IL_0002: Expected I, but got O
			return (InputEvent*)unchecked((nint)null);
		}
	}
}
