using System;
using UnityEngine;

namespace Unity.VisualScripting
{
	public sealed class AnimationCurveCloner : Cloner<AnimationCurve>
	{
		public override bool Handles(Type type)
		{
			return false;
		}

		public override AnimationCurve ConstructClone(Type type, AnimationCurve original)
		{
			return null;
		}

		public override void FillClone(Type type, ref AnimationCurve clone, AnimationCurve original, CloningContext context)
		{
		}

		public AnimationCurveCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
