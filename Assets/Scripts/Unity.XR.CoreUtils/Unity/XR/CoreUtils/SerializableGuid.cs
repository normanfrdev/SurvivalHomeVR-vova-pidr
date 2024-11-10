using System;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	[Serializable]
	public struct SerializableGuid : IEquatable<SerializableGuid>
	{
		private static readonly SerializableGuid k_Empty;

		[SerializeField]
		[HideInInspector]
		private ulong m_GuidLow;

		[SerializeField]
		[HideInInspector]
		private ulong m_GuidHigh;

		public static SerializableGuid Empty => default(SerializableGuid);

		public Guid Guid => default(Guid);

		public SerializableGuid(ulong guidLow, ulong guidHigh)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public bool Equals(SerializableGuid other)
		{
			return false;
		}

		public static bool operator ==(SerializableGuid lhs, SerializableGuid rhs)
		{
			return false;
		}

		public static bool operator !=(SerializableGuid lhs, SerializableGuid rhs)
		{
			return false;
		}
	}
}
