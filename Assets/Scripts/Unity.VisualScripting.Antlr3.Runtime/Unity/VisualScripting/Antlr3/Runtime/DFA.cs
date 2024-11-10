namespace Unity.VisualScripting.Antlr3.Runtime
{
	public abstract class DFA
	{
		public delegate int SpecialStateTransitionHandler(DFA dfa, int s, IIntStream input);

		public const bool debug = false;

		protected short[] eot;

		protected short[] eof;

		protected char[] min;

		protected char[] max;

		protected short[] accept;

		protected short[] special;

		protected short[][] transition;

		protected int decisionNumber;

		public SpecialStateTransitionHandler specialStateTransitionHandler;

		protected BaseRecognizer recognizer;

		public virtual string Description => null;

		public int Predict(IIntStream input)
		{
			return 0;
		}

		protected void NoViableAlt(int s, IIntStream input)
		{
		}

		public virtual void Error(NoViableAltException nvae)
		{
		}

		public virtual int SpecialStateTransition(int s, IIntStream input)
		{
			return 0;
		}

		public static short[] UnpackEncodedString(string encodedString)
		{
			return null;
		}

		public static short[][] UnpackEncodedStringArray(string[] encodedStrings)
		{
			return null;
		}

		public static char[] UnpackEncodedStringToUnsignedChars(string encodedString)
		{
			return null;
		}

		public int SpecialTransition(int state, int symbol)
		{
			return 0;
		}
	}
}
