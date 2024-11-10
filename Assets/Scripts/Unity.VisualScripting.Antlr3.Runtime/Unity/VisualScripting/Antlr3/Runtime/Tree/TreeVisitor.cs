namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class TreeVisitor
	{
		protected ITreeAdaptor adaptor;

		public TreeVisitor(ITreeAdaptor adaptor)
		{
		}

		public TreeVisitor()
		{
		}

		public object Visit(object t, ITreeVisitorAction action)
		{
			return null;
		}
	}
}
