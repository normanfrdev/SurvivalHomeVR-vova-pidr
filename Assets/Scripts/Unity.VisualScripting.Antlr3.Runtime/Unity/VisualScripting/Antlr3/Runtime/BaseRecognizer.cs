using System;
using System.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public abstract class BaseRecognizer
	{
		public const int MEMO_RULE_FAILED = -2;

		public const int MEMO_RULE_UNKNOWN = -1;

		public const int INITIAL_FOLLOW_STACK_SIZE = 100;

		public const int DEFAULT_TOKEN_CHANNEL = 0;

		public const int HIDDEN = 99;

		public static readonly string NEXT_TOKEN_RULE_NAME;

		protected internal RecognizerSharedState state;

		public abstract IIntStream Input { get; }

		public int BacktrackingLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int NumberOfSyntaxErrors => 0;

		public virtual string GrammarFileName => null;

		public abstract string SourceName { get; }

		public virtual string[] TokenNames => null;

		public BaseRecognizer()
		{
		}

		public BaseRecognizer(RecognizerSharedState state)
		{
		}

		public virtual void BeginBacktrack(int level)
		{
		}

		public virtual void EndBacktrack(int level, bool successful)
		{
		}

		public bool Failed()
		{
			return false;
		}

		public virtual void Reset()
		{
		}

		public virtual object Match(IIntStream input, int ttype, BitSet follow)
		{
			return null;
		}

		public virtual void MatchAny(IIntStream input)
		{
		}

		public bool MismatchIsUnwantedToken(IIntStream input, int ttype)
		{
			return false;
		}

		public bool MismatchIsMissingToken(IIntStream input, BitSet follow)
		{
			return false;
		}

		public virtual void ReportError(RecognitionException e)
		{
		}

		public virtual void DisplayRecognitionError(string[] tokenNames, RecognitionException e)
		{
		}

		public virtual string GetErrorMessage(RecognitionException e, string[] tokenNames)
		{
			return null;
		}

		public virtual string GetErrorHeader(RecognitionException e)
		{
			return null;
		}

		public virtual string GetTokenErrorDisplay(IToken t)
		{
			return null;
		}

		public virtual void EmitErrorMessage(string msg)
		{
		}

		public virtual void Recover(IIntStream input, RecognitionException re)
		{
		}

		public virtual void BeginResync()
		{
		}

		public virtual void EndResync()
		{
		}

		protected internal virtual object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow)
		{
			return null;
		}

		public virtual object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow)
		{
			return null;
		}

		public virtual void ConsumeUntil(IIntStream input, int tokenType)
		{
		}

		public virtual void ConsumeUntil(IIntStream input, BitSet set)
		{
		}

		public virtual IList GetRuleInvocationStack()
		{
			return null;
		}

		public static IList GetRuleInvocationStack(Exception e, string recognizerClassName)
		{
			return null;
		}

		public virtual IList ToStrings(IList tokens)
		{
			return null;
		}

		public virtual int GetRuleMemoization(int ruleIndex, int ruleStartIndex)
		{
			return 0;
		}

		public virtual bool AlreadyParsedRule(IIntStream input, int ruleIndex)
		{
			return false;
		}

		public virtual void Memoize(IIntStream input, int ruleIndex, int ruleStartIndex)
		{
		}

		public int GetRuleMemoizationCacheSize()
		{
			return 0;
		}

		public virtual void TraceIn(string ruleName, int ruleIndex, object inputSymbol)
		{
		}

		public virtual void TraceOut(string ruleName, int ruleIndex, object inputSymbol)
		{
		}

		protected internal virtual BitSet ComputeErrorRecoverySet()
		{
			return null;
		}

		protected internal virtual BitSet ComputeContextSensitiveRuleFOLLOW()
		{
			return null;
		}

		protected internal virtual BitSet CombineFollows(bool exact)
		{
			return null;
		}

		protected virtual object GetCurrentInputSymbol(IIntStream input)
		{
			return null;
		}

		protected virtual object GetMissingSymbol(IIntStream input, RecognitionException e, int expectedTokenType, BitSet follow)
		{
			return null;
		}

		protected void PushFollow(BitSet fset)
		{
		}
	}
}
