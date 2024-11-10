using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Collections;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class TweenableVariableAsyncBase<T> : TweenableVariableBase<T>, IDisposable where T : struct, IEquatable<T>
	{
		private bool m_OutputInitialized;

		private NativeArray<T> m_JobOutputStore;

		private bool m_CurveDirty;

		private NativeCurve m_NativeCurve;

		private bool m_HasJobPending;

		private JobHandle m_LastJobHandle;

		public new T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public void Dispose()
		{
		}

		private NativeCurve GetNativeCurve()
		{
			return default(NativeCurve);
		}

		private void RefreshCurve()
		{
		}

		protected override void PreprocessTween()
		{
		}

		protected override void ExecuteTween(T startValue, T targetValue, float tweenAmount, bool useCurve = false)
		{
		}

		private void UpdateStateFromCompletedJob()
		{
		}

		protected abstract JobHandle ScheduleTweenJob(ref TweenJobData<T> jobData);

		private NativeArray<T> GetJobOutputStore()
		{
			return default(NativeArray<T>);
		}

		protected override void OnAnimationCurveChanged(AnimationCurve value)
		{
		}

		private bool CompleteJob()
		{
			return false;
		}

		protected TweenableVariableAsyncBase()
		{
			((TweenableVariableBase<>)(object)this)._002Ector();
		}
	}
}
