using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class ClassicToken : IToken
	{
		protected internal string text;

		protected internal int type;

		protected internal int line;

		protected internal int charPositionInLine;

		protected internal int channel;

		protected internal int index;

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

		public ClassicToken(int type)
		{
		}

		public ClassicToken(IToken oldToken)
		{
		}

		public ClassicToken(int type, string text)
		{
		}

		public ClassicToken(int type, string text, int channel)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
