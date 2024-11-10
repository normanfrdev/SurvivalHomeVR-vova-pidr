namespace UnityEngine.Rendering
{
	public struct ListBuffer<T> where T : unmanaged
	{
		private unsafe T* m_BufferPtr;

		private int m_Capacity;

		private unsafe int* m_CountPtr;

		internal unsafe T* BufferPtr => (T*)unchecked((nint)null);

		public int Count => 0;

		public int Capacity => 0;

		public unsafe ref T this[in int index] => ref *(T*)null;

		public unsafe ListBuffer(T* bufferPtr, int* countPtr, int capacity)
		{
		}

		public unsafe ref T GetUnchecked(in int index)
		{
			return ref *(T*)null;
		}

		public bool TryAdd(in T value)
		{
			return false;
		}

		public unsafe void CopyTo(T* dstBuffer, int startDstIndex, int copyCount)
		{
		}

		public bool TryCopyTo(ListBuffer<T> other)
		{
			return false;
		}

		public unsafe bool TryCopyFrom(T* srcPtr, int count)
		{
			return false;
		}
	}
}
