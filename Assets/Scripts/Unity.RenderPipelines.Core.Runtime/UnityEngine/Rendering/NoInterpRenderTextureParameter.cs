using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture>
	{
		public NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
