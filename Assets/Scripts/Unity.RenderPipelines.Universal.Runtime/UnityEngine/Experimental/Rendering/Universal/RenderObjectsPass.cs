using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	public class RenderObjectsPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RenderObjectsPass pass;

			internal RenderingData renderingData;
		}

		private RenderQueueType renderQueueType;

		private FilteringSettings m_FilteringSettings;

		private RenderObjects.CustomCameraSettings m_CameraSettings;

		private string m_ProfilerTag;

		private ProfilingSampler m_ProfilingSampler;

		private List<ShaderTagId> m_ShaderTagIdList;

		private RenderStateBlock m_RenderStateBlock;

		public Material overrideMaterial
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int overrideMaterialPassIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Shader overrideShader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int overrideShaderPassIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetDetphState(bool writeEnabled, CompareFunction function = CompareFunction.Less)
		{
		}

		public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp)
		{
		}

		public RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		internal RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal override void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData)
		{
		}
	}
}
