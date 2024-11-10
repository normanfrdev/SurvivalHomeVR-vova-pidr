using System.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public abstract class BaseTreeAdaptor : ITreeAdaptor
	{
		protected IDictionary treeToUniqueIDMap;

		protected int uniqueNodeID;

		public virtual object GetNilNode()
		{
			return null;
		}

		public virtual object ErrorNode(ITokenStream input, IToken start, IToken stop, RecognitionException e)
		{
			return null;
		}

		public virtual bool IsNil(object tree)
		{
			return false;
		}

		public virtual object DupTree(object tree)
		{
			return null;
		}

		public virtual object DupTree(object t, object parent)
		{
			return null;
		}

		public virtual void AddChild(object t, object child)
		{
		}

		public virtual object BecomeRoot(object newRoot, object oldRoot)
		{
			return null;
		}

		public virtual object RulePostProcessing(object root)
		{
			return null;
		}

		public virtual object BecomeRoot(IToken newRoot, object oldRoot)
		{
			return null;
		}

		public virtual object Create(int tokenType, IToken fromToken)
		{
			return null;
		}

		public virtual object Create(int tokenType, IToken fromToken, string text)
		{
			return null;
		}

		public virtual object Create(int tokenType, string text)
		{
			return null;
		}

		public virtual int GetNodeType(object t)
		{
			return 0;
		}

		public virtual void SetNodeType(object t, int type)
		{
		}

		public virtual string GetNodeText(object t)
		{
			return null;
		}

		public virtual void SetNodeText(object t, string text)
		{
		}

		public virtual object GetChild(object t, int i)
		{
			return null;
		}

		public virtual void SetChild(object t, int i, object child)
		{
		}

		public virtual object DeleteChild(object t, int i)
		{
			return null;
		}

		public virtual int GetChildCount(object t)
		{
			return 0;
		}

		public abstract object DupNode(object param1);

		public abstract object Create(IToken param1);

		public abstract void SetTokenBoundaries(object param1, IToken param2, IToken param3);

		public abstract int GetTokenStartIndex(object t);

		public abstract int GetTokenStopIndex(object t);

		public abstract IToken GetToken(object treeNode);

		public int GetUniqueID(object node)
		{
			return 0;
		}

		public abstract IToken CreateToken(int tokenType, string text);

		public abstract IToken CreateToken(IToken fromToken);

		public abstract object GetParent(object t);

		public abstract void SetParent(object t, object parent);

		public abstract int GetChildIndex(object t);

		public abstract void SetChildIndex(object t, int index);

		public abstract void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t);
	}
}
