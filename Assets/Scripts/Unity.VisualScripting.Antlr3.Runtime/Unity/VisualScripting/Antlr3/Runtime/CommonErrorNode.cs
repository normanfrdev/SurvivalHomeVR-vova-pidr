using System;
using Unity.VisualScripting.Antlr3.Runtime.Tree;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	[Serializable]
	public class CommonErrorNode : CommonTree
	{
		public IIntStream input;

		public IToken start;

		public IToken stop;

		[NonSerialized]
		public RecognitionException trappedException;

		public override bool IsNil => false;

		public override int Type => 0;

		public override string Text => null;

		public CommonErrorNode(ITokenStream input, IToken start, IToken stop, RecognitionException e)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
