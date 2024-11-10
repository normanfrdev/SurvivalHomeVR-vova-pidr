using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray16 : IBitArray
	{
		[SerializeField]
		private ushort data;

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

		public BitArray16(ushort initValue)
		{
		}

		public BitArray16(IEnumerable<uint> bitIndexTrue)
		{
		}

		public static BitArray16 operator ~(BitArray16 a)
		{
			return default(BitArray16);
		}

		public static BitArray16 operator |(BitArray16 a, BitArray16 b)
		{
			return default(BitArray16);
		}

		public static BitArray16 operator &(BitArray16 a, BitArray16 b)
		{
			return default(BitArray16);
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

		public static bool operator ==(BitArray16 a, BitArray16 b)
		{
			return false;
		}

		public static bool operator !=(BitArray16 a, BitArray16 b)
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
