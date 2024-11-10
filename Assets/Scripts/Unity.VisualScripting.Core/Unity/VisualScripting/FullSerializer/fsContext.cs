using System;
using System.Collections.Generic;

namespace Unity.VisualScripting.FullSerializer
{
	public sealed class fsContext
	{
		private readonly Dictionary<Type, object> _contextObjects;

		public void Reset()
		{
		}

		public void Set<T>(T obj)
		{
		}

		public bool Has<T>()
		{
			return false;
		}

		public T Get<T>()
		{
			return default(T);
		}
	}
}
