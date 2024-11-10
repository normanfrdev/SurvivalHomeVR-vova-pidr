using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class RenderGraphPass
	{
		public List<ResourceHandle>[] resourceReadLists;

		public List<ResourceHandle>[] resourceWriteLists;

		public List<ResourceHandle>[] transientResourceList;

		public List<RendererListHandle> usedRendererListList;

		public string name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int index
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ProfilingSampler customSampler
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool enableAsyncCompute
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool allowPassCulling
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public TextureHandle depthBuffer
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public TextureHandle[] colorBuffers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int colorBufferMaxIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int refCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool generateDebugData
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool allowRendererListCulling
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public RenderFunc<PassData> GetExecuteDelegate<PassData>() where PassData : class, new()
		{
			return null;
		}

		public abstract void Execute(RenderGraphContext renderGraphContext);

		public abstract void Release(RenderGraphObjectPool pool);

		public abstract bool HasRenderFunc();

		public RenderGraphPass()
		{
		}

		public void Clear()
		{
		}

		public void AddResourceWrite(in ResourceHandle res)
		{
		}

		public void AddResourceRead(in ResourceHandle res)
		{
		}

		public void AddTransientResource(in ResourceHandle res)
		{
		}

		public void UseRendererList(RendererListHandle rendererList)
		{
		}

		public void EnableAsyncCompute(bool value)
		{
		}

		public void AllowPassCulling(bool value)
		{
		}

		public void AllowRendererListCulling(bool value)
		{
		}

		public void GenerateDebugData(bool value)
		{
		}

		public void SetColorBuffer(TextureHandle resource, int index)
		{
		}

		public void SetDepthBuffer(TextureHandle resource, DepthAccess flags)
		{
		}
	}
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class RenderGraphPass<PassData> : RenderGraphPass where PassData : class, new()
	{
		internal PassData data;

		internal RenderFunc<PassData> renderFunc;

		public override void Execute(RenderGraphContext renderGraphContext)
		{
		}

		public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler)
		{
		}

		public override void Release(RenderGraphObjectPool pool)
		{
		}

		public override bool HasRenderFunc()
		{
			return false;
		}
	}
}
