using System;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class Vector2TweenableVariable : TweenableVariableAsyncBase<float2>
	{
		protected override JobHandle ScheduleTweenJob(ref TweenJobData<float2> jobData)
		{
			return default(JobHandle);
		}

		public Vector2TweenableVariable()
		{
			((TweenableVariableAsyncBase<>)(object)this)._002Ector();
		}
	}
}
