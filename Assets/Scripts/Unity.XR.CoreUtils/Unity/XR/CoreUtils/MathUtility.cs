using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class MathUtility
	{
		internal static readonly float EpsilonScaled;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Approximately(float a, float b)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ApproximatelyZero(float a)
		{
			return false;
		}

		public static double Clamp(double input, double min, double max)
		{
			return 0.0;
		}

		public static double ShortestAngleDistance(double start, double end, double halfMax, double max)
		{
			return 0.0;
		}

		public static float ShortestAngleDistance(float start, float end, float halfMax, float max)
		{
			return 0f;
		}

		public static bool IsUndefined(this float value)
		{
			return false;
		}

		public static bool IsAxisAligned(this Vector3 v)
		{
			return false;
		}

		public static bool IsPositivePowerOfTwo(int value)
		{
			return false;
		}

		public static int FirstActiveFlagIndex(int value)
		{
			return 0;
		}
	}
}
