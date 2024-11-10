using System;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Obsolete("The ContinuousMoveProviderBase has been deprecated in XRI 3.0.0 and will be removed in a future version of XRI. Please use ContinuousMoveProvider instead.", false)]
	public abstract class ContinuousMoveProviderBase : LocomotionProvider
	{
		[Obsolete("GravityApplicationMode has been deprecated in XRI 3.0.0 and will be removed in a future version of XRI. Please use LocomotionMediator with a GravityProvider.", false)]
		public enum GravityApplicationMode
		{
			AttemptingMove = 0,
			Immediately = 1
		}

		[SerializeField]
		[Tooltip("The speed, in units per second, to move forward.")]
		private float m_MoveSpeed;

		[SerializeField]
		[Tooltip("Controls whether to enable strafing (sideways movement).")]
		private bool m_EnableStrafe;

		[SerializeField]
		[Tooltip("Controls whether to enable flying (unconstrained movement). This overrides the use of gravity.")]
		private bool m_EnableFly;

		[SerializeField]
		[Tooltip("Controls whether gravity affects this provider when a Character Controller is used and flying is disabled.")]
		private bool m_UseGravity;

		[SerializeField]
		[Tooltip("Controls when gravity begins to take effect.")]
		private GravityApplicationMode m_GravityApplicationMode;

		[SerializeField]
		[Tooltip("The source Transform to define the forward direction.")]
		private Transform m_ForwardSource;

		private CharacterController m_CharacterController;

		private bool m_AttemptedGetCharacterController;

		private bool m_IsMovingXROrigin;

		private Vector3 m_VerticalVelocity;

		public float moveSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableStrafe
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableFly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useGravity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GravityApplicationMode gravityApplicationMode
		{
			get
			{
				return default(GravityApplicationMode);
			}
			set
			{
			}
		}

		public Transform forwardSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void Update()
		{
		}

		protected abstract Vector2 ReadInput();

		protected virtual Vector3 ComputeDesiredMove(Vector2 input)
		{
			return default(Vector3);
		}

		protected virtual void MoveRig(Vector3 translationInWorldSpace)
		{
		}

		private void FindCharacterController()
		{
		}
	}
}
