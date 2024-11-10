using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Jobs;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs
{
	[BurstCompile]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public struct FloatTweenJob : ITweenJob<float>, IJob
	{
		public TweenJobData<float> jobData
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TweenJobData<float>);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Execute()
		{
		}

		public float Lerp(float from, float to, float t)
		{
			return 0f;
		}

		public bool IsNearlyEqual(float from, float to)
		{
			return false;
		}
	}
}
