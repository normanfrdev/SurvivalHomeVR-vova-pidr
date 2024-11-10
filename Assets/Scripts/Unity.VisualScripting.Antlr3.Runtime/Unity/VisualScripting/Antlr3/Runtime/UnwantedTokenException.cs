namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class UnwantedTokenException : MismatchedTokenException
	{
		public IToken UnexpectedToken => null;

		public UnwantedTokenException()
		{
		}

		public UnwantedTokenException(int expecting, IIntStream input)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
