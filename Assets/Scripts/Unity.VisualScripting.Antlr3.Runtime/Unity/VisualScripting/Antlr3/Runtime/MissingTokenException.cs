using System;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class MissingTokenException : MismatchedTokenException
	{
		private object inserted;

		public int MissingType => 0;

		public object Inserted
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MissingTokenException()
		{
		}

		public MissingTokenException(int expecting, IIntStream input, object inserted)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
