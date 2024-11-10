using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	public class XRPass
	{
		private readonly List<XRView> m_Views;

		private readonly XROcclusionMesh m_OcclusionMesh;

		public bool enabled => false;

		public bool supportsFoveatedRendering => false;

		public bool copyDepth
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int multipassId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int cullingPassId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RenderTargetIdentifier renderTarget
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RenderTextureDescriptor renderTargetDesc
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ScriptableCullingParameters cullingParams
		{
			[CompilerGenerated]
			get
			{
				return default(ScriptableCullingParameters);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int viewCount => 0;

		public bool singlePassEnabled => false;

		public IntPtr foveatedRenderingInfo
		{
			[CompilerGenerated]
			get
			{
				return (IntPtr)0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isHDRDisplayOutputActive => false;

		public ColorGamut hdrDisplayOutputColorGamut => default(ColorGamut);

		public HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation => default(HDROutputUtils.HDRDisplayInformation);

		public float occlusionMeshScale
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool hasValidOcclusionMesh => false;

		public static XRPass CreateDefault(XRPassCreateInfo createInfo)
		{
			return null;
		}

		public virtual void Release()
		{
		}

		public Matrix4x4 GetProjMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Rect GetViewport(int viewIndex = 0)
		{
			return default(Rect);
		}

		public Mesh GetOcclusionMesh(int viewIndex = 0)
		{
			return null;
		}

		public int GetTextureArraySlice(int viewIndex = 0)
		{
			return 0;
		}

		public void StartSinglePass(CommandBuffer cmd)
		{
		}

		public void StopSinglePass(CommandBuffer cmd)
		{
		}

		public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false)
		{
		}

		public Vector4 ApplyXRViewCenterOffset(Vector2 center)
		{
			return default(Vector4);
		}

		internal void AssignView(int viewId, XRView xrView)
		{
		}

		internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams)
		{
		}

		internal void UpdateCombinedOcclusionMesh()
		{
		}

		public void InitBase(XRPassCreateInfo createInfo)
		{
		}

		internal void AddView(XRView xrView)
		{
		}
	}
}
