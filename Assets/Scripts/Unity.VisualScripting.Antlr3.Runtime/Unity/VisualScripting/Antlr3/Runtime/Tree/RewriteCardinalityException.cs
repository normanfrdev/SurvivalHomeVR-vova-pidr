using System;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	[Serializable]
	public class RewriteCardinalityException : Exception
	{
		public string elementDescription;

		public override string Message => null;

		public RewriteCardinalityException(string elementDescription)
		{
		}
	}
}
