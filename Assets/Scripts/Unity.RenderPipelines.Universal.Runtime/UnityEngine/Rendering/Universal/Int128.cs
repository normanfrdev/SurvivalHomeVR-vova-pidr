namespace UnityEngine.Rendering.Universal
{
	internal struct Int128
	{
		private long hi;

		private ulong lo;

		public Int128(long _lo)
		{
		}

		public Int128(long _hi, ulong _lo)
		{
		}

		public Int128(Int128 val)
		{
		}

		public bool IsNegative()
		{
			return false;
		}

		public static bool operator ==(Int128 val1, Int128 val2)
		{
			return false;
		}

		public static bool operator !=(Int128 val1, Int128 val2)
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

		public static bool operator >(Int128 val1, Int128 val2)
		{
			return false;
		}

		public static bool operator <(Int128 val1, Int128 val2)
		{
			return false;
		}

		public static Int128 operator +(Int128 lhs, Int128 rhs)
		{
			return default(Int128);
		}

		public static Int128 operator -(Int128 lhs, Int128 rhs)
		{
			return default(Int128);
		}

		public static Int128 operator -(Int128 val)
		{
			return default(Int128);
		}

		public static explicit operator double(Int128 val)
		{
			return 0.0;
		}

		public static Int128 Int128Mul(long lhs, long rhs)
		{
			return default(Int128);
		}
	}
}
