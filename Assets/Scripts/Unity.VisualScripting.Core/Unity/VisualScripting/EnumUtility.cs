using System;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class EnumUtility
	{
		public static bool HasFlag(this Enum value, Enum flag)
		{
			return false;
		}

		public static Dictionary<string, Enum> ValuesByNames(Type enumType, bool obsolete = false)
		{
			return null;
		}

		public static Dictionary<string, T> ValuesByNames<T>(bool obsolete = false)
		{
			return null;
		}
	}
}
