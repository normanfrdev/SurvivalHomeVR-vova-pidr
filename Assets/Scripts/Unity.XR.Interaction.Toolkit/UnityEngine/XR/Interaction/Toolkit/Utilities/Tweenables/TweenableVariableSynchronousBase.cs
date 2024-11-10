using System;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class TweenableVariableSynchronousBase<T> : TweenableVariableBase<T> where T : IEquatable<T>
	{
		protected override void ExecuteTween(T startValue, T targetValue, float tweenAmount, bool useCurve = false)
		{
		}

		protected abstract T Lerp(T from, T to, float t);

		protected abstract bool IsNearlyEqual(T startValue, T targetValue);

		protected TweenableVariableSynchronousBase()
		{
			((TweenableVariableBase<>)(object)this)._002Ector();
		}
	}
}
