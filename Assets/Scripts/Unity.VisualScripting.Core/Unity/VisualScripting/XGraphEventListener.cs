namespace Unity.VisualScripting
{
	public static class XGraphEventListener
	{
		public static void StartListening(this IGraphEventListener listener, GraphReference reference)
		{
		}

		public static void StopListening(this IGraphEventListener listener, GraphReference reference)
		{
		}

		public static bool IsHierarchyListening(GraphReference reference)
		{
			return false;
		}
	}
}
