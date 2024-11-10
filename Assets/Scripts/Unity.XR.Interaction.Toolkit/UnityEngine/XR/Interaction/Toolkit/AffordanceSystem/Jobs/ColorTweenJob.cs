using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Jobs;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs
{
	[BurstCompile]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public struct ColorTweenJob : ITweenJob<Color>, IJob
	{
		public TweenJobData<Color> jobData
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TweenJobData<Color>);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public byte colorBlendMode
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float colorBlendAmount
		{
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Execute()
		{
		}

		private Color ProcessTargetAffordanceValue(Color initialValue, Color newValue)
		{
			return default(Color);
		}

		public Color Lerp(Color from, Color to, float t)
		{
			return default(Color);
		}

		public bool IsNearlyEqual(Color from, Color to)
		{
			return false;
		}
	}
}
