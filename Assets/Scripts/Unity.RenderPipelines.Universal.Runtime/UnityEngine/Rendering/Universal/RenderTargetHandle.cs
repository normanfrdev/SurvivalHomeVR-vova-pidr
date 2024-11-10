using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	[Obsolete("Deprecated in favor of RTHandle")]
	public struct RenderTargetHandle
	{
		public static readonly RenderTargetHandle CameraTarget;

		public int id
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private RenderTargetIdentifier rtid
		{
			[CompilerGenerated]
			readonly get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier)
		{
		}

		public RenderTargetHandle(RTHandle rtHandle)
		{
		}

		internal static RenderTargetHandle GetCameraTarget(ref CameraData cameraData)
		{
			return default(RenderTargetHandle);
		}

		public void Init(string shaderProperty)
		{
		}

		public void Init(RenderTargetIdentifier renderTargetIdentifier)
		{
		}

		public RenderTargetIdentifier Identifier()
		{
			return default(RenderTargetIdentifier);
		}

		public bool HasInternalRenderTargetId()
		{
			return false;
		}

		public bool Equals(RenderTargetHandle other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return false;
		}

		public static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return false;
		}
	}
}
