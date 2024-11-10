using System;

namespace Unity.VisualScripting.FullSerializer.Internal
{
	public struct fsVersionedType
	{
		public fsVersionedType[] Ancestors;

		public string VersionString;

		public Type ModelType;

		public object Migrate(object ancestorInstance)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(fsVersionedType a, fsVersionedType b)
		{
			return false;
		}

		public static bool operator !=(fsVersionedType a, fsVersionedType b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
