namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class TreePatternParser
	{
		protected TreePatternLexer tokenizer;

		protected int ttype;

		protected TreeWizard wizard;

		protected ITreeAdaptor adaptor;

		public TreePatternParser(TreePatternLexer tokenizer, TreeWizard wizard, ITreeAdaptor adaptor)
		{
		}

		public object Pattern()
		{
			return null;
		}

		public object ParseTree()
		{
			return null;
		}

		public object ParseNode()
		{
			return null;
		}
	}
}
