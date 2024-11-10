using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class ColorParameter : VolumeParameter<Color>
	{
		[NonSerialized]
		public bool hdr;

		[NonSerialized]
		public bool showAlpha;

		[NonSerialized]
		public bool showEyeDropper;

		public ColorParameter(Color value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public ColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public override void Interp(Color from, Color to, float t)
		{
		}
	}
}
