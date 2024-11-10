using System;
using System.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class ANTLRStringStream : ICharStream, IIntStream
	{
		protected internal char[] data;

		protected int n;

		protected internal int p;

		protected internal int line;

		protected internal int charPositionInLine;

		protected internal int markDepth;

		protected internal IList markers;

		protected int lastMarker;

		protected string name;

		public virtual int Line
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int CharPositionInLine
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual string SourceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected ANTLRStringStream()
		{
		}

		public ANTLRStringStream(string input)
		{
		}

		public ANTLRStringStream(char[] data, int numberOfActualCharsInArray)
		{
		}

		public virtual void Reset()
		{
		}

		public virtual void Consume()
		{
		}

		public virtual int LA(int i)
		{
			return 0;
		}

		public virtual int LT(int i)
		{
			return 0;
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

		public virtual int Mark()
		{
			return 0;
		}

		public virtual void Rewind(int m)
		{
		}

		public virtual void Rewind()
		{
		}

		public virtual void Release(int marker)
		{
		}

		public virtual void Seek(int index)
		{
		}

		public virtual string Substring(int start, int stop)
		{
			return null;
		}
	}
}
