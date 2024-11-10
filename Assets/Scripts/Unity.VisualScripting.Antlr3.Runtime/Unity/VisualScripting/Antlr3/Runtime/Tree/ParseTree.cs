using System.Collections;
using System.Text;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class ParseTree : BaseTree
	{
		public object payload;

		public IList hiddenTokens;

		public override int Type => 0;

		public override string Text => null;

		public override int TokenStartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int TokenStopIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ParseTree(object label)
		{
		}

		public override ITree DupNode()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToStringWithHiddenTokens()
		{
			return null;
		}

		public string ToInputString()
		{
			return null;
		}

		public void _ToStringLeaves(StringBuilder buf)
		{
		}
	}
}
