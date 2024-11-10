using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.SmartTweenableVariables
{
	[BurstCompile]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class SmartFollowVector3TweenableVariable : Vector3TweenableVariable
	{
		public delegate void ComputeNewTweenTarget_0000040E_0024PostfixBurstDelegate(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget);

		internal static class ComputeNewTweenTarget_0000040E_0024BurstDirectCall
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

			public static void Invoke(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget)
			{
				newTweenTarget = default(float);
			}
		}

		public delegate bool IsNewTargetWithinThreshold_0000040F_0024PostfixBurstDelegate(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds);

		internal static class IsNewTargetWithinThreshold_0000040F_0024BurstDirectCall
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

			public static bool Invoke(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds)
			{
				return false;
			}
		}

		private float m_MaxDistanceAllowed;

		private float m_SqrMaxDistanceAllowed;

		private float m_LastUpdateTime;

		public float minDistanceAllowed
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

		public float maxDistanceAllowed
		{
			get
			{
				return 0f;
			}
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

		public SmartFollowVector3TweenableVariable(float minDistanceAllowed = 0.01f, float maxDistanceAllowed = 0.3f, float minToMaxDelaySeconds = 3f)
		{
		}

		public bool IsNewTargetWithinThreshold(float3 newTarget)
		{
			return false;
		}

		public bool SetTargetWithinThreshold(float3 newTarget)
		{
			return false;
		}

		protected override void OnTargetChanged(float3 newTarget)
		{
		}

		public void HandleSmartTween(float deltaTime, float lowerSpeed, float upperSpeed)
		{
		}

		[BurstCompile]
		private static void ComputeNewTweenTarget(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget)
		{
			newTweenTarget = default(float);
		}

		[BurstCompile]
		private static bool IsNewTargetWithinThreshold(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ComputeNewTweenTarget_0024BurstManaged(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget)
		{
			newTweenTarget = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool IsNewTargetWithinThreshold_0024BurstManaged(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds)
		{
			return false;
		}
	}
}
