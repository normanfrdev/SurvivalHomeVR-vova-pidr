using System.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class RecognizerSharedState
	{
		public BitSet[] following;

		public int followingStackPointer;

		public bool errorRecovery;

		public int lastErrorIndex;

		public bool failed;

		public int syntaxErrors;

		public int backtracking;

		public IDictionary[] ruleMemo;

		public IToken token;

		public int tokenStartCharIndex;

		public int tokenStartLine;

		public int tokenStartCharPositionInLine;

		public int channel;

		public int type;

		public string text;
	}
}
