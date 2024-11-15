using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public static class math
	{
		public enum RotationOrder : byte
		{
			XYZ = 0,
			XZY = 1,
			YXZ = 2,
			YZX = 3,
			ZXY = 4,
			ZYX = 5,
			Default = 4
		}

		public enum ShuffleComponent : byte
		{
			LeftX = 0,
			LeftY = 1,
			LeftZ = 2,
			LeftW = 3,
			RightX = 4,
			RightY = 5,
			RightZ = 6,
			RightW = 7
		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct IntFloatUnion
		{
			[FieldOffset(0)]
			public int intValue;

			[FieldOffset(0)]
			public float floatValue;
		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct LongDoubleUnion
		{
			[FieldOffset(0)]
			public long longValue;

			[FieldOffset(0)]
			public double doubleValue;
		}

		public const double E_DBL = Math.E;

		public const double LOG2E_DBL = 1.4426950408889634;

		public const double LOG10E_DBL = 0.4342944819032518;

		public const double LN2_DBL = 0.6931471805599453;

		public const double LN10_DBL = 2.302585092994046;

		public const double PI_DBL = Math.PI;

		public const double SQRT2_DBL = 1.4142135623730951;

		public const double EPSILON_DBL = 2.220446049250313E-16;

		public const double INFINITY_DBL = double.PositiveInfinity;

		public const double NAN_DBL = double.NaN;

		public const float FLT_MIN_NORMAL = 1.1754944E-38f;

		public const double DBL_MIN_NORMAL = 2.2250738585072014E-308;

		public const float E = MathF.E;

		public const float LOG2E = 1.442695f;

		public const float LOG10E = 0.4342945f;

		public const float LN2 = 0.6931472f;

		public const float LN10 = 2.3025851f;

		public const float PI = MathF.PI;

		public const float SQRT2 = 1.4142135f;

		public const float EPSILON = 1.1920929E-07f;

		public const float INFINITY = float.PositiveInfinity;

		public const float NAN = float.NaN;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 bool2(bool x, bool y)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 bool2(bool2 xy)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 bool2(bool v)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(bool2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool shuffle(bool2 left, bool2 right, ShuffleComponent x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool select_shuffle_component(bool2 a, bool2 b, ShuffleComponent component)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x2 bool2x2(bool2 c0, bool2 c1)
		{
			return default(bool2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x2 bool2x2(bool m00, bool m01, bool m10, bool m11)
		{
			return default(bool2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x2 bool2x2(bool v)
		{
			return default(bool2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x2 transpose(bool2x2 v)
		{
			return default(bool2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool2x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(bool2x2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2)
		{
			return default(bool2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x3 bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12)
		{
			return default(bool2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x3 bool2x3(bool v)
		{
			return default(bool2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x2 transpose(bool2x3 v)
		{
			return default(bool3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool2x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(bool2x3 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3)
		{
			return default(bool2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13)
		{
			return default(bool2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x4 bool2x4(bool v)
		{
			return default(bool2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x2 transpose(bool2x4 v)
		{
			return default(bool4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool2x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(bool2x4 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 bool3(bool x, bool y, bool z)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 bool3(bool x, bool2 yz)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 bool3(bool2 xy, bool z)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 bool3(bool3 xyz)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 bool3(bool v)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(bool3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool shuffle(bool3 left, bool3 right, ShuffleComponent x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool select_shuffle_component(bool3 a, bool3 b, ShuffleComponent component)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x2 bool3x2(bool3 c0, bool3 c1)
		{
			return default(bool3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x2 bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21)
		{
			return default(bool3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x2 bool3x2(bool v)
		{
			return default(bool3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x3 transpose(bool3x2 v)
		{
			return default(bool2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool3x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(bool3x2 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2)
		{
			return default(bool3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x3 bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22)
		{
			return default(bool3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x3 bool3x3(bool v)
		{
			return default(bool3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x3 transpose(bool3x3 v)
		{
			return default(bool3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool3x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(bool3x3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x4 bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3)
		{
			return default(bool3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x4 bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23)
		{
			return default(bool3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x4 bool3x4(bool v)
		{
			return default(bool3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x3 transpose(bool3x4 v)
		{
			return default(bool4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool3x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(bool3x4 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool x, bool y, bool z, bool w)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool x, bool y, bool2 zw)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool x, bool2 yz, bool w)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool x, bool3 yzw)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool2 xy, bool z, bool w)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool2 xy, bool2 zw)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool3 xyz, bool w)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool4 xyzw)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 bool4(bool v)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(bool4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool shuffle(bool4 left, bool4 right, ShuffleComponent x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool select_shuffle_component(bool4 a, bool4 b, ShuffleComponent component)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x2 bool4x2(bool4 c0, bool4 c1)
		{
			return default(bool4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x2 bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31)
		{
			return default(bool4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x2 bool4x2(bool v)
		{
			return default(bool4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2x4 transpose(bool4x2 v)
		{
			return default(bool2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool4x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(bool4x2 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x3 bool4x3(bool4 c0, bool4 c1, bool4 c2)
		{
			return default(bool4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x3 bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32)
		{
			return default(bool4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x3 bool4x3(bool v)
		{
			return default(bool4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3x4 transpose(bool4x3 v)
		{
			return default(bool3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool4x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(bool4x3 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x4 bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3)
		{
			return default(bool4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x4 bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33)
		{
			return default(bool4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x4 bool4x4(bool v)
		{
			return default(bool4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4x4 transpose(bool4x4 v)
		{
			return default(bool4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(bool4x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(bool4x4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(double x, double y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(double2 xy)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(double v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(bool v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(bool2 v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(int v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(int2 v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(uint v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(uint2 v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(half v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(half2 v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(float v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 double2(float2 v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(double2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double shuffle(double2 left, double2 right, ShuffleComponent x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double select_shuffle_component(double2 a, double2 b, ShuffleComponent component)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(double2 c0, double2 c1)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(double m00, double m01, double m10, double m11)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(double v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(bool v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(bool2x2 v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(int v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(int2x2 v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(uint v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(uint2x2 v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(float v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 double2x2(float2x2 v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 transpose(double2x2 v)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 inverse(double2x2 m)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double determinant(double2x2 m)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double2x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(double2x2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(double2 c0, double2 c1, double2 c2)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(double m00, double m01, double m02, double m10, double m11, double m12)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(double v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(bool v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(bool2x3 v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(int v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(int2x3 v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(uint v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(uint2x3 v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(float v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 double2x3(float2x3 v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 transpose(double2x3 v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double2x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(double2x3 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(double2 c0, double2 c1, double2 c2, double2 c3)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(double v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(bool v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(bool2x4 v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(int v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(int2x4 v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(uint v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(uint2x4 v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(float v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 double2x4(float2x4 v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 transpose(double2x4 v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double2x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(double2x4 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(double x, double y, double z)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(double x, double2 yz)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(double2 xy, double z)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(double3 xyz)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(double v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(bool v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(bool3 v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(int v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(int3 v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(uint v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(uint3 v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(half v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(half3 v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(float v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 double3(float3 v)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(double3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double shuffle(double3 left, double3 right, ShuffleComponent x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double select_shuffle_component(double3 a, double3 b, ShuffleComponent component)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(double3 c0, double3 c1)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(double m00, double m01, double m10, double m11, double m20, double m21)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(double v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(bool v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(bool3x2 v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(int v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(int3x2 v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(uint v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(uint3x2 v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(float v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 double3x2(float3x2 v)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 transpose(double3x2 v)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double3x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(double3x2 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(double3 c0, double3 c1, double3 c2)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(double v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(bool v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(bool3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(int v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(int3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(uint v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(uint3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(float v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 double3x3(float3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 transpose(double3x3 v)
		{
			return default(double3x3);
		}

		public static double3x3 inverse(double3x3 m)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double determinant(double3x3 m)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double3x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(double3x3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(double v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(bool v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(bool3x4 v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(int v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(int3x4 v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(uint v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(uint3x4 v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(float v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 double3x4(float3x4 v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 transpose(double3x4 v)
		{
			return default(double4x3);
		}

		public static double3x4 fastinverse(double3x4 m)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double3x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(double3x4 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double x, double y, double z, double w)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double x, double y, double2 zw)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double x, double2 yz, double w)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double x, double3 yzw)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double2 xy, double z, double w)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double2 xy, double2 zw)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double3 xyz, double w)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double4 xyzw)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(double v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(bool v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(bool4 v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(int v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(int4 v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(uint v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(uint4 v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(half v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(half4 v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(float v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 double4(float4 v)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(double4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double shuffle(double4 left, double4 right, ShuffleComponent x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double select_shuffle_component(double4 a, double4 b, ShuffleComponent component)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(double4 c0, double4 c1)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(double v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(bool v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(bool4x2 v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(int v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(int4x2 v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(uint v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(uint4x2 v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(float v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 double4x2(float4x2 v)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 transpose(double4x2 v)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double4x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(double4x2 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(double4 c0, double4 c1, double4 c2)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(double v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(bool v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(bool4x3 v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(int v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(int4x3 v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(uint v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(uint4x3 v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(float v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 double4x3(float4x3 v)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 transpose(double4x3 v)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double4x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(double4x3 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(double v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(bool v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(bool4x4 v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(int v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(int4x4 v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(uint v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(uint4x4 v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(float v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 double4x4(float4x4 v)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 rotate(double4x4 a, double3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 transform(double4x4 a, double3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 transpose(double4x4 v)
		{
			return default(double4x4);
		}

		public static double4x4 inverse(double4x4 m)
		{
			return default(double4x4);
		}

		public static double4x4 fastinverse(double4x4 m)
		{
			return default(double4x4);
		}

		public static double determinant(double4x4 m)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double4x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(double4x4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(float x, float y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(float2 xy)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(float v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(bool v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(bool2 v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(int v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(int2 v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(uint v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(uint2 v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(half v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(half2 v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(double v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(double2 v)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(float2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float shuffle(float2 left, float2 right, ShuffleComponent x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float select_shuffle_component(float2 a, float2 b, ShuffleComponent component)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(float2 c0, float2 c1)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(float m00, float m01, float m10, float m11)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(float v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(bool v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(bool2x2 v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(int v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(int2x2 v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(uint v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(uint2x2 v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(double v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 float2x2(double2x2 v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 transpose(float2x2 v)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 inverse(float2x2 m)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float determinant(float2x2 m)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float2x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(float2x2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(float2 c0, float2 c1, float2 c2)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(float m00, float m01, float m02, float m10, float m11, float m12)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(float v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(bool v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(bool2x3 v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(int v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(int2x3 v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(uint v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(uint2x3 v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(double v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 float2x3(double2x3 v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 transpose(float2x3 v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float2x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(float2x3 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(float v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(bool v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(bool2x4 v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(int v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(int2x4 v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(uint v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(uint2x4 v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(double v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 float2x4(double2x4 v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 transpose(float2x4 v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float2x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(float2x4 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(float x, float y, float z)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(float x, float2 yz)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(float2 xy, float z)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(float3 xyz)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(float v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(bool v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(bool3 v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(int v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(int3 v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(uint v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(uint3 v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(half v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(half3 v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(double v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(double3 v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(float3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float shuffle(float3 left, float3 right, ShuffleComponent x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float select_shuffle_component(float3 a, float3 b, ShuffleComponent component)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(float3 c0, float3 c1)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(float m00, float m01, float m10, float m11, float m20, float m21)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(float v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(bool v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(bool3x2 v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(int v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(int3x2 v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(uint v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(uint3x2 v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(double v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 float3x2(double3x2 v)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 transpose(float3x2 v)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float3x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(float3x2 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(float3 c0, float3 c1, float3 c2)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(float v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(bool v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(bool3x3 v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(int v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(int3x3 v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(uint v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(uint3x3 v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(double v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(double3x3 v)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 transpose(float3x3 v)
		{
			return default(float3x3);
		}

		public static float3x3 inverse(float3x3 m)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float determinant(float3x3 m)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float3x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(float3x3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(float v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(bool v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(bool3x4 v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(int v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(int3x4 v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(uint v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(uint3x4 v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(double v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 float3x4(double3x4 v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 transpose(float3x4 v)
		{
			return default(float4x3);
		}

		public static float3x4 fastinverse(float3x4 m)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float3x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(float3x4 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float x, float y, float z, float w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float x, float y, float2 zw)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float x, float2 yz, float w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float x, float3 yzw)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float2 xy, float z, float w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float2 xy, float2 zw)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float3 xyz, float w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float4 xyzw)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(bool v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(bool4 v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(int v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(int4 v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(uint v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(uint4 v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(half v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(half4 v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(double v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(double4 v)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(float4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float shuffle(float4 left, float4 right, ShuffleComponent x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float select_shuffle_component(float4 a, float4 b, ShuffleComponent component)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(float4 c0, float4 c1)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(float v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(bool v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(bool4x2 v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(int v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(int4x2 v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(uint v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(uint4x2 v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(double v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 float4x2(double4x2 v)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 transpose(float4x2 v)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(float4x2 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(float4 c0, float4 c1, float4 c2)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(float v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(bool v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(bool4x3 v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(int v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(int4x3 v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(uint v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(uint4x3 v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(double v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 float4x3(double4x3 v)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 transpose(float4x3 v)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(float4x3 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(float v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(bool v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(bool4x4 v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(int v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(int4x4 v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(uint v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(uint4x4 v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(double v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(double4x4 v)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 rotate(float4x4 a, float3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 transform(float4x4 a, float3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 transpose(float4x4 v)
		{
			return default(float4x4);
		}

		public static float4x4 inverse(float4x4 m)
		{
			return default(float4x4);
		}

		public static float4x4 fastinverse(float4x4 m)
		{
			return default(float4x4);
		}

		public static float determinant(float4x4 m)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(float4x4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half half(half x)
		{
			return default(half);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half half(float v)
		{
			return default(half);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half half(double v)
		{
			return default(half);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(half v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 half2(half x, half y)
		{
			return default(half2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 half2(half2 xy)
		{
			return default(half2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 half2(half v)
		{
			return default(half2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 half2(float v)
		{
			return default(half2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 half2(float2 v)
		{
			return default(half2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 half2(double v)
		{
			return default(half2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 half2(double2 v)
		{
			return default(half2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(half2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(half2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(half x, half y, half z)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(half x, half2 yz)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(half2 xy, half z)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(half3 xyz)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(half v)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(float v)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(float3 v)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(double v)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 half3(double3 v)
		{
			return default(half3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(half3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(half3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half x, half y, half z, half w)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half x, half y, half2 zw)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half x, half2 yz, half w)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half x, half3 yzw)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half2 xy, half z, half w)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half2 xy, half2 zw)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half3 xyz, half w)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half4 xyzw)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(half v)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(float v)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(float4 v)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(double v)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 half4(double4 v)
		{
			return default(half4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(half4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(half4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(int x, int y)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(int2 xy)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(int v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(bool v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(bool2 v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(uint v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(uint2 v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(float v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(float2 v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(double v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(double2 v)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(int2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int shuffle(int2 left, int2 right, ShuffleComponent x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int select_shuffle_component(int2 a, int2 b, ShuffleComponent component)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(int2 c0, int2 c1)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(int m00, int m01, int m10, int m11)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(int v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(bool v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(bool2x2 v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(uint v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(uint2x2 v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(float v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(float2x2 v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(double v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 int2x2(double2x2 v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 transpose(int2x2 v)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int determinant(int2x2 m)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int2x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(int2x2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(int2 c0, int2 c1, int2 c2)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(int m00, int m01, int m02, int m10, int m11, int m12)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(int v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(bool v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(bool2x3 v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(uint v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(uint2x3 v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(float v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(float2x3 v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(double v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 int2x3(double2x3 v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 transpose(int2x3 v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int2x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(int2x3 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(int v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(bool v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(bool2x4 v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(uint v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(uint2x4 v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(float v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(float2x4 v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(double v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 int2x4(double2x4 v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 transpose(int2x4 v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int2x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(int2x4 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(int x, int y, int z)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(int x, int2 yz)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(int2 xy, int z)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(int3 xyz)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(int v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(bool v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(bool3 v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(uint v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(uint3 v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(float v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(float3 v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(double v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 int3(double3 v)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(int3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int shuffle(int3 left, int3 right, ShuffleComponent x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int select_shuffle_component(int3 a, int3 b, ShuffleComponent component)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(int3 c0, int3 c1)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(int m00, int m01, int m10, int m11, int m20, int m21)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(int v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(bool v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(bool3x2 v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(uint v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(uint3x2 v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(float v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(float3x2 v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(double v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 int3x2(double3x2 v)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 transpose(int3x2 v)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int3x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(int3x2 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(int3 c0, int3 c1, int3 c2)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(int v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(bool v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(bool3x3 v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(uint v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(uint3x3 v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(float v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(float3x3 v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(double v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 int3x3(double3x3 v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 transpose(int3x3 v)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int determinant(int3x3 m)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int3x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(int3x3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(int3 c0, int3 c1, int3 c2, int3 c3)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(int v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(bool v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(bool3x4 v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(uint v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(uint3x4 v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(float v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(float3x4 v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(double v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 int3x4(double3x4 v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 transpose(int3x4 v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int3x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(int3x4 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int x, int y, int z, int w)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int x, int y, int2 zw)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int x, int2 yz, int w)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int x, int3 yzw)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int2 xy, int z, int w)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int2 xy, int2 zw)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int3 xyz, int w)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int4 xyzw)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(int v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(bool v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(bool4 v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(uint v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(uint4 v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(float v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(float4 v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(double v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 int4(double4 v)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(int4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int shuffle(int4 left, int4 right, ShuffleComponent x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int select_shuffle_component(int4 a, int4 b, ShuffleComponent component)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(int4 c0, int4 c1)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(int v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(bool v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(bool4x2 v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(uint v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(uint4x2 v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(float v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(float4x2 v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(double v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 int4x2(double4x2 v)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 transpose(int4x2 v)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int4x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(int4x2 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(int4 c0, int4 c1, int4 c2)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(int v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(bool v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(bool4x3 v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(uint v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(uint4x3 v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(float v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(float4x3 v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(double v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 int4x3(double4x3 v)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 transpose(int4x3 v)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int4x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(int4x3 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(int v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(bool v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(bool4x4 v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(uint v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(uint4x4 v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(float v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(float4x4 v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(double v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 int4x4(double4x4 v)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 transpose(int4x4 v)
		{
			return default(int4x4);
		}

		public static int determinant(int4x4 m)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int4x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(int4x4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int asint(uint x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 asint(uint2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 asint(uint3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 asint(uint4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int asint(float x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 asint(float2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 asint(float3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 asint(float4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint asuint(int x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 asuint(int2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 asuint(int3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 asuint(int4 x)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint asuint(float x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 asuint(float2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 asuint(float3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 asuint(float4 x)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long aslong(ulong x)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long aslong(double x)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong asulong(long x)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong asulong(double x)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float asfloat(int x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 asfloat(int2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 asfloat(int3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 asfloat(int4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float asfloat(uint x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 asfloat(uint2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 asfloat(uint3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 asfloat(uint4 x)
		{
			return default(float4);
		}

		public static int bitmask(bool4 value)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double asdouble(long x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double asdouble(ulong x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool isfinite(float x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 isfinite(float2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 isfinite(float3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 isfinite(float4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool isfinite(double x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 isfinite(double2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 isfinite(double3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 isfinite(double4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool isinf(float x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 isinf(float2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 isinf(float3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 isinf(float4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool isinf(double x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 isinf(double2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 isinf(double3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 isinf(double4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool isnan(float x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 isnan(float2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 isnan(float3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 isnan(float4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool isnan(double x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 isnan(double2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 isnan(double3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 isnan(double4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ispow2(int x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 ispow2(int2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 ispow2(int3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 ispow2(int4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ispow2(uint x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 ispow2(uint2 x)
		{
			return default(bool2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 ispow2(uint3 x)
		{
			return default(bool3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 ispow2(uint4 x)
		{
			return default(bool4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int min(int x, int y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 min(int2 x, int2 y)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 min(int3 x, int3 y)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 min(int4 x, int4 y)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint min(uint x, uint y)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 min(uint2 x, uint2 y)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 min(uint3 x, uint3 y)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 min(uint4 x, uint4 y)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long min(long x, long y)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong min(ulong x, ulong y)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float min(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 min(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 min(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 min(float4 x, float4 y)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double min(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 min(double2 x, double2 y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 min(double3 x, double3 y)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 min(double4 x, double4 y)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int max(int x, int y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 max(int2 x, int2 y)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 max(int3 x, int3 y)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 max(int4 x, int4 y)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint max(uint x, uint y)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 max(uint2 x, uint2 y)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 max(uint3 x, uint3 y)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 max(uint4 x, uint4 y)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long max(long x, long y)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong max(ulong x, ulong y)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float max(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 max(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 max(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 max(float4 x, float4 y)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double max(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 max(double2 x, double2 y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 max(double3 x, double3 y)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 max(double4 x, double4 y)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lerp(float x, float y, float s)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 lerp(float2 x, float2 y, float s)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 lerp(float3 x, float3 y, float s)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 lerp(float4 x, float4 y, float s)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 lerp(float2 x, float2 y, float2 s)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 lerp(float3 x, float3 y, float3 s)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 lerp(float4 x, float4 y, float4 s)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double lerp(double x, double y, double s)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 lerp(double2 x, double2 y, double s)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 lerp(double3 x, double3 y, double s)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 lerp(double4 x, double4 y, double s)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 lerp(double2 x, double2 y, double2 s)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 lerp(double3 x, double3 y, double3 s)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 lerp(double4 x, double4 y, double4 s)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float unlerp(float a, float b, float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 unlerp(float2 a, float2 b, float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 unlerp(float3 a, float3 b, float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 unlerp(float4 a, float4 b, float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double unlerp(double a, double b, double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 unlerp(double2 a, double2 b, double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 unlerp(double3 a, double3 b, double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 unlerp(double4 a, double4 b, double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float remap(float a, float b, float c, float d, float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 remap(float2 a, float2 b, float2 c, float2 d, float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 remap(float3 a, float3 b, float3 c, float3 d, float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 remap(float4 a, float4 b, float4 c, float4 d, float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double remap(double a, double b, double c, double d, double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 remap(double2 a, double2 b, double2 c, double2 d, double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 remap(double3 a, double3 b, double3 c, double3 d, double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 remap(double4 a, double4 b, double4 c, double4 d, double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int mad(int a, int b, int c)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 mad(int2 a, int2 b, int2 c)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 mad(int3 a, int3 b, int3 c)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 mad(int4 a, int4 b, int4 c)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint mad(uint a, uint b, uint c)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 mad(uint2 a, uint2 b, uint2 c)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 mad(uint3 a, uint3 b, uint3 c)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 mad(uint4 a, uint4 b, uint4 c)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long mad(long a, long b, long c)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong mad(ulong a, ulong b, ulong c)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float mad(float a, float b, float c)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 mad(float2 a, float2 b, float2 c)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mad(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mad(float4 a, float4 b, float4 c)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double mad(double a, double b, double c)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 mad(double2 a, double2 b, double2 c)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mad(double3 a, double3 b, double3 c)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 mad(double4 a, double4 b, double4 c)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int clamp(int x, int a, int b)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 clamp(int2 x, int2 a, int2 b)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 clamp(int3 x, int3 a, int3 b)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 clamp(int4 x, int4 a, int4 b)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint clamp(uint x, uint a, uint b)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 clamp(uint2 x, uint2 a, uint2 b)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 clamp(uint3 x, uint3 a, uint3 b)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 clamp(uint4 x, uint4 a, uint4 b)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long clamp(long x, long a, long b)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong clamp(ulong x, ulong a, ulong b)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float clamp(float x, float a, float b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 clamp(float2 x, float2 a, float2 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 clamp(float3 x, float3 a, float3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 clamp(float4 x, float4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double clamp(double x, double a, double b)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 clamp(double2 x, double2 a, double2 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 clamp(double3 x, double3 a, double3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 clamp(double4 x, double4 a, double4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float saturate(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 saturate(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 saturate(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 saturate(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double saturate(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 saturate(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 saturate(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 saturate(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int abs(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 abs(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 abs(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 abs(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long abs(long x)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float abs(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 abs(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 abs(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 abs(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double abs(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 abs(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 abs(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 abs(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int dot(int x, int y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int dot(int2 x, int2 y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int dot(int3 x, int3 y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int dot(int4 x, int4 y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint dot(uint x, uint y)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint dot(uint2 x, uint2 y)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint dot(uint3 x, uint3 y)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint dot(uint4 x, uint4 y)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float2 x, float2 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float3 x, float3 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float4 x, float4 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double dot(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double dot(double2 x, double2 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double dot(double3 x, double3 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double dot(double4 x, double4 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float tan(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 tan(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 tan(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 tan(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double tan(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 tan(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 tan(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 tan(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float tanh(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 tanh(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 tanh(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 tanh(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double tanh(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 tanh(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 tanh(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 tanh(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float atan(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 atan(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 atan(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 atan(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double atan(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 atan(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 atan(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 atan(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float atan2(float y, float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 atan2(float2 y, float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 atan2(float3 y, float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 atan2(float4 y, float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double atan2(double y, double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 atan2(double2 y, double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 atan2(double3 y, double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 atan2(double4 y, double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cos(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 cos(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 cos(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 cos(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cos(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 cos(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 cos(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 cos(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cosh(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 cosh(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 cosh(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 cosh(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cosh(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 cosh(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 cosh(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 cosh(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float acos(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 acos(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 acos(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 acos(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double acos(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 acos(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 acos(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 acos(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float sin(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 sin(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 sin(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 sin(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double sin(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 sin(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 sin(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 sin(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float sinh(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 sinh(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 sinh(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 sinh(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double sinh(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 sinh(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 sinh(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 sinh(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float asin(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 asin(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 asin(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 asin(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double asin(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 asin(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 asin(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 asin(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float floor(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 floor(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 floor(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 floor(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double floor(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 floor(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 floor(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 floor(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ceil(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 ceil(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 ceil(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 ceil(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ceil(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 ceil(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 ceil(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 ceil(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float round(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 round(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 round(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 round(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double round(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 round(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 round(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 round(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float trunc(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 trunc(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 trunc(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 trunc(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double trunc(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 trunc(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 trunc(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 trunc(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float frac(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 frac(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 frac(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 frac(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double frac(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 frac(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 frac(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 frac(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float rcp(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 rcp(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 rcp(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 rcp(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double rcp(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 rcp(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 rcp(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 rcp(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float sign(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 sign(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 sign(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 sign(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double sign(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 sign(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 sign(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 sign(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float pow(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 pow(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 pow(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 pow(float4 x, float4 y)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double pow(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 pow(double2 x, double2 y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 pow(double3 x, double3 y)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 pow(double4 x, double4 y)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float exp(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 exp(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 exp(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 exp(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double exp(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 exp(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 exp(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 exp(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float exp2(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 exp2(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 exp2(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 exp2(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double exp2(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 exp2(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 exp2(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 exp2(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float exp10(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 exp10(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 exp10(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 exp10(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double exp10(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 exp10(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 exp10(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 exp10(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float log(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 log(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 log(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 log(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double log(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 log(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 log(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 log(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float log2(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 log2(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 log2(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 log2(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double log2(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 log2(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 log2(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 log2(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float log10(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 log10(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 log10(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 log10(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double log10(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 log10(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 log10(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 log10(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float fmod(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 fmod(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 fmod(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 fmod(float4 x, float4 y)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double fmod(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 fmod(double2 x, double2 y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 fmod(double3 x, double3 y)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 fmod(double4 x, double4 y)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float modf(float x, out float i)
		{
			i = default(float);
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 modf(float2 x, out float2 i)
		{
			i = default(float2);
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 modf(float3 x, out float3 i)
		{
			i = default(float3);
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 modf(float4 x, out float4 i)
		{
			i = default(float4);
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double modf(double x, out double i)
		{
			i = default(double);
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 modf(double2 x, out double2 i)
		{
			i = default(double2);
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 modf(double3 x, out double3 i)
		{
			i = default(double3);
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 modf(double4 x, out double4 i)
		{
			i = default(double4);
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float sqrt(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 sqrt(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 sqrt(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 sqrt(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double sqrt(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 sqrt(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 sqrt(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 sqrt(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float rsqrt(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 rsqrt(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 rsqrt(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 rsqrt(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double rsqrt(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 rsqrt(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 rsqrt(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 rsqrt(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 normalize(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 normalize(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 normalize(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 normalize(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 normalize(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 normalize(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 normalizesafe(float2 x, float2 defaultvalue = default(float2))
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 normalizesafe(float3 x, float3 defaultvalue = default(float3))
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 normalizesafe(float4 x, float4 defaultvalue = default(float4))
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 normalizesafe(double2 x, double2 defaultvalue = default(double2))
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 normalizesafe(double3 x, double3 defaultvalue = default(double3))
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 normalizesafe(double4 x, double4 defaultvalue = default(double4))
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(float2 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(float3 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(float4 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double length(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double length(double2 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double length(double3 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double length(double4 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lengthsq(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lengthsq(float2 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lengthsq(float3 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lengthsq(float4 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double lengthsq(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double lengthsq(double2 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double lengthsq(double3 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double lengthsq(double4 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distance(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distance(float2 x, float2 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distance(float3 x, float3 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distance(float4 x, float4 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distance(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distance(double2 x, double2 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distance(double3 x, double3 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distance(double4 x, double4 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distancesq(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distancesq(float2 x, float2 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distancesq(float3 x, float3 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distancesq(float4 x, float4 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distancesq(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distancesq(double2 x, double2 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distancesq(double3 x, double3 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distancesq(double4 x, double4 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 cross(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 cross(double3 x, double3 y)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float smoothstep(float a, float b, float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 smoothstep(float2 a, float2 b, float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 smoothstep(float3 a, float3 b, float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 smoothstep(float4 a, float4 b, float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double smoothstep(double a, double b, double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 smoothstep(double2 a, double2 b, double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 smoothstep(double3 a, double3 b, double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 smoothstep(double4 a, double4 b, double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(bool2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(bool3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(bool4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(int2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(int3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(int4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(uint2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(uint3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(uint4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(float2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(float3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(float4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(double2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(double3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(double4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(bool2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(bool3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(bool4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(int2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(int3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(int4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(uint2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(uint3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(uint4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(float2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(float3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(float4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(double2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(double3 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool all(double4 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int select(int a, int b, bool c)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 select(int2 a, int2 b, bool c)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 select(int3 a, int3 b, bool c)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 select(int4 a, int4 b, bool c)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 select(int2 a, int2 b, bool2 c)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 select(int3 a, int3 b, bool3 c)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 select(int4 a, int4 b, bool4 c)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint select(uint a, uint b, bool c)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 select(uint2 a, uint2 b, bool c)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 select(uint3 a, uint3 b, bool c)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 select(uint4 a, uint4 b, bool c)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 select(uint2 a, uint2 b, bool2 c)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 select(uint3 a, uint3 b, bool3 c)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 select(uint4 a, uint4 b, bool4 c)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long select(long a, long b, bool c)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong select(ulong a, ulong b, bool c)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float select(float a, float b, bool c)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 select(float2 a, float2 b, bool c)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 select(float3 a, float3 b, bool c)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 select(float4 a, float4 b, bool c)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 select(float2 a, float2 b, bool2 c)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 select(float3 a, float3 b, bool3 c)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 select(float4 a, float4 b, bool4 c)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double select(double a, double b, bool c)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 select(double2 a, double2 b, bool c)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 select(double3 a, double3 b, bool c)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 select(double4 a, double4 b, bool c)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 select(double2 a, double2 b, bool2 c)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 select(double3 a, double3 b, bool3 c)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 select(double4 a, double4 b, bool4 c)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float step(float y, float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 step(float2 y, float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 step(float3 y, float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 step(float4 y, float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double step(double y, double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 step(double2 y, double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 step(double3 y, double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 step(double4 y, double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 reflect(float2 i, float2 n)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 reflect(float3 i, float3 n)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 reflect(float4 i, float4 n)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 reflect(double2 i, double2 n)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 reflect(double3 i, double3 n)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 reflect(double4 i, double4 n)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 refract(float2 i, float2 n, float eta)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 refract(float3 i, float3 n, float eta)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 refract(float4 i, float4 n, float eta)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 refract(double2 i, double2 n, double eta)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 refract(double3 i, double3 n, double eta)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 refract(double4 i, double4 n, double eta)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 project(float2 a, float2 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 project(float3 a, float3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 project(float4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 projectsafe(float2 a, float2 b, float2 defaultValue = default(float2))
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 projectsafe(float3 a, float3 b, float3 defaultValue = default(float3))
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 projectsafe(float4 a, float4 b, float4 defaultValue = default(float4))
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 project(double2 a, double2 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 project(double3 a, double3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 project(double4 a, double4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 projectsafe(double2 a, double2 b, double2 defaultValue = default(double2))
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 projectsafe(double3 a, double3 b, double3 defaultValue = default(double3))
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 projectsafe(double4 a, double4 b, double4 defaultValue = default(double4))
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 faceforward(float2 n, float2 i, float2 ng)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 faceforward(float3 n, float3 i, float3 ng)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 faceforward(float4 n, float4 i, float4 ng)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 faceforward(double2 n, double2 i, double2 ng)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 faceforward(double3 n, double3 i, double3 ng)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 faceforward(double4 n, double4 i, double4 ng)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(float x, out float s, out float c)
		{
			s = default(float);
			c = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(float2 x, out float2 s, out float2 c)
		{
			s = default(float2);
			c = default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(float3 x, out float3 s, out float3 c)
		{
			s = default(float3);
			c = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(float4 x, out float4 s, out float4 c)
		{
			s = default(float4);
			c = default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(double x, out double s, out double c)
		{
			s = default(double);
			c = default(double);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(double2 x, out double2 s, out double2 c)
		{
			s = default(double2);
			c = default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(double3 x, out double3 s, out double3 c)
		{
			s = default(double3);
			c = default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(double4 x, out double4 s, out double4 c)
		{
			s = default(double4);
			c = default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int countbits(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 countbits(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 countbits(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 countbits(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int countbits(uint x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 countbits(uint2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 countbits(uint3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 countbits(uint4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int countbits(ulong x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int countbits(long x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int lzcnt(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 lzcnt(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 lzcnt(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 lzcnt(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int lzcnt(uint x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 lzcnt(uint2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 lzcnt(uint3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 lzcnt(uint4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int lzcnt(long x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int lzcnt(ulong x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int tzcnt(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 tzcnt(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 tzcnt(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 tzcnt(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int tzcnt(uint x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 tzcnt(uint2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 tzcnt(uint3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 tzcnt(uint4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int tzcnt(long x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int tzcnt(ulong x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int reversebits(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 reversebits(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 reversebits(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 reversebits(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint reversebits(uint x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 reversebits(uint2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 reversebits(uint3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 reversebits(uint4 x)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long reversebits(long x)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong reversebits(ulong x)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int rol(int x, int n)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 rol(int2 x, int n)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 rol(int3 x, int n)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 rol(int4 x, int n)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint rol(uint x, int n)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 rol(uint2 x, int n)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 rol(uint3 x, int n)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 rol(uint4 x, int n)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long rol(long x, int n)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong rol(ulong x, int n)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ror(int x, int n)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 ror(int2 x, int n)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 ror(int3 x, int n)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 ror(int4 x, int n)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ror(uint x, int n)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 ror(uint2 x, int n)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 ror(uint3 x, int n)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 ror(uint4 x, int n)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ror(long x, int n)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ror(ulong x, int n)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ceilpow2(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 ceilpow2(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 ceilpow2(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 ceilpow2(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ceilpow2(uint x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 ceilpow2(uint2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 ceilpow2(uint3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 ceilpow2(uint4 x)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ceilpow2(long x)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ceilpow2(ulong x)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ceillog2(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 ceillog2(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 ceillog2(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 ceillog2(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ceillog2(uint x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 ceillog2(uint2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 ceillog2(uint3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 ceillog2(uint4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int floorlog2(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 floorlog2(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 floorlog2(int3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 floorlog2(int4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int floorlog2(uint x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 floorlog2(uint2 x)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 floorlog2(uint3 x)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 floorlog2(uint4 x)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float radians(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 radians(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 radians(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 radians(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double radians(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 radians(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 radians(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 radians(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float degrees(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 degrees(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 degrees(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 degrees(float4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double degrees(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 degrees(double2 x)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 degrees(double3 x)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 degrees(double4 x)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int cmin(int2 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int cmin(int3 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int cmin(int4 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint cmin(uint2 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint cmin(uint3 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint cmin(uint4 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cmin(float2 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cmin(float3 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cmin(float4 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cmin(double2 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cmin(double3 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cmin(double4 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int cmax(int2 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int cmax(int3 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int cmax(int4 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint cmax(uint2 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint cmax(uint3 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint cmax(uint4 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cmax(float2 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cmax(float3 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cmax(float4 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cmax(double2 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cmax(double3 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double cmax(double4 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int csum(int2 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int csum(int3 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int csum(int4 x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint2 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint3 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint4 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float csum(float2 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float csum(float3 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float csum(float4 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double csum(double2 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double csum(double3 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double csum(double4 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int compress(int* output, int index, int4 val, bool4 mask)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int compress(uint* output, int index, uint4 val, bool4 mask)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int compress(float* output, int index, float4 val, bool4 mask)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float f16tof32(uint x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 f16tof32(uint2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 f16tof32(uint3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 f16tof32(uint4 x)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint f32tof16(float x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 f32tof16(float2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 f32tof16(float3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 f32tof16(float4 x)
		{
			return default(uint4);
		}

		public unsafe static uint hash(void* pBuffer, int numBytes, uint seed = 0u)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 up()
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 down()
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 forward()
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 back()
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 left()
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 right()
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float4 unpacklo(float4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double4 unpacklo(double4 a, double4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float4 unpackhi(float4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double4 unpackhi(double4 a, double4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float4 movelh(float4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double4 movelh(double4 a, double4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float4 movehl(float4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double4 movehl(double4 a, double4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint fold_to_uint(double x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint2 fold_to_uint(double2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint3 fold_to_uint(double3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint4 fold_to_uint(double4 x)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(float4x4 f4x4)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(quaternion rotation)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(float3x3 rotation, float3 translation)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(quaternion rotation, float3 translation)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(RigidTransform transform)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 orthonormalize(float3x3 i)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float mul(float a, float b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float mul(float2 a, float2 b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 mul(float2 a, float2x2 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mul(float2 a, float2x3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float2 a, float2x4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float mul(float3 a, float3 b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 mul(float3 a, float3x2 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mul(float3 a, float3x3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float3 a, float3x4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float mul(float4 a, float4 b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 mul(float4 a, float4x2 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mul(float4 a, float4x3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float4 a, float4x4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 mul(float2x2 a, float2 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 mul(float2x2 a, float2x2 b)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 mul(float2x2 a, float2x3 b)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 mul(float2x2 a, float2x4 b)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 mul(float2x3 a, float3 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 mul(float2x3 a, float3x2 b)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 mul(float2x3 a, float3x3 b)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 mul(float2x3 a, float3x4 b)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 mul(float2x4 a, float4 b)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x2 mul(float2x4 a, float4x2 b)
		{
			return default(float2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x3 mul(float2x4 a, float4x3 b)
		{
			return default(float2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2x4 mul(float2x4 a, float4x4 b)
		{
			return default(float2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mul(float3x2 a, float2 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 mul(float3x2 a, float2x2 b)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 mul(float3x2 a, float2x3 b)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 mul(float3x2 a, float2x4 b)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mul(float3x3 a, float3 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 mul(float3x3 a, float3x2 b)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 mul(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 mul(float3x3 a, float3x4 b)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mul(float3x4 a, float4 b)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x2 mul(float3x4 a, float4x2 b)
		{
			return default(float3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 mul(float3x4 a, float4x3 b)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x4 mul(float3x4 a, float4x4 b)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float4x2 a, float2 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 mul(float4x2 a, float2x2 b)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 mul(float4x2 a, float2x3 b)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 mul(float4x2 a, float2x4 b)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float4x3 a, float3 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 mul(float4x3 a, float3x2 b)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 mul(float4x3 a, float3x3 b)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 mul(float4x3 a, float3x4 b)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float4x4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x2 mul(float4x4 a, float4x2 b)
		{
			return default(float4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x3 mul(float4x4 a, float4x3 b)
		{
			return default(float4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 mul(float4x4 a, float4x4 b)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double mul(double a, double b)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double mul(double2 a, double2 b)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 mul(double2 a, double2x2 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul(double2 a, double2x3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 mul(double2 a, double2x4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double mul(double3 a, double3 b)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 mul(double3 a, double3x2 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul(double3 a, double3x3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 mul(double3 a, double3x4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double mul(double4 a, double4 b)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 mul(double4 a, double4x2 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul(double4 a, double4x3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 mul(double4 a, double4x4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 mul(double2x2 a, double2 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 mul(double2x2 a, double2x2 b)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 mul(double2x2 a, double2x3 b)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 mul(double2x2 a, double2x4 b)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 mul(double2x3 a, double3 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 mul(double2x3 a, double3x2 b)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 mul(double2x3 a, double3x3 b)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 mul(double2x3 a, double3x4 b)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 mul(double2x4 a, double4 b)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x2 mul(double2x4 a, double4x2 b)
		{
			return default(double2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x3 mul(double2x4 a, double4x3 b)
		{
			return default(double2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2x4 mul(double2x4 a, double4x4 b)
		{
			return default(double2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul(double3x2 a, double2 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 mul(double3x2 a, double2x2 b)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 mul(double3x2 a, double2x3 b)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 mul(double3x2 a, double2x4 b)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul(double3x3 a, double3 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 mul(double3x3 a, double3x2 b)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 mul(double3x3 a, double3x3 b)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 mul(double3x3 a, double3x4 b)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul(double3x4 a, double4 b)
		{
			return default(double3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x2 mul(double3x4 a, double4x2 b)
		{
			return default(double3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x3 mul(double3x4 a, double4x3 b)
		{
			return default(double3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3x4 mul(double3x4 a, double4x4 b)
		{
			return default(double3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 mul(double4x2 a, double2 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 mul(double4x2 a, double2x2 b)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 mul(double4x2 a, double2x3 b)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 mul(double4x2 a, double2x4 b)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 mul(double4x3 a, double3 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 mul(double4x3 a, double3x2 b)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 mul(double4x3 a, double3x3 b)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 mul(double4x3 a, double3x4 b)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 mul(double4x4 a, double4 b)
		{
			return default(double4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x2 mul(double4x4 a, double4x2 b)
		{
			return default(double4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x3 mul(double4x4 a, double4x3 b)
		{
			return default(double4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4x4 mul(double4x4 a, double4x4 b)
		{
			return default(double4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int mul(int a, int b)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int mul(int2 a, int2 b)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 mul(int2 a, int2x2 b)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 mul(int2 a, int2x3 b)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 mul(int2 a, int2x4 b)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int mul(int3 a, int3 b)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 mul(int3 a, int3x2 b)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 mul(int3 a, int3x3 b)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 mul(int3 a, int3x4 b)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int mul(int4 a, int4 b)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 mul(int4 a, int4x2 b)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 mul(int4 a, int4x3 b)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 mul(int4 a, int4x4 b)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 mul(int2x2 a, int2 b)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 mul(int2x2 a, int2x2 b)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 mul(int2x2 a, int2x3 b)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 mul(int2x2 a, int2x4 b)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 mul(int2x3 a, int3 b)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 mul(int2x3 a, int3x2 b)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 mul(int2x3 a, int3x3 b)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 mul(int2x3 a, int3x4 b)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 mul(int2x4 a, int4 b)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x2 mul(int2x4 a, int4x2 b)
		{
			return default(int2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x3 mul(int2x4 a, int4x3 b)
		{
			return default(int2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2x4 mul(int2x4 a, int4x4 b)
		{
			return default(int2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 mul(int3x2 a, int2 b)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 mul(int3x2 a, int2x2 b)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 mul(int3x2 a, int2x3 b)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 mul(int3x2 a, int2x4 b)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 mul(int3x3 a, int3 b)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 mul(int3x3 a, int3x2 b)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 mul(int3x3 a, int3x3 b)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 mul(int3x3 a, int3x4 b)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 mul(int3x4 a, int4 b)
		{
			return default(int3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x2 mul(int3x4 a, int4x2 b)
		{
			return default(int3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x3 mul(int3x4 a, int4x3 b)
		{
			return default(int3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3x4 mul(int3x4 a, int4x4 b)
		{
			return default(int3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 mul(int4x2 a, int2 b)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 mul(int4x2 a, int2x2 b)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 mul(int4x2 a, int2x3 b)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 mul(int4x2 a, int2x4 b)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 mul(int4x3 a, int3 b)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 mul(int4x3 a, int3x2 b)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 mul(int4x3 a, int3x3 b)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 mul(int4x3 a, int3x4 b)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 mul(int4x4 a, int4 b)
		{
			return default(int4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x2 mul(int4x4 a, int4x2 b)
		{
			return default(int4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x3 mul(int4x4 a, int4x3 b)
		{
			return default(int4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4x4 mul(int4x4 a, int4x4 b)
		{
			return default(int4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint mul(uint a, uint b)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint mul(uint2 a, uint2 b)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 mul(uint2 a, uint2x2 b)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 mul(uint2 a, uint2x3 b)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 mul(uint2 a, uint2x4 b)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint mul(uint3 a, uint3 b)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 mul(uint3 a, uint3x2 b)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 mul(uint3 a, uint3x3 b)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 mul(uint3 a, uint3x4 b)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint mul(uint4 a, uint4 b)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 mul(uint4 a, uint4x2 b)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 mul(uint4 a, uint4x3 b)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 mul(uint4 a, uint4x4 b)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 mul(uint2x2 a, uint2 b)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 mul(uint2x2 a, uint2x2 b)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 mul(uint2x2 a, uint2x3 b)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 mul(uint2x2 a, uint2x4 b)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 mul(uint2x3 a, uint3 b)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 mul(uint2x3 a, uint3x2 b)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 mul(uint2x3 a, uint3x3 b)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 mul(uint2x3 a, uint3x4 b)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 mul(uint2x4 a, uint4 b)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 mul(uint2x4 a, uint4x2 b)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 mul(uint2x4 a, uint4x3 b)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 mul(uint2x4 a, uint4x4 b)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 mul(uint3x2 a, uint2 b)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 mul(uint3x2 a, uint2x2 b)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 mul(uint3x2 a, uint2x3 b)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 mul(uint3x2 a, uint2x4 b)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 mul(uint3x3 a, uint3 b)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 mul(uint3x3 a, uint3x2 b)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 mul(uint3x3 a, uint3x3 b)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 mul(uint3x3 a, uint3x4 b)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 mul(uint3x4 a, uint4 b)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 mul(uint3x4 a, uint4x2 b)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 mul(uint3x4 a, uint4x3 b)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 mul(uint3x4 a, uint4x4 b)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 mul(uint4x2 a, uint2 b)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 mul(uint4x2 a, uint2x2 b)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 mul(uint4x2 a, uint2x3 b)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 mul(uint4x2 a, uint2x4 b)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 mul(uint4x3 a, uint3 b)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 mul(uint4x3 a, uint3x2 b)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 mul(uint4x3 a, uint3x3 b)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 mul(uint4x3 a, uint3x4 b)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 mul(uint4x4 a, uint4 b)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 mul(uint4x4 a, uint4x2 b)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 mul(uint4x4 a, uint4x3 b)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 mul(uint4x4 a, uint4x4 b)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion quaternion(float x, float y, float z, float w)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion quaternion(float4 value)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion quaternion(float3x3 m)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion quaternion(float4x4 m)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion conjugate(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion inverse(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(quaternion a, quaternion b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(quaternion q)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lengthsq(quaternion q)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion normalize(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion normalizesafe(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion normalizesafe(quaternion q, quaternion defaultvalue)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion unitexp(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion exp(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion unitlog(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion log(quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion mul(quaternion a, quaternion b)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 mul(quaternion q, float3 v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 rotate(quaternion q, float3 v)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion nlerp(quaternion q1, quaternion q2, float t)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion slerp(quaternion q1, quaternion q2, float t)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(quaternion q)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(quaternion q)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 forward(quaternion q)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static RigidTransform RigidTransform(quaternion rot, float3 pos)
		{
			return default(RigidTransform);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static RigidTransform RigidTransform(float3x3 rotation, float3 translation)
		{
			return default(RigidTransform);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static RigidTransform RigidTransform(float4x4 transform)
		{
			return default(RigidTransform);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static RigidTransform inverse(RigidTransform t)
		{
			return default(RigidTransform);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static RigidTransform mul(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(RigidTransform a, float4 pos)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 rotate(RigidTransform a, float3 dir)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 transform(RigidTransform a, float3 pos)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(RigidTransform t)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(RigidTransform t)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(uint x, uint y)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(uint2 xy)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(uint v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(bool v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(bool2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(int v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(int2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(float v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(float2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(double v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(double2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(uint2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint shuffle(uint2 left, uint2 right, ShuffleComponent x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint select_shuffle_component(uint2 a, uint2 b, ShuffleComponent component)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(uint2 c0, uint2 c1)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(uint m00, uint m01, uint m10, uint m11)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(uint v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(bool v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(bool2x2 v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(int v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(int2x2 v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(float v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(float2x2 v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(double v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 uint2x2(double2x2 v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x2 transpose(uint2x2 v)
		{
			return default(uint2x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint2x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(uint2x2 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(uint2 c0, uint2 c1, uint2 c2)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(uint v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(bool v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(bool2x3 v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(int v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(int2x3 v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(float v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(float2x3 v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(double v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 uint2x3(double2x3 v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 transpose(uint2x3 v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint2x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(uint2x3 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(uint v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(bool v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(bool2x4 v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(int v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(int2x4 v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(float v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(float2x4 v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(double v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 uint2x4(double2x4 v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 transpose(uint2x4 v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint2x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 hashwide(uint2x4 v)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(uint x, uint y, uint z)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(uint x, uint2 yz)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(uint2 xy, uint z)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(uint3 xyz)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(uint v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(bool v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(bool3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(int v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(int3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(float v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(float3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(double v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(double3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(uint3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint shuffle(uint3 left, uint3 right, ShuffleComponent x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint select_shuffle_component(uint3 a, uint3 b, ShuffleComponent component)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(uint3 c0, uint3 c1)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(uint v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(bool v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(bool3x2 v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(int v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(int3x2 v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(float v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(float3x2 v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(double v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x2 uint3x2(double3x2 v)
		{
			return default(uint3x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x3 transpose(uint3x2 v)
		{
			return default(uint2x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint3x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(uint3x2 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(uint v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(bool v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(bool3x3 v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(int v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(int3x3 v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(float v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(float3x3 v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(double v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 uint3x3(double3x3 v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x3 transpose(uint3x3 v)
		{
			return default(uint3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint3x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(uint3x3 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(uint v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(bool v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(bool3x4 v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(int v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(int3x4 v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(float v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(float3x4 v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(double v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 uint3x4(double3x4 v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 transpose(uint3x4 v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint3x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 hashwide(uint3x4 v)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint x, uint y, uint z, uint w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint x, uint y, uint2 zw)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint x, uint2 yz, uint w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint x, uint3 yzw)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint2 xy, uint z, uint w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint2 xy, uint2 zw)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint3 xyz, uint w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint4 xyzw)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(bool v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(bool4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(int v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(int4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(float v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(float4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(double v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(double4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(uint4 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint shuffle(uint4 left, uint4 right, ShuffleComponent x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint select_shuffle_component(uint4 a, uint4 b, ShuffleComponent component)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(uint4 c0, uint4 c1)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(uint v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(bool v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(bool4x2 v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(int v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(int4x2 v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(float v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(float4x2 v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(double v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x2 uint4x2(double4x2 v)
		{
			return default(uint4x2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2x4 transpose(uint4x2 v)
		{
			return default(uint2x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint4x2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(uint4x2 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(uint4 c0, uint4 c1, uint4 c2)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(uint v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(bool v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(bool4x3 v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(int v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(int4x3 v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(float v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(float4x3 v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(double v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x3 uint4x3(double4x3 v)
		{
			return default(uint4x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3x4 transpose(uint4x3 v)
		{
			return default(uint3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint4x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(uint4x3 v)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(uint v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(bool v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(bool4x4 v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(int v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(int4x4 v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(float v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(float4x4 v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(double v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 uint4x4(double4x4 v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4x4 transpose(uint4x4 v)
		{
			return default(uint4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint4x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 hashwide(uint4x4 v)
		{
			return default(uint4);
		}
	}
}
