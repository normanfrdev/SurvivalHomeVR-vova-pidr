using System;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	[AddComponentMenu("Event/XR UI Input Module", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.UI.XRUIInputModule.html")]
	public class XRUIInputModule : UIInputModule
	{
		private struct RegisteredInteractor
		{
			public IUIInteractor interactor;

			public TrackedDeviceModel model;

			public RegisteredInteractor(IUIInteractor interactor, int deviceIndex)
			{
			}
		}

		private struct RegisteredTouch
		{
			public bool isValid;

			public int touchId;

			public TouchModel model;

			public RegisteredTouch(Touch touch, int deviceIndex)
			{
			}
		}

		public enum ActiveInputMode
		{
			InputManagerBindings = 0,
			InputSystemActions = 1,
			Both = 2
		}

		[HideInInspector]
		[SerializeField]
		[Tooltip("Represents which Active Input Mode will be used in the situation where the Active Input Handling project setting is set to Both.")]
		private ActiveInputMode m_ActiveInputMode;

		[Header("Input Devices")]
		[SerializeField]
		[Tooltip("If true, will forward 3D tracked device data to UI elements.")]
		private bool m_EnableXRInput;

		[SerializeField]
		[Tooltip("If true, will forward 2D mouse data to UI elements.")]
		private bool m_EnableMouseInput;

		[SerializeField]
		[Tooltip("If true, will forward 2D touch data to UI elements.")]
		private bool m_EnableTouchInput;

		[Header("Input System UI Actions")]
		[SerializeField]
		[Tooltip("Pointer input action reference, such as a mouse or single-finger touch device.")]
		private InputActionReference m_PointAction;

		[SerializeField]
		[Tooltip("Left-click input action reference, typically the left button on a mouse.")]
		private InputActionReference m_LeftClickAction;

		[SerializeField]
		[Tooltip("Middle-click input action reference, typically the middle button on a mouse.")]
		private InputActionReference m_MiddleClickAction;

		[SerializeField]
		[Tooltip("Right-click input action reference, typically the right button on a mouse.")]
		private InputActionReference m_RightClickAction;

		[SerializeField]
		[Tooltip("Scroll wheel input action reference, typically the scroll wheel on a mouse.")]
		private InputActionReference m_ScrollWheelAction;

		[SerializeField]
		[Tooltip("Navigation input action reference will change which UI element is currently selected to the one up, down, left of or right of the currently selected one.")]
		private InputActionReference m_NavigateAction;

		[SerializeField]
		[Tooltip("Submit input action reference will trigger a submission of the currently selected UI in the Event System.")]
		private InputActionReference m_SubmitAction;

		[SerializeField]
		[Tooltip("Cancel input action reference will trigger canceling out of the currently selected UI in the Event System.")]
		private InputActionReference m_CancelAction;

		[SerializeField]
		[Tooltip("When enabled, built-in Input System actions will be used if no Input System UI Actions are assigned.")]
		private bool m_EnableBuiltinActionsAsFallback;

		[HideInInspector]
		[SerializeField]
		[Tooltip("If true, will use the Input Manager (Old) configuration to forward gamepad data to UI elements.")]
		private bool m_EnableGamepadInput;

		[HideInInspector]
		[SerializeField]
		[Tooltip("If true, will use the Input Manager (Old) configuration to forward joystick data to UI elements.")]
		private bool m_EnableJoystickInput;

		[HideInInspector]
		[SerializeField]
		[Tooltip("Name of the horizontal axis for gamepad/joystick UI navigation when using the old Input Manager.")]
		private string m_HorizontalAxis;

		[HideInInspector]
		[SerializeField]
		[Tooltip("Name of the vertical axis for gamepad/joystick UI navigation when using the old Input Manager.")]
		private string m_VerticalAxis;

		[HideInInspector]
		[SerializeField]
		[Tooltip("Name of the gamepad/joystick button to use for UI selection or submission when using the old Input Manager.")]
		private string m_SubmitButton;

		[HideInInspector]
		[SerializeField]
		[Tooltip("Name of the gamepad/joystick button to use for UI cancel or back commands when using the old Input Manager.")]
		private string m_CancelButton;

		private int m_RollingPointerId;

		private bool m_UseBuiltInInputSystemActions;

		private MouseModel m_MouseState;

		private NavigationModel m_NavigationState;

		internal const float kPixelPerLine = 20f;

		private readonly List<RegisteredTouch> m_RegisteredTouches;

		private readonly List<RegisteredInteractor> m_RegisteredInteractors;

		private readonly LinkedPool<UIHoverEventArgs> m_UIHoverEventArgs;

		public ActiveInputMode activeInputMode
		{
			get
			{
				return default(ActiveInputMode);
			}
			set
			{
			}
		}

		public bool enableXRInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableMouseInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableTouchInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InputActionReference pointAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference leftClickAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference middleClickAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference rightClickAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference scrollWheelAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference navigateAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference submitAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference cancelAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enableBuiltinActionsAsFallback
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableGamepadInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableJoystickInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string horizontalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string verticalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string submitButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string cancelButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("maxRaycastDistance has been deprecated. Its value was unused, calling this property is unnecessary and should be removed.", true)]
		public float maxRaycastDistance
		{
			get
			{
				return 0f;
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

		public void RegisterInteractor(IUIInteractor interactor)
		{
		}

		public void UnregisterInteractor(IUIInteractor interactor)
		{
		}

		public IUIInteractor GetInteractor(int pointerId)
		{
			return null;
		}

		public bool GetTrackedDeviceModel(IUIInteractor interactor, out TrackedDeviceModel model)
		{
			model = default(TrackedDeviceModel);
			return false;
		}

		protected override void DoProcess()
		{
		}

		private void ProcessMouse()
		{
		}

		private bool ProcessTouches()
		{
			return false;
		}

		private void ProcessNavigation()
		{
		}

		private bool InputActionReferencesAreSet()
		{
			return false;
		}

		private void EnableAllActions()
		{
		}

		private void DisableAllActions()
		{
		}

		private static bool IsActionEnabled(InputActionReference inputAction)
		{
			return false;
		}

		private static void EnableInputAction(InputActionReference inputAction)
		{
		}

		private static void DisableInputAction(InputActionReference inputAction)
		{
		}

		private void SetInputAction(ref InputActionReference inputAction, InputActionReference value)
		{
		}

		private int GetDisplayIndexFor(InputControl control)
		{
			return 0;
		}
	}
}
