using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class Texture3DParameter : VolumeParameter<Texture>
	{
		public Texture3DParameter(Texture value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
