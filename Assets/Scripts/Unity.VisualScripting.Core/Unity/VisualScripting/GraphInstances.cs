using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class GraphInstances
	{
		private static readonly object @lock;

		private static readonly Dictionary<IGraph, HashSet<GraphReference>> byGraph;

		private static readonly Dictionary<IGraphParent, HashSet<GraphReference>> byParent;

		public static void Instantiate(GraphReference instance)
		{
		}

		public static void Uninstantiate(GraphReference instance)
		{
		}

		public static HashSet<GraphReference> OfPooled(IGraph graph)
		{
			return null;
		}

		public static HashSet<GraphReference> ChildrenOfPooled(IGraphParent parent)
		{
			return null;
		}
	}
}
