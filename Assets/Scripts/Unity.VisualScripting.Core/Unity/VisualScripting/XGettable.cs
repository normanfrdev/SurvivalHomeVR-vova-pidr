using System;

namespace Unity.VisualScripting
{
	public static class XGettable
	{
		public static object GetValue(this IGettable gettable, Type type)
		{
			return null;
		}

		public static T GetValue<T>(this IGettable gettable)
		{
			return default(T);
		}
	}
}
