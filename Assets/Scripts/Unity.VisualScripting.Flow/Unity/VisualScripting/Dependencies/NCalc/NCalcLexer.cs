using Unity.VisualScripting.Antlr3.Runtime;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class NCalcLexer : Lexer
	{
		protected class DFA7 : DFA
		{
			public override string Description => null;

			public DFA7(BaseRecognizer recognizer)
			{
			}
		}

		protected class DFA14 : DFA
		{
			public override string Description => null;

			public DFA14(BaseRecognizer recognizer)
			{
			}
		}

		protected DFA7 dfa7;

		protected DFA14 dfa14;

		public const int T__29 = 29;

		public const int T__28 = 28;

		public const int T__27 = 27;

		public const int T__26 = 26;

		public const int T__25 = 25;

		public const int T__24 = 24;

		public const int LETTER = 12;

		public const int T__23 = 23;

		public const int T__22 = 22;

		public const int T__21 = 21;

		public const int T__20 = 20;

		public const int FLOAT = 5;

		public const int ID = 10;

		public const int EOF = -1;

		public const int HexDigit = 17;

		public const int T__19 = 19;

		public const int NAME = 11;

		public const int DIGIT = 13;

		public const int T__42 = 42;

		public const int INTEGER = 4;

		public const int E = 14;

		public const int T__43 = 43;

		public const int T__40 = 40;

		public const int T__41 = 41;

		public const int T__46 = 46;

		public const int T__47 = 47;

		public const int T__44 = 44;

		public const int T__45 = 45;

		public const int T__48 = 48;

		public const int DATETIME = 7;

		public const int TRUE = 8;

		public const int T__30 = 30;

		public const int T__31 = 31;

		public const int T__32 = 32;

		public const int WS = 18;

		public const int T__33 = 33;

		public const int T__34 = 34;

		public const int T__35 = 35;

		public const int T__36 = 36;

		public const int T__37 = 37;

		public const int T__38 = 38;

		public const int T__39 = 39;

		public const int UnicodeEscape = 16;

		public const int FALSE = 9;

		public const int EscapeSequence = 15;

		public const int STRING = 6;

		private const string DFA7_eotS = "\u0004\uffff";

		private const string DFA7_eofS = "\u0004\uffff";

		private const string DFA7_minS = "\u0002.\u0002\uffff";

		private const string DFA7_maxS = "\u00019\u0001e\u0002\uffff";

		private const string DFA7_acceptS = "\u0002\uffff\u0001\u0001\u0001\u0002";

		private const string DFA7_specialS = "\u0004\uffff}>";

		private const string DFA14_eotS = "\u0003\uffff\u0001!\u0001\u001e\u0001$\u0001\u001e\u0001\uffff\u0001'\u0001)\u0001-\u00010\u0005\uffff\u0001\u001e\u0004\uffff\u0003\u001e\u00016\b\uffff\u00017\u0002\uffff\u0001\u001e\v\uffff\u0003\u001e\u0001\uffff\u0001\u001e\u0002\uffff\u0001<\u0001=\u0002\u001e\u0002\uffff\u0001@\u0001\u001e\u0001\uffff\u0001B\u0001\uffff";

		private const string DFA14_eofS = "C\uffff";

		private const string DFA14_minS = "\u0001\t\u0002\uffff\u0001|\u0001r\u0001&\u0001n\u0001\uffff\u0002=\u0001<\u0001=\u0005\uffff\u0001o\u0004\uffff\u0001r\u0001a\u0001+\u0001.\b\uffff\u00010\u0002\uffff\u0001d\v\uffff\u0001t\u0001u\u0001l\u0001\uffff\u00010\u0002\uffff\u00020\u0001e\u0001s\u0002\uffff\u00010\u0001e\u0001\uffff\u00010\u0001\uffff";

		private const string DFA14_maxS = "\u0001~\u0002\uffff\u0001|\u0001r\u0001&\u0001n\u0001\uffff\u0002=\u0002>\u0005\uffff\u0001o\u0004\uffff\u0001r\u0001a\u00019\u0001e\b\uffff\u0001z\u0002\uffff\u0001d\v\uffff\u0001t\u0001u\u0001l\u0001\uffff\u00019\u0002\uffff\u0002z\u0001e\u0001s\u0002\uffff\u0001z\u0001e\u0001\uffff\u0001z\u0001\uffff";

		private const string DFA14_acceptS = "\u0001\uffff\u0001\u0001\u0001\u0002\u0004\uffff\u0001\b\u0004\uffff\u0001\u0014\u0001\u0015\u0001\u0016\u0001\u0017\u0001\u0018\u0001\uffff\u0001\u001b\u0001\u001c\u0001\u001d\u0001\u001e\u0004\uffff\u0001#\u0001$\u0001%\u0001&\u0001!\u0001(\u0001\u0003\u0001\a\u0001\uffff\u0001\u0005\u0001\t\u0001\uffff\u0001\n\u0001\v\u0001\f\u0001\u0019\u0001\r\u0001\u000f\u0001\u0012\u0001\u000e\u0001\u0011\u0001\u0013\u0001\u0010\u0003\uffff\u0001'\u0001\uffff\u0001\"\u0001\u0004\u0004\uffff\u0001\u0006\u0001\u001a\u0002\uffff\u0001\u001f\u0001\uffff\u0001 ";

		private const string DFA14_specialS = "C\uffff}>";

		private static readonly string[] DFA7_transitionS;

		private static readonly short[] DFA7_eot;

		private static readonly short[] DFA7_eof;

		private static readonly char[] DFA7_min;

		private static readonly char[] DFA7_max;

		private static readonly short[] DFA7_accept;

		private static readonly short[] DFA7_special;

		private static readonly short[][] DFA7_transition;

		private static readonly string[] DFA14_transitionS;

		private static readonly short[] DFA14_eot;

		private static readonly short[] DFA14_eof;

		private static readonly char[] DFA14_min;

		private static readonly char[] DFA14_max;

		private static readonly short[] DFA14_accept;

		private static readonly short[] DFA14_special;

		private static readonly short[][] DFA14_transition;

		public override string GrammarFileName => null;

		public NCalcLexer()
		{
		}

		public NCalcLexer(ICharStream input)
		{
		}

		public NCalcLexer(ICharStream input, RecognizerSharedState state)
		{
		}

		private void InitializeCyclicDFAs()
		{
		}

		public void mT__19()
		{
		}

		public void mT__20()
		{
		}

		public void mT__21()
		{
		}

		public void mT__22()
		{
		}

		public void mT__23()
		{
		}

		public void mT__24()
		{
		}

		public void mT__25()
		{
		}

		public void mT__26()
		{
		}

		public void mT__27()
		{
		}

		public void mT__28()
		{
		}

		public void mT__29()
		{
		}

		public void mT__30()
		{
		}

		public void mT__31()
		{
		}

		public void mT__32()
		{
		}

		public void mT__33()
		{
		}

		public void mT__34()
		{
		}

		public void mT__35()
		{
		}

		public void mT__36()
		{
		}

		public void mT__37()
		{
		}

		public void mT__38()
		{
		}

		public void mT__39()
		{
		}

		public void mT__40()
		{
		}

		public void mT__41()
		{
		}

		public void mT__42()
		{
		}

		public void mT__43()
		{
		}

		public void mT__44()
		{
		}

		public void mT__45()
		{
		}

		public void mT__46()
		{
		}

		public void mT__47()
		{
		}

		public void mT__48()
		{
		}

		public void mTRUE()
		{
		}

		public void mFALSE()
		{
		}

		public void mID()
		{
		}

		public void mINTEGER()
		{
		}

		public void mFLOAT()
		{
		}

		public void mSTRING()
		{
		}

		public void mDATETIME()
		{
		}

		public void mNAME()
		{
		}

		public void mE()
		{
		}

		public void mLETTER()
		{
		}

		public void mDIGIT()
		{
		}

		public void mEscapeSequence()
		{
		}

		public void mHexDigit()
		{
		}

		public void mUnicodeEscape()
		{
		}

		public void mWS()
		{
		}

		public override void mTokens()
		{
		}
	}
}
