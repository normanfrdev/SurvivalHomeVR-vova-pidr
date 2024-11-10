using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs
{
	[BurstCompile]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public struct Float4TweenJob : ITweenJob<float4>, IJob
	{
		public TweenJobData<float4> jobData
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TweenJobData<float4>);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Execute()
		{
		}

		public float4 Lerp(float4 from, float4 to, float t)
		{
			return default(float4);
		}

		public bool IsNearlyEqual(float4 from, float4 to)
		{
			return false;
		}
	}
}
