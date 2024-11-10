using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort
{
	[Serializable]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public sealed class VignetteParameters
	{
		internal static class Defaults
		{
			public const float apertureSizeMax = 1f;

			public const float featheringEffectMax = 1f;

			public const float apertureVerticalPositionMax = 0.2f;

			public const float apertureVerticalPositionMin = -0.2f;

			public const float apertureSizeDefault = 0.7f;

			public const float featheringEffectDefault = 0.2f;

			public const float easeInTimeDefault = 0.3f;

			public const float easeOutTimeDefault = 0.3f;

			public const bool easeInTimeLockDefault = false;

			public const float easeOutDelayTimeDefault = 0f;

			public static readonly Color vignetteColorDefault;

			public static readonly Color vignetteColorBlendDefault;

			public const float apertureVerticalPositionDefault = 0f;

			public static readonly VignetteParameters defaultEffect;

			public static readonly VignetteParameters noEffect;
		}

		[SerializeField]
		[Range(0f, 1f)]
		private float m_ApertureSize;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_FeatheringEffect;

		[SerializeField]
		private float m_EaseInTime;

		[SerializeField]
		private float m_EaseOutTime;

		[SerializeField]
		private bool m_EaseInTimeLock;

		[SerializeField]
		private float m_EaseOutDelayTime;

		[SerializeField]
		private Color m_VignetteColor;

		[SerializeField]
		private Color m_VignetteColorBlend;

		[SerializeField]
		[Range(-0.2f, 0.2f)]
		private float m_ApertureVerticalPosition;

		public float apertureSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float featheringEffect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float easeInTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float easeOutTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool easeInTimeLock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float easeOutDelayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color vignetteColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color vignetteColorBlend
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float apertureVerticalPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void CopyFrom(VignetteParameters parameters)
		{
		}
	}
}
