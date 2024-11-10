namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class CommonTreeAdaptor : BaseTreeAdaptor
	{
		public override object DupNode(object t)
		{
			return null;
		}

		public override object Create(IToken payload)
		{
			return null;
		}

		public override IToken CreateToken(int tokenType, string text)
		{
			return null;
		}

		public override IToken CreateToken(IToken fromToken)
		{
			return null;
		}

		public override void SetTokenBoundaries(object t, IToken startToken, IToken stopToken)
		{
		}

		public override int GetTokenStartIndex(object t)
		{
			return 0;
		}

		public override int GetTokenStopIndex(object t)
		{
			return 0;
		}

		public override string GetNodeText(object t)
		{
			return null;
		}

		public override int GetNodeType(object t)
		{
			return 0;
		}

		public override IToken GetToken(object treeNode)
		{
			return null;
		}

		public override object GetChild(object t, int i)
		{
			return null;
		}

		public override int GetChildCount(object t)
		{
			return 0;
		}

		public override object GetParent(object t)
		{
			return null;
		}

		public override void SetParent(object t, object parent)
		{
		}

		public override int GetChildIndex(object t)
		{
			return 0;
		}

		public override void SetChildIndex(object t, int index)
		{
		}

		public override void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t)
		{
		}
	}
}
