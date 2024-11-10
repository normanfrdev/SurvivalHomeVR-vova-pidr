using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class MismatchedTokenException : RecognitionException
	{
		private int expecting;

		public int Expecting
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public MismatchedTokenException()
		{
		}

		public MismatchedTokenException(int expecting, IIntStream input)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
