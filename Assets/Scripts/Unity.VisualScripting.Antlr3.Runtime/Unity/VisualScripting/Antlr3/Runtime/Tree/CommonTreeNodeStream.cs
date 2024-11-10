using System;
using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class CommonTreeNodeStream : ITreeNodeStream, IIntStream, IEnumerable
	{
		protected sealed class CommonTreeNodeStreamEnumerator : IEnumerator
		{
			private CommonTreeNodeStream _nodeStream;

			private int _index;

			private object _currentItem;

			public object Current => null;

			internal CommonTreeNodeStreamEnumerator()
			{
			}

			internal CommonTreeNodeStreamEnumerator(CommonTreeNodeStream nodeStream)
			{
			}

			public void Reset()
			{
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		public const int DEFAULT_INITIAL_BUFFER_SIZE = 100;

		public const int INITIAL_CALL_STACK_SIZE = 10;

		protected object down;

		protected object up;

		protected object eof;

		protected IList nodes;

		protected internal object root;

		protected ITokenStream tokens;

		private ITreeAdaptor adaptor;

		protected bool uniqueNavigationNodes;

		protected int p;

		protected int lastMarker;

		protected StackList calls;

		public virtual object CurrentSymbol => null;

		public virtual object TreeSource => null;

		public virtual string SourceName => null;

		public virtual ITokenStream TokenStream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ITreeAdaptor TreeAdaptor
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

		public virtual int Count => 0;

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public CommonTreeNodeStream(object tree)
		{
		}

		public CommonTreeNodeStream(ITreeAdaptor adaptor, object tree)
		{
		}

		public CommonTreeNodeStream(ITreeAdaptor adaptor, object tree, int initialBufferSize)
		{
		}

		protected void FillBuffer()
		{
		}

		public void FillBuffer(object t)
		{
		}

		protected int GetNodeIndex(object node)
		{
			return 0;
		}

		protected void AddNavigationNode(int ttype)
		{
		}

		public object Get(int i)
		{
			return null;
		}

		public object LT(int k)
		{
			return null;
		}

		protected object LB(int k)
		{
			return null;
		}

		public void Push(int index)
		{
		}

		public int Pop()
		{
			return 0;
		}

		public void Reset()
		{
		}

		public void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t)
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

		public override string ToString()
		{
			return null;
		}

		public string ToTokenString(int start, int stop)
		{
			return null;
		}

		public virtual string ToString(object start, object stop)
		{
			return null;
		}
	}
}
