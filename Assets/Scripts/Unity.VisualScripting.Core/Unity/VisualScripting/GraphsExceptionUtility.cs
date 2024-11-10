using System;

namespace Unity.VisualScripting
{
	public static class GraphsExceptionUtility
	{
		private const string handledKey = "Bolt.Core.Handled";

		public static Exception GetException(this IGraphElementWithDebugData element, GraphPointer pointer)
		{
			return null;
		}

		public static void SetException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex)
		{
		}

		public static void HandleException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex)
		{
		}

		private static bool HandledIn(this Exception ex, GraphReference reference)
		{
			return false;
		}
	}
}
