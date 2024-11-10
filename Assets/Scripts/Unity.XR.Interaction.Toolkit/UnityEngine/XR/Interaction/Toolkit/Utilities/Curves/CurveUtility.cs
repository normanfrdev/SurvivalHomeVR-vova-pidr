using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Curves
{
	[BurstCompile]
	internal static class CurveUtility
	{
		public delegate void SampleQuadraticBezierPoint_0000042F_0024PostfixBurstDelegate(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point);

		internal static class SampleQuadraticBezierPoint_0000042F_0024BurstDirectCall
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

			public static void Invoke(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point)
			{
				point = default(float3);
			}
		}

		public delegate void SampleCubicBezierPoint_00000430_0024PostfixBurstDelegate(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point);

		internal static class SampleCubicBezierPoint_00000430_0024BurstDirectCall
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

			public static void Invoke(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point)
			{
				point = default(float3);
			}
		}

		public delegate void ElevateQuadraticToCubicBezier_00000431_0024PostfixBurstDelegate(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3);

		internal static class ElevateQuadraticToCubicBezier_00000431_0024BurstDirectCall
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

			public static void Invoke(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3)
			{
				c0 = default(float3);
				c1 = default(float3);
				c2 = default(float3);
				c3 = default(float3);
			}
		}

		public delegate void GenerateCubicBezierCurve_00000432_0024PostfixBurstDelegate(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3> targetPoints);

		internal static class GenerateCubicBezierCurve_00000432_0024BurstDirectCall
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

			public static void Invoke(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3> targetPoints)
			{
			}
		}

		public delegate bool TryGenerateCubicBezierCurve_00000433_0024PostfixBurstDelegate(int numTargetPoints, float curveRatio, in float3 curveOrigin, in float3 curveDirection, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f);

		internal static class TryGenerateCubicBezierCurve_00000433_0024BurstDirectCall
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

			public static bool Invoke(int numTargetPoints, float curveRatio, in float3 curveOrigin, in float3 curveDirection, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f)
			{
				return false;
			}
		}

		public delegate bool TryGenerateCubicBezierCurve_00000434_0024PostfixBurstDelegate(int numTargetPoints, in float3 curveOrigin, in float3 midPoint, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f);

		internal static class TryGenerateCubicBezierCurve_00000434_0024BurstDirectCall
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

			public static bool Invoke(int numTargetPoints, in float3 curveOrigin, in float3 midPoint, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f)
			{
				return false;
			}
		}

		public delegate float ApproximateCubicBezierLength_00000436_0024PostfixBurstDelegate(in float3 p0, in float3 p1, in float3 p2, in float3 p3, int subdivisions);

		internal static class ApproximateCubicBezierLength_00000436_0024BurstDirectCall
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

			public static float Invoke(in float3 p0, in float3 p1, in float3 p2, in float3 p3, int subdivisions)
			{
				return 0f;
			}
		}

		public delegate void SampleProjectilePoint_00000437_0024PostfixBurstDelegate(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point);

		internal static class SampleProjectilePoint_00000437_0024BurstDirectCall
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

			public static void Invoke(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point)
			{
				point = default(float3);
			}
		}

		public delegate void CalculateProjectileFlightTime_00000438_0024PostfixBurstDelegate(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime);

		internal static class CalculateProjectileFlightTime_00000438_0024BurstDirectCall
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

			public static void Invoke(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime)
			{
				flightTime = default(float);
			}
		}

		private const float k_EightEpsilon = 9.536743E-07f;

		[BurstCompile]
		public static void SampleQuadraticBezierPoint(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point)
		{
			point = default(float3);
		}

		[BurstCompile]
		public static void SampleCubicBezierPoint(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point)
		{
			point = default(float3);
		}

		[BurstCompile]
		public static void ElevateQuadraticToCubicBezier(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3)
		{
			c0 = default(float3);
			c1 = default(float3);
			c2 = default(float3);
			c3 = default(float3);
		}

		[BurstCompile]
		public static void GenerateCubicBezierCurve(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3> targetPoints)
		{
		}

		[BurstCompile]
		public static bool TryGenerateCubicBezierCurve(int numTargetPoints, float curveRatio, in float3 curveOrigin, in float3 curveDirection, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f)
		{
			return false;
		}

		[BurstCompile]
		public static bool TryGenerateCubicBezierCurve(int numTargetPoints, in float3 curveOrigin, in float3 midPoint, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f)
		{
			return false;
		}

		private static bool TryGenerateCubicBezierCurveCore(int numTargetPoints, in float3 curveOrigin, in float3 midPoint, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f)
		{
			return false;
		}

		[BurstCompile]
		public static float ApproximateCubicBezierLength(in float3 p0, in float3 p1, in float3 p2, in float3 p3, int subdivisions)
		{
			return 0f;
		}

		[BurstCompile]
		public static void SampleProjectilePoint(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point)
		{
			point = default(float3);
		}

		[BurstCompile]
		public static void CalculateProjectileFlightTime(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime)
		{
			flightTime = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void SampleQuadraticBezierPoint_0024BurstManaged(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point)
		{
			point = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void SampleCubicBezierPoint_0024BurstManaged(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point)
		{
			point = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ElevateQuadraticToCubicBezier_0024BurstManaged(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3)
		{
			c0 = default(float3);
			c1 = default(float3);
			c2 = default(float3);
			c3 = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void GenerateCubicBezierCurve_0024BurstManaged(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3> targetPoints)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool TryGenerateCubicBezierCurve_0024BurstManaged(int numTargetPoints, float curveRatio, in float3 curveOrigin, in float3 curveDirection, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool TryGenerateCubicBezierCurve_0024BurstManaged(int numTargetPoints, in float3 curveOrigin, in float3 midPoint, in float3 endPoint, ref NativeArray<float3> targetPoints, float minLineLength = 0.005f, float startOffset = 0f, float endOffset = 0f)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static float ApproximateCubicBezierLength_0024BurstManaged(in float3 p0, in float3 p1, in float3 p2, in float3 p3, int subdivisions)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void SampleProjectilePoint_0024BurstManaged(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point)
		{
			point = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void CalculateProjectileFlightTime_0024BurstManaged(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime)
		{
			flightTime = default(float);
		}
	}
}
