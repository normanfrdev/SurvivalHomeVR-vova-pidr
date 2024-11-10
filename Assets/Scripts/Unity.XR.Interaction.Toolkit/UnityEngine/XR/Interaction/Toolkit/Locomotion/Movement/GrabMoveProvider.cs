using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement
{
	[AddComponentMenu("XR/Locomotion/Grab Move Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.GrabMoveProvider.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class GrabMoveProvider : ConstrainedMoveProvider
	{
		[SerializeField]
		private Transform m_ControllerTransform;

		[SerializeField]
		private bool m_EnableMoveWhileSelecting;

		[SerializeField]
		private float m_MoveFactor;

		[SerializeField]
		private XRInputButtonReader m_GrabMoveInput;

		private bool m_IsMoving;

		private Vector3 m_PreviousControllerLocalPosition;

		private readonly List<IXRSelectInteractor> m_ControllerInteractors;

		[SerializeField]
		[Obsolete("m_GrabMoveAction has been deprecated. Please configure input action using m_GrabMoveInput instead.")]
		private InputActionProperty m_GrabMoveAction;

		public Transform controllerTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enableMoveWhileSelecting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float moveFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public XRInputButtonReader grabMoveInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool canMove
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Obsolete("grabMoveAction has been deprecated. Please configure input action using grabMoveInput instead.")]
		public InputActionProperty grabMoveAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected override Vector3 ComputeDesiredMove(out bool attemptingMove)
		{
			attemptingMove = default(bool);
			return default(Vector3);
		}

		public bool IsGrabbing()
		{
			return false;
		}

		private void GatherControllerInteractors()
		{
		}

		private bool ControllerHasSelection()
		{
			return false;
		}

		private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value)
		{
		}
	}
}
