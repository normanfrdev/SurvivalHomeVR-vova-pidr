using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class AnimationCurveParameter : VolumeParameter<AnimationCurve>
	{
		public AnimationCurveParameter(AnimationCurve value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		public override void Interp(AnimationCurve lhsCurve, AnimationCurve rhsCurve, float t)
		{
		}

		public override void SetValue(VolumeParameter parameter)
		{
		}

		public override object Clone()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
