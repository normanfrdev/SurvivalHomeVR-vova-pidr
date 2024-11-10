using System;
using System.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	[Serializable]
	public abstract class BaseTree : ITree
	{
		protected IList children;

		public virtual int ChildCount => 0;

		public virtual bool IsNil => false;

		public virtual int Line => 0;

		public virtual int CharPositionInLine => 0;

		public IList Children => null;

		public virtual int ChildIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual ITree Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract int Type { get; }

		public abstract int TokenStartIndex { get; set; }

		public abstract int TokenStopIndex { get; set; }

		public abstract string Text { get; }

		public BaseTree()
		{
		}

		public BaseTree(ITree node)
		{
		}

		public virtual ITree GetChild(int i)
		{
			return null;
		}

		public virtual void AddChild(ITree t)
		{
		}

		public void AddChildren(IList kids)
		{
		}

		public virtual void SetChild(int i, ITree t)
		{
		}

		public virtual object DeleteChild(int i)
		{
			return null;
		}

		public virtual void ReplaceChildren(int startChildIndex, int stopChildIndex, object t)
		{
		}

		protected internal virtual IList CreateChildrenList()
		{
			return null;
		}

		public virtual void FreshenParentAndChildIndexes()
		{
		}

		public virtual void FreshenParentAndChildIndexes(int offset)
		{
		}

		public virtual void SanityCheckParentAndChildIndexes()
		{
		}

		public virtual void SanityCheckParentAndChildIndexes(ITree parent, int i)
		{
		}

		public bool HasAncestor(int ttype)
		{
			return false;
		}

		public ITree GetAncestor(int ttype)
		{
			return null;
		}

		public IList GetAncestors()
		{
			return null;
		}

		public virtual string ToStringTree()
		{
			return null;
		}

		public abstract override string ToString();

		public abstract ITree DupNode();
	}
}
