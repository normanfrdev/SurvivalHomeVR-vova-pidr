using System.Collections.Generic;
using System.Diagnostics;

namespace Unity.VisualScripting.FullSerializer
{
	public sealed class fsData
	{
		private object _value;

		public static readonly fsData True;

		public static readonly fsData False;

		public static readonly fsData Null;

		public fsDataType Type => default(fsDataType);

		public bool IsNull => false;

		public bool IsDouble => false;

		public bool IsInt64 => false;

		public bool IsBool => false;

		public bool IsString => false;

		public bool IsDictionary => false;

		public bool IsList => false;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public double AsDouble => 0.0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long AsInt64 => 0L;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool AsBool => false;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string AsString => null;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Dictionary<string, fsData> AsDictionary => null;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public List<fsData> AsList => null;

		public override string ToString()
		{
			return null;
		}

		public fsData()
		{
		}

		public fsData(bool boolean)
		{
		}

		public fsData(double f)
		{
		}

		public fsData(long i)
		{
		}

		public fsData(string str)
		{
		}

		public fsData(Dictionary<string, fsData> dict)
		{
		}

		public fsData(List<fsData> list)
		{
		}

		public static fsData CreateDictionary()
		{
			return null;
		}

		public static fsData CreateList()
		{
			return null;
		}

		public static fsData CreateList(int capacity)
		{
			return null;
		}

		internal void BecomeDictionary()
		{
		}

		internal fsData Clone()
		{
			return null;
		}

		private T Cast<T>()
		{
			return default(T);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(fsData other)
		{
			return false;
		}

		public static bool operator ==(fsData a, fsData b)
		{
			return false;
		}

		public static bool operator !=(fsData a, fsData b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
