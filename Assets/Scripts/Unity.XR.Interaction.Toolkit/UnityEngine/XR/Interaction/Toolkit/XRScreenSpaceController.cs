using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/XR Screen Space Controller", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.XRScreenSpaceController.html")]
	[Obsolete("XRScreenSpaceController has been deprecated in version 3.0.0. Its functionality has been distributed into different components.")]
	public class XRScreenSpaceController : XRBaseController
	{
		[Header("Touchscreen Gesture Actions")]
		[SerializeField]
		[Tooltip("When enabled, a Touchscreen Gesture Input Controller will be added to the Input System device list to detect touch gestures.")]
		private bool m_EnableTouchscreenGestureInputController;

		[SerializeField]
		[Tooltip("The action to use for the screen tap position. (Vector 2 Control).")]
		private InputActionProperty m_TapStartPositionAction;

		[SerializeField]
		[Tooltip("The action to use for the current screen drag position. (Vector 2 Control).")]
		private InputActionProperty m_DragCurrentPositionAction;

		[SerializeField]
		[Tooltip("The action to use for the delta of the screen drag. (Vector 2 Control).")]
		private InputActionProperty m_DragDeltaAction;

		[SerializeField]
		[FormerlySerializedAs("m_PinchStartPosition")]
		[Tooltip("The action to use for the screen pinch gesture start position. (Vector 2 Control).")]
		private InputActionProperty m_PinchStartPositionAction;

		[SerializeField]
		[Tooltip("The action to use for the gap of the screen pinch gesture. (Axis Control).")]
		private InputActionProperty m_PinchGapAction;

		[SerializeField]
		[Tooltip("The action to use for the delta of the screen pinch gesture. (Axis Control).")]
		private InputActionProperty m_PinchGapDeltaAction;

		[SerializeField]
		[FormerlySerializedAs("m_TwistStartPosition")]
		[Tooltip("The action to use for the screen twist gesture start position. (Vector 2 Control).")]
		private InputActionProperty m_TwistStartPositionAction;

		[SerializeField]
		[FormerlySerializedAs("m_TwistRotationDeltaAction")]
		[Tooltip("The action to use for the delta of the screen twist gesture. (Axis Control).")]
		private InputActionProperty m_TwistDeltaRotationAction;

		[SerializeField]
		[FormerlySerializedAs("m_ScreenTouchCount")]
		[Tooltip("The number of concurrent touches on the screen. (Integer Control).")]
		private InputActionProperty m_ScreenTouchCountAction;

		[SerializeField]
		[Tooltip("The camera associated with the screen, and through which screen presses/touches will be interpreted.")]
		private Camera m_ControllerCamera;

		[SerializeField]
		[Tooltip("Tells the XR Screen Space Controller to ignore interactions when hitting a screen space canvas.")]
		private bool m_BlockInteractionsWithScreenSpaceUI;

		[SerializeField]
		[Tooltip("Enables a rotation threshold that blocks pinch scale gestures when surpassed.")]
		private bool m_UseRotationThreshold;

		[SerializeField]
		[Tooltip("The threshold at which a gestures will be interpreted only as rotation and not a pinch scale gesture.")]
		private float m_RotationThreshold;

		private bool m_HasCheckedDisabledTrackingInputReferenceActions;

		private bool m_HasCheckedDisabledInputReferenceActions;

		private UIInputModule m_UIInputModule;

		public bool enableTouchscreenGestureInputController
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InputActionProperty tapStartPositionAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty dragCurrentPositionAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty dragDeltaAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty pinchStartPositionAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty pinchGapAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty pinchGapDeltaAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty twistStartPositionAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty twistDeltaRotationAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty screenTouchCountAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public Camera controllerCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool blockInteractionsWithScreenSpaceUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useRotationThreshold
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float rotationThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scaleDelta
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[Obsolete("pinchStartPosition has been deprecated. Use pinchStartPositionAction instead. (UnityUpgradable) -> pinchStartPositionAction", true)]
		public InputActionProperty pinchStartPosition
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		[Obsolete("pinchGapDelta has been deprecated. Use pinchGapDeltaAction instead. (UnityUpgradable) -> pinchGapDeltaAction", true)]
		public InputActionProperty pinchGapDelta
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		[Obsolete("twistStartPosition has been deprecated. Use twistStartPositionAction instead. (UnityUpgradable) -> twistStartPositionAction", true)]
		public InputActionProperty twistStartPosition
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		[Obsolete("twistRotationDeltaAction has been deprecated. Use twistDeltaRotationAction instead. (UnityUpgradable) -> twistDeltaRotationAction", true)]
		public InputActionProperty twistRotationDeltaAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		[Obsolete("screenTouchCount has been deprecated. Use screenTouchCountAction instead. (UnityUpgradable) -> screenTouchCountAction", true)]
		public InputActionProperty screenTouchCount
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		protected void Start()
		{
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

		private bool TryGetCurrentPositionAction(int touchCount, out InputAction action)
		{
			action = null;
			return false;
		}

		private bool TryGetCurrentOneInputSelectAction(out InputAction action)
		{
			action = null;
			return false;
		}

		private bool TryGetCurrentTwoInputSelectAction(out InputAction action)
		{
			action = null;
			return false;
		}

		private static bool TryGetAbsoluteValue(InputAction action, out float value)
		{
			value = default(float);
			return false;
		}

		private bool FindUIInputModule()
		{
			return false;
		}

		private bool IsPointerOverScreenSpaceCanvas()
		{
			return false;
		}

		private void InitializeTouchscreenGestureController()
		{
		}

		private void RemoveTouchscreenGestureController()
		{
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
