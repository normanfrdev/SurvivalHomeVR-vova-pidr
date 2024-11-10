using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class GraphDebugData : IGraphDebugData
	{
		protected Dictionary<IGraphElementWithDebugData, IGraphElementDebugData> elementsData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected Dictionary<IGraphParentElement, IGraphDebugData> childrenGraphsData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		IEnumerable<IGraphElementDebugData> IGraphDebugData.elementsData => null;

		public GraphDebugData(IGraph definition)
		{
		}

		public IGraphElementDebugData GetOrCreateElementData(IGraphElementWithDebugData element)
		{
			return null;
		}

		public IGraphDebugData GetOrCreateChildGraphData(IGraphParentElement element)
		{
			return null;
		}
	}
}
