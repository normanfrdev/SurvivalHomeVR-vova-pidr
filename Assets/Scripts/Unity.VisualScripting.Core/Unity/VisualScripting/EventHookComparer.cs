using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class EventHookComparer : IEqualityComparer<EventHook>
	{
		public bool Equals(EventHook x, EventHook y)
		{
			return false;
		}

		public int GetHashCode(EventHook obj)
		{
			return 0;
		}
	}
}
