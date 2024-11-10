using System;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("/XR Controller (Action-based)", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.ActionBasedController.html")]
	[Obsolete("ActionBasedController has been deprecated in version 3.0.0. Its functionality has been distributed into different components.")]
	public class ActionBasedController : XRBaseController
	{
		[SerializeField]
		private InputActionProperty m_PositionAction;

		[SerializeField]
		private InputActionProperty m_RotationAction;

		[SerializeField]
		private InputActionProperty m_IsTrackedAction;

		[SerializeField]
		private InputActionProperty m_TrackingStateAction;

		[SerializeField]
		private InputActionProperty m_SelectAction;

		[SerializeField]
		private InputActionProperty m_SelectActionValue;

		[SerializeField]
		private InputActionProperty m_ActivateAction;

		[SerializeField]
		private InputActionProperty m_ActivateActionValue;

		[SerializeField]
		private InputActionProperty m_UIPressAction;

		[SerializeField]
		private InputActionProperty m_UIPressActionValue;

		[SerializeField]
		private InputActionProperty m_UIScrollAction;

		[SerializeField]
		private InputActionProperty m_HapticDeviceAction;

		[SerializeField]
		private InputActionProperty m_RotateAnchorAction;

		[SerializeField]
		private InputActionProperty m_DirectionalAnchorRotationAction;

		[SerializeField]
		private InputActionProperty m_TranslateAnchorAction;

		[SerializeField]
		private InputActionProperty m_ScaleToggleAction;

		[SerializeField]
		private InputActionProperty m_ScaleDeltaAction;

		private bool m_HasCheckedDisabledTrackingInputReferenceActions;

		private bool m_HasCheckedDisabledInputReferenceActions;

		private readonly HapticControlActionManager m_HapticControlActionManager;

		[Obsolete("Deprecated, this obsolete property is not used when Input System version is 1.1.0 or higher. Configure press point on the action or binding instead.", true)]
		public float buttonPressPoint
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public InputActionProperty positionAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty rotationAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty isTrackedAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty trackingStateAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty selectAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty selectActionValue
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty activateAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty activateActionValue
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty uiPressAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty uiPressActionValue
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty uiScrollAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty hapticDeviceAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty rotateAnchorAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty directionalAnchorRotationAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty translateAnchorAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty scaleToggleAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty scaleDeltaAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void UpdateTrackingInput(XRControllerState controllerState)
		{
		}

		protected override void UpdateInput(XRControllerState controllerState)
		{
		}

		protected virtual bool IsPressed(InputAction action)
		{
			return false;
		}

		protected virtual float ReadValue(InputAction action)
		{
			return 0f;
		}

		public override bool SendHapticImpulse(float amplitude, float duration)
		{
			return false;
		}

		private void EnableAllDirectActions()
		{
		}

		private void DisableAllDirectActions()
		{
		}

		private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value)
		{
		}

		private static bool IsDisabledReferenceAction(InputActionProperty property)
		{
			return false;
		}
	}
}
