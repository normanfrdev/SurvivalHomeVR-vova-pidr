using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class RecognitionException : Exception
	{
		[NonSerialized]
		protected IIntStream input;

		protected int index;

		protected IToken token;

		protected object node;

		protected int c;

		protected int line;

		protected int charPositionInLine;

		public bool approximateLineInfo;

		public IIntStream Input
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IToken Token
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object Node
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Char
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CharPositionInLine
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Line
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int UnexpectedType => 0;

		public RecognitionException()
		{
		}

		public RecognitionException(string message)
		{
		}

		public RecognitionException(string message, Exception inner)
		{
		}

		public RecognitionException(IIntStream input)
		{
		}

		public RecognitionException(string message, IIntStream input)
		{
		}

		public RecognitionException(string message, Exception inner, IIntStream input)
		{
		}

		protected void ExtractInformationFromTreeNodeStream(IIntStream input)
		{
		}
	}
}
