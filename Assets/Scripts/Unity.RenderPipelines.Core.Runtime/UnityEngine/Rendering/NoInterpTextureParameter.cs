using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpTextureParameter : VolumeParameter<Texture>
	{
		public NoInterpTextureParameter(Texture value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
