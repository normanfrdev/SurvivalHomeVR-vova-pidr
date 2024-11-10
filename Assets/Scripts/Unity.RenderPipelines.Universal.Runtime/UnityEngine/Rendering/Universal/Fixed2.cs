using System.Diagnostics;

namespace UnityEngine.Rendering.Universal
{
	internal struct Fixed2<T> where T : unmanaged
	{
		public T item1;

		public T item2;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public Fixed2(T item1)
		{
		}

		public Fixed2(T item1, T item2)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private static void CheckRange(int index)
		{
		}
	}
}
