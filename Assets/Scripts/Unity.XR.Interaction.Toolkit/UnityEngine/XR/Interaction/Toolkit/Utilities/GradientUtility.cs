using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	public class GradientUtility
	{
		private const int k_MaxGradientColorKeys = 8;

		private const int k_Precision = 100;

		private static readonly List<float> s_ColorKeyTimes;

		private static readonly HashSet<int> s_TruncatedColorKeyTimes;

		private static readonly List<float> s_AlphaKeyTimes;

		private static readonly HashSet<int> s_TruncatedAlphaKeyTimes;

		private static readonly GradientColorKey[][] s_ColorKeyArrays;

		private static readonly GradientAlphaKey[][] s_AlphaKeyArrays;

		static GradientUtility()
		{
		}

		public static Gradient Lerp(Gradient a, Gradient b, float t, bool lerpColors = true, bool lerpAlphas = true)
		{
			return null;
		}

		public static void Lerp(Gradient a, Gradient b, Gradient output, float t, bool lerpColors = true, bool lerpAlphas = true)
		{
		}

		public static void CopyGradient(Gradient source, Gradient destination)
		{
		}

		private static void AddUniqueColorKeys(GradientColorKey[] keys)
		{
		}

		private static void AddUniqueAlphaKeys(GradientAlphaKey[] keys)
		{
		}

		private static void AddColorKeyIfUnique(float keyTime)
		{
		}

		private static void AddAlphaKeyIfUnique(float keyTime)
		{
		}

		private static GradientColorKey[] PrepareColorKeys(List<float> keyTimes, Gradient a, Gradient b, float t)
		{
			return null;
		}

		private static GradientAlphaKey[] PrepareAlphaKeys(List<float> keyTimes, Gradient a, Gradient b, float t)
		{
			return null;
		}

		private static int TruncatePrecision(float value)
		{
			return 0;
		}

		private static void ReduceKeysIfNeeded(List<float> keyTimes, int maxKeys)
		{
		}

		private static GradientColorKey[] GetColorKeyArray(int size)
		{
			return null;
		}

		private static GradientAlphaKey[] GetAlphaKeyArray(int size)
		{
			return null;
		}
	}
}
