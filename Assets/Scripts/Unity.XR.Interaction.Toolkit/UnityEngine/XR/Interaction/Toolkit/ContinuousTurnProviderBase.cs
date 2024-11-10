using System;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Obsolete("The ContinuousMoveProviderBase has been deprecated in XRI 3.0.0 and will be removed in a future version of XRI. Please use ContinuousTurnProvider instead.", false)]
	public abstract class ContinuousTurnProviderBase : LocomotionProvider
	{
		[SerializeField]
		[Tooltip("The number of degrees/second clockwise to rotate when turning clockwise.")]
		private float m_TurnSpeed;

		private bool m_IsTurningXROrigin;

		public float turnSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected void Update()
		{
		}

		protected abstract Vector2 ReadInput();

		protected virtual float GetTurnAmount(Vector2 input)
		{
			return 0f;
		}

		protected void TurnRig(float turnAmount)
		{
		}
	}
}
