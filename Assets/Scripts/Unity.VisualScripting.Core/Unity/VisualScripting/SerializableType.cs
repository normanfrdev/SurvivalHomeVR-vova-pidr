using System;

namespace Unity.VisualScripting
{
	[Serializable]
	[SerializationVersion("A", new Type[] { })]
	public struct SerializableType : IEquatable<SerializableType>, IComparable<SerializableType>
	{
		[Serialize]
		public string Identification;

		public SerializableType(string identification)
		{
		}

		public bool Equals(SerializableType other)
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

		public static bool operator ==(SerializableType left, SerializableType right)
		{
			return false;
		}

		public static bool operator !=(SerializableType left, SerializableType right)
		{
			return false;
		}

		public int CompareTo(SerializableType other)
		{
			return 0;
		}
	}
}
