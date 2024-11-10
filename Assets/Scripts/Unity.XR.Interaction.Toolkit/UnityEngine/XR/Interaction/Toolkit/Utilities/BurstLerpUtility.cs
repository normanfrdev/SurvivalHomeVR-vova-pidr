using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	[BurstCompile]
	public static class BurstLerpUtility
	{
		public delegate void BezierLerp_0000033F_0024PostfixBurstDelegate(in float3 start, in float3 end, float t, out float3 result, float controlHeightFactor = 0.5f);

		internal static class BezierLerp_0000033F_0024BurstDirectCall
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

			public static void Invoke(in float3 start, in float3 end, float t, out float3 result, float controlHeightFactor = 0.5f)
			{
				result = default(float3);
			}
		}

		public delegate float BezierLerp_00000340_0024PostfixBurstDelegate(float start, float end, float t, float controlHeightFactor = 0.5f);

		internal static class BezierLerp_00000340_0024BurstDirectCall
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

			public static float Invoke(float start, float end, float t, float controlHeightFactor = 0.5f)
			{
				return 0f;
			}
		}

		public delegate void BounceOutLerp_00000342_0024PostfixBurstDelegate(in float3 start, in float3 end, float t, out float3 result, float speed = 1f);

		internal static class BounceOutLerp_00000342_0024BurstDirectCall
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

			public static void Invoke(in float3 start, in float3 end, float t, out float3 result, float speed = 1f)
			{
				result = default(float3);
			}
		}

		public delegate float BounceOutLerp_00000343_0024PostfixBurstDelegate(float start, float end, float t, float speed = 1f);

		internal static class BounceOutLerp_00000343_0024BurstDirectCall
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

			public static float Invoke(float start, float end, float t, float speed = 1f)
			{
				return 0f;
			}
		}

		public delegate void SingleBounceOutLerp_00000346_0024PostfixBurstDelegate(in float3 start, in float3 end, float t, out float3 result, float speed = 1f);

		internal static class SingleBounceOutLerp_00000346_0024BurstDirectCall
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

			public static void Invoke(in float3 start, in float3 end, float t, out float3 result, float speed = 1f)
			{
				result = default(float3);
			}
		}

		public delegate float SingleBounceOutLerp_00000347_0024PostfixBurstDelegate(float start, float end, float t, float speed = 1f);

		internal static class SingleBounceOutLerp_00000347_0024BurstDirectCall
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

			public static float Invoke(float start, float end, float t, float speed = 1f)
			{
				return 0f;
			}
		}

		public static Vector3 BezierLerp(in Vector3 start, in Vector3 end, float t, float controlHeightFactor = 0.5f)
		{
			return default(Vector3);
		}

		[BurstCompile]
		public static void BezierLerp(in float3 start, in float3 end, float t, out float3 result, float controlHeightFactor = 0.5f)
		{
			result = default(float3);
		}

		[BurstCompile]
		public static float BezierLerp(float start, float end, float t, float controlHeightFactor = 0.5f)
		{
			return 0f;
		}

		public static Vector3 BounceOutLerp(Vector3 start, Vector3 end, float t, float speed = 1f)
		{
			return default(Vector3);
		}

		[BurstCompile]
		public static void BounceOutLerp(in float3 start, in float3 end, float t, out float3 result, float speed = 1f)
		{
			result = default(float3);
		}

		[BurstCompile]
		public static float BounceOutLerp(float start, float end, float t, float speed = 1f)
		{
			return 0f;
		}

		private static float EaseOutBounce(float t, float speed = 1f)
		{
			return 0f;
		}

		public static Vector3 SingleBounceOutLerp(Vector3 start, Vector3 end, float t, float speed = 1f)
		{
			return default(Vector3);
		}

		[BurstCompile]
		public static void SingleBounceOutLerp(in float3 start, in float3 end, float t, out float3 result, float speed = 1f)
		{
			result = default(float3);
		}

		[BurstCompile]
		public static float SingleBounceOutLerp(float start, float end, float t, float speed = 1f)
		{
			return 0f;
		}

		private static float EaseOutBounceSingle(float t, float speed = 1f)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void BezierLerp_0024BurstManaged(in float3 start, in float3 end, float t, out float3 result, float controlHeightFactor = 0.5f)
		{
			result = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static float BezierLerp_0024BurstManaged(float start, float end, float t, float controlHeightFactor = 0.5f)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void BounceOutLerp_0024BurstManaged(in float3 start, in float3 end, float t, out float3 result, float speed = 1f)
		{
			result = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static float BounceOutLerp_0024BurstManaged(float start, float end, float t, float speed = 1f)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void SingleBounceOutLerp_0024BurstManaged(in float3 start, in float3 end, float t, out float3 result, float speed = 1f)
		{
			result = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static float SingleBounceOutLerp_0024BurstManaged(float start, float end, float t, float speed = 1f)
		{
			return 0f;
		}
	}
}
