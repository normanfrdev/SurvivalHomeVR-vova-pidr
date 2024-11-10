using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class TextureCurveParameter : VolumeParameter<TextureCurve>
	{
		public TextureCurveParameter(TextureCurve value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public override void Release()
		{
		}
	}
}
