using System;
using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class CommonTokenStream : ITokenStream, IIntStream
	{
		protected ITokenSource tokenSource;

		protected IList tokens;

		protected IDictionary channelOverrideMap;

		protected HashList discardSet;

		protected int channel;

		protected bool discardOffChannelTokens;

		protected int lastMarker;

		protected int p;

		public virtual ITokenSource TokenSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string SourceName => null;

		public virtual int Count => 0;

		public CommonTokenStream()
		{
		}

		public CommonTokenStream(ITokenSource tokenSource)
		{
		}

		public CommonTokenStream(ITokenSource tokenSource, int channel)
		{
		}

		public virtual IToken LT(int k)
		{
			return null;
		}

		public virtual IToken Get(int i)
		{
			return null;
		}

		public virtual string ToString(int start, int stop)
		{
			return null;
		}

		public virtual string ToString(IToken start, IToken stop)
		{
			return null;
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

		public virtual int Index()
		{
			return 0;
		}

		public virtual void Rewind(int marker)
		{
		}

		public virtual void Rewind()
		{
		}

		public virtual void Reset()
		{
		}

		public virtual void Release(int marker)
		{
		}

		public virtual void Seek(int index)
		{
		}

		[Obsolete("Please use the property Count instead.")]
		public virtual int Size()
		{
			return 0;
		}

		protected virtual void FillBuffer()
		{
		}

		protected virtual int SkipOffTokenChannels(int i)
		{
			return 0;
		}

		protected virtual int SkipOffTokenChannelsReverse(int i)
		{
			return 0;
		}

		public virtual void SetTokenTypeChannel(int ttype, int channel)
		{
		}

		public virtual void DiscardTokenType(int ttype)
		{
		}

		public virtual void DiscardOffChannelTokens(bool discardOffChannelTokens)
		{
		}

		public virtual IList GetTokens()
		{
			return null;
		}

		public virtual IList GetTokens(int start, int stop)
		{
			return null;
		}

		public virtual IList GetTokens(int start, int stop, BitSet types)
		{
			return null;
		}

		public virtual IList GetTokens(int start, int stop, IList types)
		{
			return null;
		}

		public virtual IList GetTokens(int start, int stop, int ttype)
		{
			return null;
		}

		protected virtual IToken LB(int k)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
