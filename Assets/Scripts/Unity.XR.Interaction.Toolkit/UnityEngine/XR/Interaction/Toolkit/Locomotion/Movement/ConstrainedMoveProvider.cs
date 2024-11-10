using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public abstract class ConstrainedMoveProvider : LocomotionProvider
	{
		[Obsolete("GravityApplicationMode has been deprecated in XRI 3.0.0 and will be removed in a future version.")]
		public enum GravityApplicationMode
		{
			AttemptingMove = 0,
			Immediately = 1
		}

		[SerializeField]
		[Tooltip("Controls whether to enable unconstrained movement along the x-axis.")]
		private bool m_EnableFreeXMovement;

		[SerializeField]
		[Tooltip("Controls whether to enable unconstrained movement along the y-axis.")]
		private bool m_EnableFreeYMovement;

		[SerializeField]
		[Tooltip("Controls whether to enable unconstrained movement along the z-axis.")]
		private bool m_EnableFreeZMovement;

		[SerializeField]
		[Tooltip("Controls whether gravity applies to constrained axes when a Character Controller is used.")]
		private bool m_UseGravity;

		private CharacterController m_CharacterController;

		private bool m_AttemptedGetCharacterController;

		private bool m_IsMovingXROrigin;

		private Vector3 m_GravityDrivenVelocity;

		[SerializeField]
		[Tooltip("Controls when gravity begins to take effect.")]
		[Obsolete("m_GravityApplicationMode has been deprecated in XRI 3.0.0 and will be removed in a future version.")]
		private GravityApplicationMode m_GravityApplicationMode;

		public bool enableFreeXMovement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableFreeYMovement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableFreeZMovement
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

		public XROriginMovement transformation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Obsolete("gravityMode has been deprecated in XRI 3.0.0 and will be removed in a future version.")]
		public GravityApplicationMode gravityMode
		{
			get
			{
				return default(GravityApplicationMode);
			}
			set
			{
			}
		}

		protected void Update()
		{
		}

		protected abstract Vector3 ComputeDesiredMove(out bool attemptingMove);

		protected virtual void MoveRig(Vector3 translationInWorldSpace)
		{
		}

		private void FindCharacterController()
		{
		}
	}
}
