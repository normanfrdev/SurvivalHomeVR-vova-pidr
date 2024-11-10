using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct TextureDesc
	{
		public TextureSizeMode sizeMode;

		public int width;

		public int height;

		public int slices;

		public Vector2 scale;

		public ScaleFunc func;

		public DepthBits depthBufferBits;

		public GraphicsFormat colorFormat;

		public FilterMode filterMode;

		public TextureWrapMode wrapMode;

		public TextureDimension dimension;

		public bool enableRandomWrite;

		public bool useMipMap;

		public bool autoGenerateMips;

		public bool isShadowMap;

		public int anisoLevel;

		public float mipMapBias;

		public MSAASamples msaaSamples;

		public bool bindTextureMS;

		public bool useDynamicScale;

		public RenderTextureMemoryless memoryless;

		public VRTextureUsage vrUsage;

		public string name;

		public FastMemoryDesc fastMemoryDesc;

		public bool fallBackToBlackTexture;

		public bool disableFallBackToImportedTexture;

		public bool clearBuffer;

		public Color clearColor;

		private void InitDefaultValues(bool dynamicResolution, bool xrReady)
		{
		}

		public TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false)
		{
		}

		public TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false)
		{
		}

		public TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false)
		{
		}

		public TextureDesc(TextureDesc input)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
