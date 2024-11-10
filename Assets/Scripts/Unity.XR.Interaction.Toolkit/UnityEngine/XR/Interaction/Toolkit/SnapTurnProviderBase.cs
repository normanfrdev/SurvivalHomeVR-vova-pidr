using System;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Obsolete("SnapTurnProviderBase has been deprecated in XRI 3.0.0 and will be removed in a future version of XRI. Please use SnapTurnProvider instead.", false)]
	public abstract class SnapTurnProviderBase : LocomotionProvider
	{
		[SerializeField]
		[Tooltip("The number of degrees clockwise to rotate when snap turning clockwise.")]
		private float m_TurnAmount;

		[SerializeField]
		[Tooltip("The amount of time that the system will wait before starting another snap turn.")]
		private float m_DebounceTime;

		[SerializeField]
		[Tooltip("Controls whether to enable left & right snap turns.")]
		private bool m_EnableTurnLeftRight;

		[SerializeField]
		[Tooltip("Controls whether to enable 180° snap turns.")]
		private bool m_EnableTurnAround;

		[SerializeField]
		[Tooltip("The time (in seconds) to delay the first turn after receiving initial input for the turn.")]
		private float m_DelayTime;

		private float m_CurrentTurnAmount;

		private float m_TimeStarted;

		private float m_DelayStartTime;

		public float turnAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float debounceTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableTurnLeftRight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableTurnAround
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float delayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected void Update()
		{
		}

		protected abstract Vector2 ReadInput();

		protected virtual float GetTurnAmount(Vector2 input)
		{
			return 0f;
		}

		protected void StartTurn(float amount)
		{
		}
	}
}
