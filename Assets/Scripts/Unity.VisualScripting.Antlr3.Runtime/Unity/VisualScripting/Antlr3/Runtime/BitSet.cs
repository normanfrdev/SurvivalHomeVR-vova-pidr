using System.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class BitSet
	{
		protected internal const int BITS = 64;

		protected internal const int LOG_BITS = 6;

		protected internal static readonly int MOD_MASK;

		protected internal ulong[] bits;

		public virtual bool Nil => false;

		public virtual int Count => 0;

		public BitSet()
		{
		}

		public BitSet(ulong[] bits_)
		{
		}

		public BitSet(IList items)
		{
		}

		public BitSet(int nbits)
		{
		}

		public static BitSet Of(int el)
		{
			return null;
		}

		public static BitSet Of(int a, int b)
		{
			return null;
		}

		public static BitSet Of(int a, int b, int c)
		{
			return null;
		}

		public static BitSet Of(int a, int b, int c, int d)
		{
			return null;
		}

		public virtual BitSet Or(BitSet a)
		{
			return null;
		}

		public virtual void Add(int el)
		{
		}

		public virtual void GrowToInclude(int bit)
		{
		}

		public virtual void OrInPlace(BitSet a)
		{
		}

		public virtual object Clone()
		{
			return null;
		}

		public virtual bool Member(int el)
		{
			return false;
		}

		public virtual void Remove(int el)
		{
		}

		public virtual int NumBits()
		{
			return 0;
		}

		public virtual int LengthInLongWords()
		{
			return 0;
		}

		public virtual int[] ToArray()
		{
			return null;
		}

		public virtual ulong[] ToPackedArray()
		{
			return null;
		}

		private static int WordNumber(int bit)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string ToString(string[] tokenNames)
		{
			return null;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private static ulong BitMask(int bitNumber)
		{
			return 0uL;
		}

		private void SetSize(int nwords)
		{
		}

		private int NumWordsToHold(int el)
		{
			return 0;
		}
	}
}
