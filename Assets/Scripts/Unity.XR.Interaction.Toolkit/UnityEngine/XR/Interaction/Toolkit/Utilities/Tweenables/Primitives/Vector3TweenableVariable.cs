using System;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class Vector3TweenableVariable : TweenableVariableAsyncBase<float3>
	{
		protected override JobHandle ScheduleTweenJob(ref TweenJobData<float3> jobData)
		{
			return default(JobHandle);
		}

		public Vector3TweenableVariable()
		{
			((TweenableVariableAsyncBase<>)(object)this)._002Ector();
		}
	}
}
