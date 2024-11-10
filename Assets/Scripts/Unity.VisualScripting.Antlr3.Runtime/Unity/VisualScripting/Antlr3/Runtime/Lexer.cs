namespace Unity.VisualScripting.Antlr3.Runtime
{
	public abstract class Lexer : BaseRecognizer, ITokenSource
	{
		private const int TOKEN_dot_EOF = -1;

		protected internal ICharStream input;

		public virtual ICharStream CharStream
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

		public virtual int Line => 0;

		public virtual int CharPositionInLine => 0;

		public virtual int CharIndex => 0;

		public virtual string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Lexer()
		{
		}

		public Lexer(ICharStream input)
		{
		}

		public Lexer(ICharStream input, RecognizerSharedState state)
		{
		}

		public override void Reset()
		{
		}

		public virtual IToken NextToken()
		{
			return null;
		}

		public void Skip()
		{
		}

		public abstract void mTokens();

		public virtual void Emit(IToken token)
		{
		}

		public virtual IToken Emit()
		{
			return null;
		}

		public virtual void Match(string s)
		{
		}

		public virtual void MatchAny()
		{
		}

		public virtual void Match(int c)
		{
		}

		public virtual void MatchRange(int a, int b)
		{
		}

		public virtual void Recover(RecognitionException re)
		{
		}

		public override void ReportError(RecognitionException e)
		{
		}

		public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
		{
			return null;
		}

		public string GetCharErrorDisplay(int c)
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
