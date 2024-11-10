using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Collections;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class BaseAsyncAffordanceStateReceiver<T> : BaseAffordanceStateReceiver<T>, IAsyncAffordanceStateReceiver, IAffordanceStateReceiver where T : struct, IEquatable<T>
	{
		private NativeArray<T> m_JobOutputStore;

		private NativeCurve m_NativeCurve;

		private JobHandle m_LastJobHandle;

		private bool m_OutputInitialized;

		protected virtual void OnDestroy()
		{
		}

		public JobHandle HandleTween(float tweenTarget)
		{
			return default(JobHandle);
		}

		public void UpdateStateFromCompletedJob()
		{
		}

		protected abstract JobHandle ScheduleTweenJob(ref TweenJobData<T> jobData);

		protected override void OnAffordanceThemeChanged(BaseAffordanceTheme<T> newValue)
		{
		}

		private NativeArray<T> GetJobOutputStore()
		{
			return default(NativeArray<T>);
		}

		protected BaseAsyncAffordanceStateReceiver()
		{
			((BaseAffordanceStateReceiver<>)(object)this)._002Ector();
		}
	}
}
