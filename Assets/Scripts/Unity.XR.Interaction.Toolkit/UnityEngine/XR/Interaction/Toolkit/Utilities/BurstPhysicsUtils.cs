using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	[BurstCompile]
	public static class BurstPhysicsUtils
	{
		public delegate void GetSphereOverlapParameters_0000035B_0024PostfixBurstDelegate(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance);

		internal static class GetSphereOverlapParameters_0000035B_0024BurstDirectCall
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

			public static void Invoke(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance)
			{
				normalizedOverlapVector = default(Vector3);
				overlapSqrMagnitude = default(float);
				overlapDistance = default(float);
			}
		}

		public delegate void GetConecastParameters_0000035C_0024PostfixBurstDelegate(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax);

		internal static class GetConecastParameters_0000035C_0024BurstDirectCall
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

			public static void Invoke(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax)
			{
				originOffset = default(Vector3);
				radius = default(float);
				castMax = default(float);
			}
		}

		public delegate void GetConecastOffset_0000035D_0024PostfixBurstDelegate(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset);

		internal static class GetConecastOffset_0000035D_0024BurstDirectCall
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

			public static void Invoke(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset)
			{
				coneOffset = default(float);
			}
		}

		[BurstCompile]
		public static void GetSphereOverlapParameters(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance)
		{
			normalizedOverlapVector = default(Vector3);
			overlapSqrMagnitude = default(float);
			overlapDistance = default(float);
		}

		[BurstCompile]
		public static void GetConecastParameters(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax)
		{
			originOffset = default(Vector3);
			radius = default(float);
			castMax = default(float);
		}

		[BurstCompile]
		public static void GetConecastOffset(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset)
		{
			coneOffset = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void GetSphereOverlapParameters_0024BurstManaged(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance)
		{
			normalizedOverlapVector = default(Vector3);
			overlapSqrMagnitude = default(float);
			overlapDistance = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void GetConecastParameters_0024BurstManaged(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax)
		{
			originOffset = default(Vector3);
			radius = default(float);
			castMax = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void GetConecastOffset_0024BurstManaged(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset)
		{
			coneOffset = default(float);
		}
	}
}
