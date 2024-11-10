using System;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal struct BuddyAllocator : IDisposable
	{
		private struct Header
		{
			public int branchingOrder;

			public int levelCount;

			public int allocationCount;

			public int freeAllocationIdsCount;
		}

		private unsafe void* m_Data;

		private (int, int) m_ActiveFreeMaskCounts;

		private (int, int) m_FreeMasksStorage;

		private (int, int) m_FreeMaskIndicesStorage;

		private Allocator m_Allocator;

		private unsafe ref Header header => ref *(Header*)null;

		private NativeArray<int> freeMaskCounts => default(NativeArray<int>);

		private NativeArray<ulong> freeMasksStorage => default(NativeArray<ulong>);

		private NativeArray<int> freeMaskIndicesStorage => default(NativeArray<int>);

		public int levelCount => 0;

		private NativeArray<ulong> FreeMasks(int level)
		{
			return default(NativeArray<ulong>);
		}

		private NativeArray<int> FreeMaskIndices(int level)
		{
			return default(NativeArray<int>);
		}

		public BuddyAllocator(int levelCount, int branchingOrder, Allocator allocator = Allocator.Persistent)
		{
		}

		public bool TryAllocate(int requestedLevel, out BuddyAllocation allocation)
		{
			allocation = default(BuddyAllocation);
			return false;
		}

		public void Free(BuddyAllocation allocation)
		{
		}

		public void Dispose()
		{
		}

		private NativeArray<T> GetNativeArray<T>(int offset, int length) where T : struct
		{
			return default(NativeArray<T>);
		}

		private static int LevelOffset(int level, int branchingOrder)
		{
			return 0;
		}

		private static int LevelLength(int level, int branchingOrder)
		{
			return 0;
		}

		private static int LevelOffset64(int level, int branchingOrder)
		{
			return 0;
		}

		private static int LevelLength64(int level, int branchingOrder)
		{
			return 0;
		}

		private static (int, int) AllocateRange<T>(int length, ref int dataSize) where T : struct
		{
			return default((int, int));
		}

		private static int AlignForward(int offset, int alignment)
		{
			return 0;
		}

		private unsafe static void* PtrAdd(void* ptr, int bytes)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}

		private static int Pow2(int n)
		{
			return 0;
		}

		private static int Pow2N(int x, int n)
		{
			return 0;
		}
	}
}
