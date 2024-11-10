using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public class RenderGraphDefaultResources
	{
		private bool m_IsValid;

		private RTHandle m_BlackTexture2D;

		private RTHandle m_WhiteTexture2D;

		private RTHandle m_ShadowTexture2D;

		public TextureHandle blackTexture
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle whiteTexture
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle clearTextureXR
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle magentaTextureXR
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle blackTextureXR
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle blackTextureArrayXR
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle blackUIntTextureXR
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle blackTexture3DXR
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle whiteTextureXR
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextureHandle defaultShadowTexture
		{
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal RenderGraphDefaultResources()
		{
		}

		internal void Cleanup()
		{
		}

		internal void InitializeForRendering(RenderGraph renderGraph)
		{
		}
	}
}
