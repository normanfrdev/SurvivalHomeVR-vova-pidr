using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class GraphData<TGraph> : IGraphData where TGraph : class, IGraph
	{
		protected TGraph definition
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected Dictionary<IGraphElementWithData, IGraphElementData> elementsData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected Dictionary<IGraphParentElement, IGraphData> childrenGraphsData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected Dictionary<Guid, IGraphElementData> phantomElementsData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected Dictionary<Guid, IGraphData> phantomChildrenGraphsData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public GraphData(TGraph definition)
		{
		}

		public bool TryGetElementData(IGraphElementWithData element, out IGraphElementData data)
		{
			data = null;
			return false;
		}

		public bool TryGetChildGraphData(IGraphParentElement element, out IGraphData data)
		{
			data = null;
			return false;
		}

		public IGraphElementData CreateElementData(IGraphElementWithData element)
		{
			return null;
		}

		public void FreeElementData(IGraphElementWithData element)
		{
		}

		public IGraphData CreateChildGraphData(IGraphParentElement element)
		{
			return null;
		}

		public void FreeChildGraphData(IGraphParentElement element)
		{
		}
	}
}
