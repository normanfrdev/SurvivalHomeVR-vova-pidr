using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class ReferenceEqualityComparer : IEqualityComparer<object>
	{
		public static readonly ReferenceEqualityComparer Instance;

		private ReferenceEqualityComparer()
		{
		}

		bool IEqualityComparer<object>.Equals(object a, object b)
		{
			return false;
		}

		int IEqualityComparer<object>.GetHashCode(object a)
		{
			return 0;
		}

		public static int GetHashCode(object a)
		{
			return 0;
		}
	}
	public class ReferenceEqualityComparer<T> : IEqualityComparer<T>
	{
		public static readonly ReferenceEqualityComparer<T> Instance;

		private ReferenceEqualityComparer()
		{
		}

		bool IEqualityComparer<T>.Equals(T a, T b)
		{
			return false;
		}

		int IEqualityComparer<T>.GetHashCode(T a)
		{
			return 0;
		}

		public static int GetHashCode(T a)
		{
			return 0;
		}
	}
}
