using System;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	[Serializable]
	public class CommonTree : BaseTree
	{
		public int startIndex;

		public int stopIndex;

		protected IToken token;

		public CommonTree parent;

		public int childIndex;

		public virtual IToken Token => null;

		public override bool IsNil => false;

		public override int Type => 0;

		public override string Text => null;

		public override int Line => 0;

		public override int CharPositionInLine => 0;

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

		public override int ChildIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override ITree Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CommonTree()
		{
		}

		public CommonTree(CommonTree node)
		{
		}

		public CommonTree(IToken t)
		{
		}

		public void SetUnknownTokenBoundaries()
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
	}
}
