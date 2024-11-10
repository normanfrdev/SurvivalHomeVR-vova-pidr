using System.Diagnostics;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Texture ({handle.index})")]
	public struct TextureHandle
	{
		private static TextureHandle s_NullHandle;

		internal ResourceHandle handle;

		public static TextureHandle nullHandle => default(TextureHandle);

		internal TextureHandle(int handle, bool shared = false)
		{
		}

		public static implicit operator RenderTargetIdentifier(TextureHandle texture)
		{
			return default(RenderTargetIdentifier);
		}

		public static implicit operator Texture(TextureHandle texture)
		{
			return null;
		}

		public static implicit operator RenderTexture(TextureHandle texture)
		{
			return null;
		}

		public static implicit operator RTHandle(TextureHandle texture)
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
