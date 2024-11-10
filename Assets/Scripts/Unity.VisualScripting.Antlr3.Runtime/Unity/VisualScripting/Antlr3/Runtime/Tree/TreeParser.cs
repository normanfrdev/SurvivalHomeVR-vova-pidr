using System.Text.RegularExpressions;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class TreeParser : BaseRecognizer
	{
		public const int DOWN = 2;

		public const int UP = 3;

		private static readonly string dotdot;

		private static readonly string doubleEtc;

		private static readonly string spaces;

		private static readonly Regex dotdotPattern;

		private static readonly Regex doubleEtcPattern;

		private static readonly Regex spacesPattern;

		protected internal ITreeNodeStream input;

		public virtual ITreeNodeStream TreeNodeStream
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

		public TreeParser(ITreeNodeStream input)
		{
		}

		public TreeParser(ITreeNodeStream input, RecognizerSharedState state)
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

		public override void Reset()
		{
		}

		public override void MatchAny(IIntStream ignore)
		{
		}

		protected internal override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow)
		{
			return null;
		}

		public override string GetErrorHeader(RecognitionException e)
		{
			return null;
		}

		public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
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
