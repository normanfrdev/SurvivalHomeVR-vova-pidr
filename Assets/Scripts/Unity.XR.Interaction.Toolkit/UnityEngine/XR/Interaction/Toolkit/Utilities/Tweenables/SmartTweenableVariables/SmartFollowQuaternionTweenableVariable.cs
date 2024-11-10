using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.SmartTweenableVariables
{
	[BurstCompile]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class SmartFollowQuaternionTweenableVariable : QuaternionTweenableVariable
	{
		public delegate void ComputeNewTweenTarget_00000402_0024PostfixBurstDelegate(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget);

		internal static class ComputeNewTweenTarget_00000402_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static void Invoke(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget)
			{
				newTweenTarget = default(float);
			}
		}

		private float m_LastUpdateTime;

		public float minAngleAllowed
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

		public float maxAngleAllowed
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

		public float minToMaxDelaySeconds
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

		public SmartFollowQuaternionTweenableVariable(float minAngleAllowed = 0.1f, float maxAngleAllowed = 5f, float minToMaxDelaySeconds = 3f)
		{
		}

		public bool IsNewTargetWithinThreshold(Quaternion newTarget)
		{
			return false;
		}

		public bool SetTargetWithinThreshold(Quaternion newTarget)
		{
			return false;
		}

		protected override void OnTargetChanged(Quaternion newTarget)
		{
		}

		public void HandleSmartTween(float deltaTime, float lowerSpeed, float upperSpeed)
		{
		}

		[BurstCompile]
		private static void ComputeNewTweenTarget(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget)
		{
			newTweenTarget = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ComputeNewTweenTarget_0024BurstManaged(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget)
		{
			newTweenTarget = default(float);
		}
	}
}
