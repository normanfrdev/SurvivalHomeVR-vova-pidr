namespace Unity.VisualScripting
{
	public struct EventHook
	{
		public readonly string name;

		public readonly object target;

		public readonly object tag;

		public EventHook(string name, object target = null, object tag = null)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(EventHook other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(EventHook a, EventHook b)
		{
			return false;
		}

		public static bool operator !=(EventHook a, EventHook b)
		{
			return false;
		}

		public static implicit operator EventHook(string name)
		{
			return default(EventHook);
		}
	}
}
