using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs
{
	[BurstCompile]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public struct Float2TweenJob : ITweenJob<float2>, IJob
	{
		public TweenJobData<float2> jobData
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TweenJobData<float2>);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Execute()
		{
		}

		public float2 Lerp(float2 from, float2 to, float t)
		{
			return default(float2);
		}

		public bool IsNearlyEqual(float2 from, float2 to)
		{
			return false;
		}
	}
}
