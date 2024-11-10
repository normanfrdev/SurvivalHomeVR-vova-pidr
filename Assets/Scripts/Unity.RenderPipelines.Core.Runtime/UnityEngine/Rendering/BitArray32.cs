using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray32 : IBitArray
	{
		[SerializeField]
		private uint data;

		public uint capacity => 0u;

		public bool allFalse => false;

		public bool allTrue => false;

		private string humanizedVersion => null;

		public string humanizedData => null;

		public bool this[uint index]
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BitArray32(uint initValue)
		{
		}

		public BitArray32(IEnumerable<uint> bitIndexTrue)
		{
		}

		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		public IBitArray BitNot()
		{
			return null;
		}

		public static BitArray32 operator ~(BitArray32 a)
		{
			return default(BitArray32);
		}

		public static BitArray32 operator |(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}

		public static BitArray32 operator &(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}

		public static bool operator ==(BitArray32 a, BitArray32 b)
		{
			return false;
		}

		public static bool operator !=(BitArray32 a, BitArray32 b)
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
