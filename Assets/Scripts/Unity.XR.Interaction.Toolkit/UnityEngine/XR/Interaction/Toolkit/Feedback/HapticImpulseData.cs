using System;

namespace UnityEngine.XR.Interaction.Toolkit.Feedback
{
	[Serializable]
	public class HapticImpulseData
	{
		[SerializeField]
		[Range(0f, 1f)]
		private float m_Amplitude;

		[SerializeField]
		private float m_Duration;

		[SerializeField]
		private float m_Frequency;

		public float amplitude
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float frequency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
