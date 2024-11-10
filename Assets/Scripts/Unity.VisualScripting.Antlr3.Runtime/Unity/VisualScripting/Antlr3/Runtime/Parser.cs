namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class Parser : BaseRecognizer
	{
		protected internal ITokenStream input;

		public virtual ITokenStream TokenStream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string SourceName => null;

		public override IIntStream Input => null;

		public Parser(ITokenStream input)
		{
		}

		public Parser(ITokenStream input, RecognizerSharedState state)
		{
		}

		public override void Reset()
		{
		}

		protected override object GetCurrentInputSymbol(IIntStream input)
		{
			return null;
		}

		protected override object GetMissingSymbol(IIntStream input, RecognitionException e, int expectedTokenType, BitSet follow)
		{
			return null;
		}

		public virtual void TraceIn(string ruleName, int ruleIndex)
		{
		}

		public virtual void TraceOut(string ruleName, int ruleIndex)
		{
		}
	}
}
