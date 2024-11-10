using System;
using UnityEngine;

namespace Unity.XR.PXR
{
	[Serializable]
	public class ShapesRecognizer
	{
		[Serializable]
		public class Finger
		{
			[HideInInspector]
			public HandFinger handFinger;

			public Flexion flexion;

			public Curl curl;

			public Abduction abduction;

			public FingerConfigs fingerConfigs;

			public Finger(HandFinger finger)
			{
			}
		}

		[Serializable]
		public class FingerConfigs
		{
			public RangeConfigs flexionConfigs;

			public RangeConfigs curlConfigs;

			public RangeConfigsAbduction abductionConfigs;

			public FingerConfigs(HandFinger finger)
			{
			}
		}

		public enum ShapeType
		{
			flexion = 0,
			curl = 1,
			abduction = 2
		}

		public enum Flexion
		{
			Any = 0,
			Open = 1,
			Close = 2
		}

		public enum Curl
		{
			Any = 0,
			Open = 1,
			Close = 2
		}

		public enum Abduction
		{
			Any = 0,
			Open = 1,
			Close = 2
		}

		[Serializable]
		public class RangeConfigs
		{
			public float min;

			public float max;

			public float width;

			public RangeConfigs(float n, float m, float w)
			{
			}
		}

		[Serializable]
		public class RangeConfigsAbduction
		{
			public float mid;

			public float width;

			public RangeConfigsAbduction(float m, float w)
			{
			}
		}

		public Finger thumb;

		public Finger index;

		public Finger middle;

		public Finger ring;

		public Finger pinky;

		public float holdDuration;

		public const float defaultFlexionWidth = 10f;

		public const float flexionThumbOpenMin = 155f;

		public const float flexionThumbOpenMax = 180f;

		public const float flexionThumbCloseMin = 90f;

		public const float flexionThumbCloseMax = 120f;

		public const float flexionOpenMin = 144f;

		public const float flexionOpenMax = 180f;

		public const float flexionCloseMin = 90f;

		public const float flexionCloseMax = 126f;

		public const float flexionMin = 90f;

		public const float flexionMax = 180f;

		public const float defaultCurlWidth = 20f;

		public const float curlThumbOpenMin = 90f;

		public const float curlThumbOpenMax = 180f;

		public const float curlThumbCloseMin = 45f;

		public const float curlThumbCloseMax = 90f;

		public const float curlThumbMin = 45f;

		public const float curlThumbMax = 180f;

		public const float curlOpenMin = 107f;

		public const float curlOpenMax = 180f;

		public const float curlCloseMin = 0f;

		public const float curlCloseMax = 73f;

		public const float curlMin = 0f;

		public const float curlMax = 180f;

		public const float abductionThumbMid = 13f;

		public const float abductionThumbWidth = 6f;

		public const float abductionMid = 10f;

		public const float abductionWidth = 6f;

		public const float abductionMin = 0f;

		public const float abductionMax = 90f;
	}
}
