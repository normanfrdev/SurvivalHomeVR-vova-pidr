using Unity.Collections;

namespace Unity.XR.CoreUtils
{
	public static class NativeArrayUtils
	{
		public static void EnsureCapacity<T>(ref NativeArray<T> array, int capacity, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
		}
	}
}
