using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal static class NativeArrayExtensions
	{
		public unsafe static ref T UnsafeElementAt<T>(this NativeArray<T> array, int index) where T : struct
		{
			return ref *(T*)null;
		}

		public unsafe static ref T UnsafeElementAtMutable<T>(this NativeArray<T> array, int index) where T : struct
		{
			return ref *(T*)null;
		}
	}
}
