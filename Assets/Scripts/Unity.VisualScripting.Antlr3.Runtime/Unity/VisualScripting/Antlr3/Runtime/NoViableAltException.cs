using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class NoViableAltException : RecognitionException
	{
		public string grammarDecisionDescription;

		public int decisionNumber;

		public int stateNumber;

		public NoViableAltException()
		{
		}

		public NoViableAltException(string grammarDecisionDescription, int decisionNumber, int stateNumber, IIntStream input)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
