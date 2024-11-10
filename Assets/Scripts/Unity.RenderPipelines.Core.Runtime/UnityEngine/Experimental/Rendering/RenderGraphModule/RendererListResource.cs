using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal struct RendererListResource
	{
		public RendererListDesc desc;

		public RendererList rendererList;

		internal RendererListResource(in RendererListDesc desc)
		{
		}
	}
}
