using System.Text;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class TreePatternLexer
	{
		public const int EOF = -1;

		public const int BEGIN = 1;

		public const int END = 2;

		public const int ID = 3;

		public const int ARG = 4;

		public const int PERCENT = 5;

		public const int COLON = 6;

		public const int DOT = 7;

		protected string pattern;

		protected int p;

		protected int c;

		protected int n;

		public StringBuilder sval;

		public bool error;

		public TreePatternLexer(string pattern)
		{
		}

		public int NextToken()
		{
			return 0;
		}

		protected void Consume()
		{
		}
	}
}
