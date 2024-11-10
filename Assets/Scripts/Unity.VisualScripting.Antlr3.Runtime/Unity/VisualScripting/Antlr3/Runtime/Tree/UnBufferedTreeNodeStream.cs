using System;
using System.Collections;
using System.Text;
using Unity.VisualScripting.Antlr3.Runtime.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class UnBufferedTreeNodeStream : ITreeNodeStream, IIntStream
	{
		protected class TreeWalkState
		{
			protected internal int currentChildIndex;

			protected internal int absoluteNodeIndex;

			protected internal object currentNode;

			protected internal object previousNode;

			protected internal int nodeStackSize;

			protected internal int indexStackSize;

			protected internal object[] lookahead;
		}

		public const int INITIAL_LOOKAHEAD_BUFFER_SIZE = 5;

		private ITree currentEnumerationNode;

		protected bool uniqueNavigationNodes;

		protected internal object root;

		protected ITokenStream tokens;

		private ITreeAdaptor adaptor;

		protected internal StackList nodeStack;

		protected internal StackList indexStack;

		protected internal object currentNode;

		protected internal object previousNode;

		protected internal int currentChildIndex;

		protected int absoluteNodeIndex;

		protected internal object[] lookahead;

		protected internal int head;

		protected internal int tail;

		protected IList markers;

		protected int markDepth;

		protected int lastMarker;

		protected object down;

		protected object up;

		protected object eof;

		public virtual object TreeSource => null;

		public virtual object Current => null;

		public virtual int Count => 0;

		public ITreeAdaptor TreeAdaptor => null;

		public string SourceName => null;

		public ITokenStream TokenStream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasUniqueNavigationNodes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected int LookaheadSize => 0;

		public virtual void Reset()
		{
		}

		public virtual bool MoveNext()
		{
			return false;
		}

		public UnBufferedTreeNodeStream(object tree)
		{
		}

		public UnBufferedTreeNodeStream(ITreeAdaptor adaptor, object tree)
		{
		}

		public virtual object Get(int i)
		{
			return null;
		}

		public virtual object LT(int k)
		{
			return null;
		}

		protected internal virtual void fill(int k)
		{
		}

		protected internal virtual void AddLookahead(object node)
		{
		}

		public virtual void Consume()
		{
		}

		public virtual int LA(int i)
		{
			return 0;
		}

		public virtual int Mark()
		{
			return 0;
		}

		public virtual void Release(int marker)
		{
		}

		public virtual void Rewind(int marker)
		{
		}

		public void Rewind()
		{
		}

		public virtual void Seek(int index)
		{
		}

		public virtual int Index()
		{
			return 0;
		}

		[Obsolete("Please use property Count instead.")]
		public virtual int Size()
		{
			return 0;
		}

		protected internal virtual object handleRootNode()
		{
			return null;
		}

		protected internal virtual object VisitChild(int child)
		{
			return null;
		}

		protected internal virtual void AddNavigationNode(int ttype)
		{
		}

		protected internal virtual void WalkBackToMostRecentNodeWithUnvisitedChildren()
		{
		}

		public void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string ToString(object start, object stop)
		{
			return null;
		}

		protected internal virtual void ToStringWork(object p, object stop, StringBuilder buf)
		{
		}
	}
}
