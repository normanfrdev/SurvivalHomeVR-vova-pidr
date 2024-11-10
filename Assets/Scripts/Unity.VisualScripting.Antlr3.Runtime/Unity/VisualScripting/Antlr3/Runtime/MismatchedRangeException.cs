using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class MismatchedRangeException : RecognitionException
	{
		private int a;

		private int b;

		public int A
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int B
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public MismatchedRangeException()
		{
		}

		public MismatchedRangeException(int a, int b, IIntStream input)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
