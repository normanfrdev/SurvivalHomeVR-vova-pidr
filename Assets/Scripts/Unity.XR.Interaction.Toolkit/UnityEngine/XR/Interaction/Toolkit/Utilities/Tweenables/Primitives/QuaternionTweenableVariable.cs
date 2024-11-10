using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class QuaternionTweenableVariable : TweenableVariableSynchronousBase<Quaternion>
	{
		public float angleEqualityThreshold
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override Quaternion Lerp(Quaternion from, Quaternion to, float t)
		{
			return default(Quaternion);
		}

		protected override bool IsNearlyEqual(Quaternion startValue, Quaternion targetValue)
		{
			return false;
		}

		public QuaternionTweenableVariable()
		{
			((TweenableVariableSynchronousBase<>)(object)this)._002Ector();
		}
	}
}
