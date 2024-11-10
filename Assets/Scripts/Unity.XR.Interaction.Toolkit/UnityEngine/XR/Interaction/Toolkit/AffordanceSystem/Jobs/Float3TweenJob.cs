using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs
{
	[BurstCompile]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public struct Float3TweenJob : ITweenJob<float3>, IJob
	{
		public TweenJobData<float3> jobData
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TweenJobData<float3>);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Execute()
		{
		}

		public float3 Lerp(float3 from, float3 to, float t)
		{
			return default(float3);
		}

		public bool IsNearlyEqual(float3 from, float3 to)
		{
			return false;
		}
	}
}
