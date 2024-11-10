using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class Empty<T>
	{
		public static readonly T[] array;

		public static readonly List<T> list;

		public static readonly HashSet<T> hashSet;
	}
}
