using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class CommonToken : IToken
	{
		protected internal int type;

		protected internal int line;

		protected internal int charPositionInLine;

		protected internal int channel;

		[NonSerialized]
		protected internal ICharStream input;

		protected internal string text;

		protected internal int index;

		protected internal int start;

		protected internal int stop;

		public virtual int Type
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		public virtual int Channel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int StartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int StopIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int TokenIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual ICharStream InputStream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CommonToken(int type)
		{
		}

		public CommonToken(ICharStream input, int type, int channel, int start, int stop)
		{
		}

		public CommonToken(int type, string text)
		{
		}

		public CommonToken(IToken oldToken)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
