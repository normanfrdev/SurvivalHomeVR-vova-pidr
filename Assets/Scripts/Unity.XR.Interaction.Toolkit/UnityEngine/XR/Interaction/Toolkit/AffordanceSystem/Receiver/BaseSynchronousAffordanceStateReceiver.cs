using System;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class BaseSynchronousAffordanceStateReceiver<T> : BaseAffordanceStateReceiver<T>, ISynchronousAffordanceStateReceiver, IAffordanceStateReceiver where T : struct, IEquatable<T>
	{
		public virtual void HandleTween(float tweenTarget)
		{
		}

		protected abstract T Interpolate(T startValue, T targetValue, float interpolationAmount);

		protected BaseSynchronousAffordanceStateReceiver()
		{
			((BaseAffordanceStateReceiver<>)(object)this)._002Ector();
		}
	}
}
