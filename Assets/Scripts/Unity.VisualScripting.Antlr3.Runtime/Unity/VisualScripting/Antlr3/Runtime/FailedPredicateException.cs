using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class FailedPredicateException : RecognitionException
	{
		public string ruleName;

		public string predicateText;

		public FailedPredicateException()
		{
		}

		public FailedPredicateException(IIntStream input, string ruleName, string predicateText)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
