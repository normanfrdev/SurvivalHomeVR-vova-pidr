using System;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[DefaultExecutionOrder(-29990)]
	[DisallowMultipleComponent]
	[Obsolete("XRBaseController has been deprecated in version 3.0.0. Its functionality has been distributed into different components.")]
	public abstract class XRBaseController : MonoBehaviour, IXRHapticImpulseProvider
	{
		public enum UpdateType
		{
			UpdateAndBeforeRender = 0,
			Update = 1,
			BeforeRender = 2,
			Fixed = 3
		}

		private class HapticImpulseChannel : IXRHapticImpulseChannel
		{
			private readonly XRBaseController m_Controller;

			private bool m_WarningLogged;

			public HapticImpulseChannel(XRBaseController controller)
			{
			}

			public bool SendHapticImpulse(float amplitude, float duration, float frequency)
			{
				return false;
			}
		}

		[SerializeField]
		private UpdateType m_UpdateTrackingType;

		[SerializeField]
		private bool m_EnableInputTracking;

		[SerializeField]
		private bool m_EnableInputActions;

		[SerializeField]
		private Transform m_ModelPrefab;

		[SerializeField]
		[FormerlySerializedAs("m_ModelTransform")]
		private Transform m_ModelParent;

		[SerializeField]
		private Transform m_Model;

		[SerializeField]
		private bool m_AnimateModel;

		[SerializeField]
		private string m_ModelSelectTransition;

		[SerializeField]
		private string m_ModelDeSelectTransition;

		private bool m_HideControllerModel;

		private InteractionState m_SelectInteractionState;

		private InteractionState m_ActivateInteractionState;

		private InteractionState m_UIPressInteractionState;

		private Vector2 m_UIScrollValue;

		private XRControllerState m_ControllerState;

		private bool m_CreateControllerState;

		private Animator m_ModelAnimator;

		private bool m_HasWarnedAnimatorMissing;

		private bool m_PerformSetup;

		private HapticImpulseChannel m_HapticChannel;

		private HapticImpulseSingleChannelGroup m_HapticChannelGroup;

		[Obsolete("modelTransform has been deprecated due to being renamed. Use modelParent instead. (UnityUpgradable) -> modelParent", true)]
		public Transform modelTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("anchorControlDeadzone is obsolete. Please configure deadzone on the Rotate Anchor and Translate Anchor Actions.", true)]
		public float anchorControlDeadzone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("anchorControlOffAxisDeadzone is obsolete. Please configure deadzone on the Rotate Anchor and Translate Anchor Actions.", true)]
		public float anchorControlOffAxisDeadzone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public UpdateType updateTrackingType
		{
			get
			{
				return default(UpdateType);
			}
			set
			{
			}
		}

		public bool enableInputTracking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableInputActions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform modelPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform modelParent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform model
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool animateModel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string modelSelectTransition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string modelDeSelectTransition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool hideControllerModel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InteractionState selectInteractionState => default(InteractionState);

		public InteractionState activateInteractionState => default(InteractionState);

		public InteractionState uiPressInteractionState => default(InteractionState);

		public Vector2 uiScrollValue => default(Vector2);

		public XRControllerState currentControllerState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("GetControllerState has been deprecated. Use currentControllerState instead.", true)]
		public virtual bool GetControllerState(out XRControllerState controllerState)
		{
			controllerState = null;
			return false;
		}

		[Obsolete("SetControllerState has been deprecated. Use currentControllerState instead.", true)]
		public virtual void SetControllerState(XRControllerState controllerState)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void Update()
		{
		}

		private void SetupModel()
		{
		}

		private void SetupControllerState()
		{
		}

		protected virtual GameObject GetModelPrefab()
		{
			return null;
		}

		protected virtual void UpdateController()
		{
		}

		protected virtual void OnBeforeRender()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void ApplyControllerState(XRInteractionUpdateOrder.UpdatePhase updatePhase, XRControllerState controllerState)
		{
		}

		protected virtual void UpdateTrackingInput(XRControllerState controllerState)
		{
		}

		protected virtual void UpdateInput(XRControllerState controllerState)
		{
		}

		protected virtual void UpdateControllerModelAnimation()
		{
		}

		public virtual bool SendHapticImpulse(float amplitude, float duration)
		{
			return false;
		}

		IXRHapticImpulseChannelGroup IXRHapticImpulseProvider.GetChannelGroup()
		{
			return null;
		}
	}
}
