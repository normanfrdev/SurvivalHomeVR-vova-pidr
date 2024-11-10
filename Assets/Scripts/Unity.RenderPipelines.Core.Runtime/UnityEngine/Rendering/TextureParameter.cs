using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class TextureParameter : VolumeParameter<Texture>
	{
		public TextureDimension dimension;

		public TextureParameter(Texture value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
