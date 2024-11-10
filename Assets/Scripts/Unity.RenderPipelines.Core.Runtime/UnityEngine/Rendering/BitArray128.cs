using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray128 : IBitArray
	{
		[SerializeField]
		private ulong data1;

		[SerializeField]
		private ulong data2;

		public uint capacity => 0u;

		public bool allFalse => false;

		public bool allTrue => false;

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

		public BitArray128(ulong initValue1, ulong initValue2)
		{
		}

		public BitArray128(IEnumerable<uint> bitIndexTrue)
		{
		}

		public static BitArray128 operator ~(BitArray128 a)
		{
			return default(BitArray128);
		}

		public static BitArray128 operator |(BitArray128 a, BitArray128 b)
		{
			return default(BitArray128);
		}

		public static BitArray128 operator &(BitArray128 a, BitArray128 b)
		{
			return default(BitArray128);
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

		public static bool operator ==(BitArray128 a, BitArray128 b)
		{
			return false;
		}

		public static bool operator !=(BitArray128 a, BitArray128 b)
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
