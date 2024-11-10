using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	[BurstCompile]
	public static class BurstMathUtility
	{
		public delegate void OrthogonalUpVector_00000349_0024PostfixBurstDelegate(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp);

		internal static class OrthogonalUpVector_00000349_0024BurstDirectCall
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

			public static void Invoke(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp)
			{
				orthogonalUp = default(Vector3);
			}
		}

		public delegate void OrthogonalUpVector_0000034A_0024PostfixBurstDelegate(in float3 forward, in float3 referenceUp, out float3 orthogonalUp);

		internal static class OrthogonalUpVector_0000034A_0024BurstDirectCall
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

			public static void Invoke(in float3 forward, in float3 referenceUp, out float3 orthogonalUp)
			{
				orthogonalUp = default(float3);
			}
		}

		public delegate void OrthogonalLookRotation_0000034B_0024PostfixBurstDelegate(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation);

		internal static class OrthogonalLookRotation_0000034B_0024BurstDirectCall
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

			public static void Invoke(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation)
			{
				lookRotation = default(Quaternion);
			}
		}

		public delegate void OrthogonalLookRotation_0000034C_0024PostfixBurstDelegate(in float3 forward, in float3 referenceUp, out quaternion lookRotation);

		internal static class OrthogonalLookRotation_0000034C_0024BurstDirectCall
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

			public static void Invoke(in float3 forward, in float3 referenceUp, out quaternion lookRotation)
			{
				lookRotation = default(quaternion);
			}
		}

		public delegate void ProjectOnPlane_0000034D_0024PostfixBurstDelegate(in float3 vector, in float3 planeNormal, out float3 projectedVector);

		internal static class ProjectOnPlane_0000034D_0024BurstDirectCall
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

			public static void Invoke(in float3 vector, in float3 planeNormal, out float3 projectedVector)
			{
				projectedVector = default(float3);
			}
		}

		public delegate void ProjectOnPlane_0000034E_0024PostfixBurstDelegate(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector);

		internal static class ProjectOnPlane_0000034E_0024BurstDirectCall
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

			public static void Invoke(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector)
			{
				projectedVector = default(Vector3);
			}
		}

		public delegate void LookRotationWithForwardProjectedOnPlane_0000034F_0024PostfixBurstDelegate(in float3 forward, in float3 planeNormal, out quaternion lookRotation);

		internal static class LookRotationWithForwardProjectedOnPlane_0000034F_0024BurstDirectCall
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

			public static void Invoke(in float3 forward, in float3 planeNormal, out quaternion lookRotation)
			{
				lookRotation = default(quaternion);
			}
		}

		public delegate void LookRotationWithForwardProjectedOnPlane_00000350_0024PostfixBurstDelegate(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation);

		internal static class LookRotationWithForwardProjectedOnPlane_00000350_0024BurstDirectCall
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

			public static void Invoke(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation)
			{
				lookRotation = default(Quaternion);
			}
		}

		public delegate void Angle_00000351_0024PostfixBurstDelegate(in quaternion a, in quaternion b, out float angle);

		internal static class Angle_00000351_0024BurstDirectCall
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

			public static void Invoke(in quaternion a, in quaternion b, out float angle)
			{
				angle = default(float);
			}
		}

		public delegate void Angle_00000352_0024PostfixBurstDelegate(in Vector3 a, in Vector3 b, out float angle);

		internal static class Angle_00000352_0024BurstDirectCall
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

			public static void Invoke(in Vector3 a, in Vector3 b, out float angle)
			{
				angle = default(float);
			}
		}

		public delegate bool FastVectorEquals_00000353_0024PostfixBurstDelegate(in float3 a, in float3 b, float tolerance = 0.0001f);

		internal static class FastVectorEquals_00000353_0024BurstDirectCall
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

			public static bool Invoke(in float3 a, in float3 b, float tolerance = 0.0001f)
			{
				return false;
			}
		}

		public delegate bool FastVectorEquals_00000354_0024PostfixBurstDelegate(in Vector3 a, in Vector3 b, float tolerance = 0.0001f);

		internal static class FastVectorEquals_00000354_0024BurstDirectCall
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

			public static bool Invoke(in Vector3 a, in Vector3 b, float tolerance = 0.0001f)
			{
				return false;
			}
		}

		public delegate void FastSafeDivide_00000355_0024PostfixBurstDelegate(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06f);

		internal static class FastSafeDivide_00000355_0024BurstDirectCall
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

			public static void Invoke(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06f)
			{
				result = default(Vector3);
			}
		}

		public delegate void FastSafeDivide_00000356_0024PostfixBurstDelegate(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06f);

		internal static class FastSafeDivide_00000356_0024BurstDirectCall
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

			public static void Invoke(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06f)
			{
				result = default(float3);
			}
		}

		public delegate void Scale_00000357_0024PostfixBurstDelegate(in float3 a, in float3 b, out float3 result);

		internal static class Scale_00000357_0024BurstDirectCall
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

			public static void Invoke(in float3 a, in float3 b, out float3 result)
			{
				result = default(float3);
			}
		}

		public delegate void Scale_00000358_0024PostfixBurstDelegate(in Vector3 a, in Vector3 b, out Vector3 result);

		internal static class Scale_00000358_0024BurstDirectCall
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

			public static void Invoke(in Vector3 a, in Vector3 b, out Vector3 result)
			{
				result = default(Vector3);
			}
		}

		public delegate void Orthogonal_0000035A_0024PostfixBurstDelegate(in float3 input, out float3 result);

		internal static class Orthogonal_0000035A_0024BurstDirectCall
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

			public static void Invoke(in float3 input, out float3 result)
			{
				result = default(float3);
			}
		}

		[BurstCompile]
		public static void OrthogonalUpVector(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp)
		{
			orthogonalUp = default(Vector3);
		}

		[BurstCompile]
		public static void OrthogonalUpVector(in float3 forward, in float3 referenceUp, out float3 orthogonalUp)
		{
			orthogonalUp = default(float3);
		}

		[BurstCompile]
		public static void OrthogonalLookRotation(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation)
		{
			lookRotation = default(Quaternion);
		}

		[BurstCompile]
		public static void OrthogonalLookRotation(in float3 forward, in float3 referenceUp, out quaternion lookRotation)
		{
			lookRotation = default(quaternion);
		}

		[BurstCompile]
		public static void ProjectOnPlane(in float3 vector, in float3 planeNormal, out float3 projectedVector)
		{
			projectedVector = default(float3);
		}

		[BurstCompile]
		public static void ProjectOnPlane(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector)
		{
			projectedVector = default(Vector3);
		}

		[BurstCompile]
		public static void LookRotationWithForwardProjectedOnPlane(in float3 forward, in float3 planeNormal, out quaternion lookRotation)
		{
			lookRotation = default(quaternion);
		}

		[BurstCompile]
		public static void LookRotationWithForwardProjectedOnPlane(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation)
		{
			lookRotation = default(Quaternion);
		}

		[BurstCompile]
		public static void Angle(in quaternion a, in quaternion b, out float angle)
		{
			angle = default(float);
		}

		[BurstCompile]
		public static void Angle(in Vector3 a, in Vector3 b, out float angle)
		{
			angle = default(float);
		}

		[BurstCompile]
		public static bool FastVectorEquals(in float3 a, in float3 b, float tolerance = 0.0001f)
		{
			return false;
		}

		[BurstCompile]
		public static bool FastVectorEquals(in Vector3 a, in Vector3 b, float tolerance = 0.0001f)
		{
			return false;
		}

		[BurstCompile]
		public static void FastSafeDivide(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06f)
		{
			result = default(Vector3);
		}

		[BurstCompile]
		public static void FastSafeDivide(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06f)
		{
			result = default(float3);
		}

		[BurstCompile]
		public static void Scale(in float3 a, in float3 b, out float3 result)
		{
			result = default(float3);
		}

		[BurstCompile]
		public static void Scale(in Vector3 a, in Vector3 b, out Vector3 result)
		{
			result = default(Vector3);
		}

		public static Vector3 Orthogonal(Vector3 input)
		{
			return default(Vector3);
		}

		[BurstCompile]
		public static void Orthogonal(in float3 input, out float3 result)
		{
			result = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void OrthogonalUpVector_0024BurstManaged(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp)
		{
			orthogonalUp = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void OrthogonalUpVector_0024BurstManaged(in float3 forward, in float3 referenceUp, out float3 orthogonalUp)
		{
			orthogonalUp = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void OrthogonalLookRotation_0024BurstManaged(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation)
		{
			lookRotation = default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void OrthogonalLookRotation_0024BurstManaged(in float3 forward, in float3 referenceUp, out quaternion lookRotation)
		{
			lookRotation = default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ProjectOnPlane_0024BurstManaged(in float3 vector, in float3 planeNormal, out float3 projectedVector)
		{
			projectedVector = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ProjectOnPlane_0024BurstManaged(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector)
		{
			projectedVector = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void LookRotationWithForwardProjectedOnPlane_0024BurstManaged(in float3 forward, in float3 planeNormal, out quaternion lookRotation)
		{
			lookRotation = default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void LookRotationWithForwardProjectedOnPlane_0024BurstManaged(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation)
		{
			lookRotation = default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void Angle_0024BurstManaged(in quaternion a, in quaternion b, out float angle)
		{
			angle = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void Angle_0024BurstManaged(in Vector3 a, in Vector3 b, out float angle)
		{
			angle = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool FastVectorEquals_0024BurstManaged(in float3 a, in float3 b, float tolerance = 0.0001f)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool FastVectorEquals_0024BurstManaged(in Vector3 a, in Vector3 b, float tolerance = 0.0001f)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void FastSafeDivide_0024BurstManaged(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06f)
		{
			result = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void FastSafeDivide_0024BurstManaged(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06f)
		{
			result = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void Scale_0024BurstManaged(in float3 a, in float3 b, out float3 result)
		{
			result = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void Scale_0024BurstManaged(in Vector3 a, in Vector3 b, out Vector3 result)
		{
			result = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void Orthogonal_0024BurstManaged(in float3 input, out float3 result)
		{
			result = default(float3);
		}
	}
}
