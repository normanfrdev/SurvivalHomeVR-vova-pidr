using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class MismatchedSetException : RecognitionException
	{
		public BitSet expecting;

		public MismatchedSetException()
		{
		}

		public MismatchedSetException(BitSet expecting, IIntStream input)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
