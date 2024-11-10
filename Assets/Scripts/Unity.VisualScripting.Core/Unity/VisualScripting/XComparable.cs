using System;

namespace Unity.VisualScripting
{
	internal static class XComparable
	{
		internal static bool IsLt<T>(this IComparable<T> x, T y)
		{
			return false;
		}

		internal static bool IsEq<T>(this IComparable<T> x, T y)
		{
			return false;
		}

		internal static bool IsGt<T>(this IComparable<T> x, T y)
		{
			return false;
		}
	}
}
