using System;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class ColorTweenableVariable : TweenableVariableAsyncBase<Color>
	{
		private ColorBlendMode colorBlendMode
		{
			[CompilerGenerated]
			get
			{
				return default(ColorBlendMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private float colorBlendAmount
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override JobHandle ScheduleTweenJob(ref TweenJobData<Color> jobData)
		{
			return default(JobHandle);
		}

		public ColorTweenableVariable()
		{
			((TweenableVariableAsyncBase<>)(object)this)._002Ector();
		}
	}
}
