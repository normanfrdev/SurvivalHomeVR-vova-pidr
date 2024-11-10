using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
	[AddComponentMenu("XR/Debug/XR Device Simulator", 11)]
	[DefaultExecutionOrder(-29991)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.html")]
	public class XRDeviceSimulator : MonoBehaviour
	{
		public enum Space
		{
			Local = 0,
			Parent = 1,
			Screen = 2
		}

		public enum TransformationMode
		{
			Translate = 0,
			Rotate = 1
		}

		[Flags]
		internal enum TargetedDevices
		{
			None = 0,
			FPS = 1,
			LeftDevice = 2,
			RightDevice = 4,
			HMD = 8
		}

		public enum DeviceMode
		{
			Controller = 0,
			Hand = 1
		}

		[Flags]
		public enum Axis2DTargets
		{
			None = 0,
			Position = 1,
			Primary2DAxis = 2,
			Secondary2DAxis = 4
		}

		[Serializable]
		public class SimulatedHandExpression : ISerializationCallbackReceiver
		{
			[SerializeField]
			[Tooltip("The unique name for the hand expression.")]
			[Delayed]
			private string m_Name;

			[SerializeField]
			[Tooltip("The input action to trigger the hand expression.")]
			private InputActionReference m_ToggleAction;

			[SerializeField]
			[Tooltip("The captured hand expression to simulate when the input action is performed.")]
			private HandExpressionCapture m_Capture;

			private HandExpressionName m_ExpressionName;

			private Action<SimulatedHandExpression, InputAction.CallbackContext> m_Performed;

			private bool m_Subscribed;

			public string name => null;

			public InputActionReference toggleAction => null;

			internal HandExpressionCapture capture
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal HandExpressionName expressionName
			{
				get
				{
					return default(HandExpressionName);
				}
				set
				{
				}
			}

			public Sprite icon => null;

			public event Action<SimulatedHandExpression, InputAction.CallbackContext> performed
			{
				add
				{
				}
				remove
				{
				}
			}

			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}

			private void OnActionPerformed(InputAction.CallbackContext context)
			{
			}
		}

		private const float k_CameraMaxXAngle = 80f;

		private static readonly Vector3 s_LeftDeviceDefaultInitialPosition;

		private static readonly Vector3 s_RightDeviceDefaultInitialPosition;

		[SerializeField]
		[Tooltip("Input Action asset containing controls for the simulator itself. Unity will automatically enable and disable it with this component.")]
		private InputActionAsset m_DeviceSimulatorActionAsset;

		[SerializeField]
		[Tooltip("Input Action asset containing controls for the simulated controllers. Unity will automatically enable and disable it as needed.")]
		private InputActionAsset m_ControllerActionAsset;

		[SerializeField]
		[Tooltip("The Input System Action used to translate in the x-axis (left/right) while held. Must be a Value Axis Control.")]
		private InputActionReference m_KeyboardXTranslateAction;

		[SerializeField]
		[Tooltip("The Input System Action used to translate in the y-axis (up/down) while held. Must be a Value Axis Control.")]
		private InputActionReference m_KeyboardYTranslateAction;

		[SerializeField]
		[Tooltip("The Input System Action used to translate in the z-axis (forward/back) while held. Must be a Value Axis Control.")]
		private InputActionReference m_KeyboardZTranslateAction;

		[SerializeField]
		[Tooltip("The Input System Action used to enable manipulation of the left-hand controller while held. Must be a Button Control.")]
		private InputActionReference m_ManipulateLeftAction;

		[SerializeField]
		[Tooltip("The Input System Action used to enable manipulation of the right-hand controller while held. Must be a Button Control.")]
		private InputActionReference m_ManipulateRightAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle enable manipulation of the left-hand controller when pressed. Must be a Button Control.")]
		private InputActionReference m_ToggleManipulateLeftAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle enable manipulation of the right-hand controller when pressed. Must be a Button Control.")]
		private InputActionReference m_ToggleManipulateRightAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle enable looking around with the HMD and controllers. Must be a Button Control.")]
		private InputActionReference m_ToggleManipulateBodyAction;

		[SerializeField]
		[Tooltip("The Input System Action used to enable manipulation of the HMD while held. Must be a Button Control.")]
		private InputActionReference m_ManipulateHeadAction;

		[SerializeField]
		[Tooltip("The Input System Action used to change between hand and controller mode. Must be a Button Control.")]
		private InputActionReference m_HandControllerModeAction;

		[SerializeField]
		[Tooltip("The Input System Action used to cycle between the different available devices. Must be a Button Control.")]
		private InputActionReference m_CycleDevicesAction;

		[SerializeField]
		[Tooltip("The Input System Action used to stop all manipulation. Must be a Button Control.")]
		private InputActionReference m_StopManipulationAction;

		[SerializeField]
		[Tooltip("The Input System Action used to translate or rotate by a scaled amount along or about the x- and y-axes. Must be a Value Vector2 Control.")]
		private InputActionReference m_MouseDeltaAction;

		[SerializeField]
		[Tooltip("The Input System Action used to translate or rotate by a scaled amount along or about the z-axis. Must be a Value Vector2 Control.")]
		private InputActionReference m_MouseScrollAction;

		[SerializeField]
		[Tooltip("The Input System Action used to cause the manipulated device(s) to rotate when moving the mouse when held. Must be a Button Control.")]
		private InputActionReference m_RotateModeOverrideAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle between translating or rotating the manipulated device(s) when moving the mouse when pressed. Must be a Button Control.")]
		private InputActionReference m_ToggleMouseTransformationModeAction;

		[SerializeField]
		[Tooltip("The Input System Action used to cause the manipulated device(s) to rotate when moving the mouse while held when it would normally translate, and vice-versa. Must be a Button Control.")]
		private InputActionReference m_NegateModeAction;

		[SerializeField]
		[Tooltip("The Input System Action used to constrain the translation or rotation to the x-axis when moving the mouse or resetting. May be combined with another axis constraint to constrain to a plane. Must be a Button Control.")]
		private InputActionReference m_XConstraintAction;

		[SerializeField]
		[Tooltip("The Input System Action used to constrain the translation or rotation to the y-axis when moving the mouse or resetting. May be combined with another axis constraint to constrain to a plane. Must be a Button Control.")]
		private InputActionReference m_YConstraintAction;

		[SerializeField]
		[Tooltip("The Input System Action used to constrain the translation or rotation to the z-axis when moving the mouse or resetting. May be combined with another axis constraint to constrain to a plane. Must be a Button Control.")]
		private InputActionReference m_ZConstraintAction;

		[SerializeField]
		[Tooltip("The Input System Action used to cause the manipulated device(s) to reset position or rotation (depending on the effective manipulation mode). Must be a Button Control.")]
		private InputActionReference m_ResetAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle the cursor lock mode for the game window when pressed. Must be a Button Control.")]
		private InputActionReference m_ToggleCursorLockAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle enable translation from keyboard inputs when pressed. Must be a Button Control.")]
		private InputActionReference m_ToggleDevicePositionTargetAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle enable manipulation of the Primary2DAxis of the controllers when pressed. Must be a Button Control.")]
		private InputActionReference m_TogglePrimary2DAxisTargetAction;

		[SerializeField]
		[Tooltip("The Input System Action used to toggle enable manipulation of the Secondary2DAxis of the controllers when pressed. Must be a Button Control.")]
		private InputActionReference m_ToggleSecondary2DAxisTargetAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the value of one or more 2D Axis controls on the manipulated controller device(s). Must be a Value Vector2 Control.")]
		private InputActionReference m_Axis2DAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control one or more 2D Axis controls on the opposite hand of the exclusively manipulated controller device. Must be a Value Vector2 Control.")]
		private InputActionReference m_RestingHandAxis2DAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the Grip control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_GripAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the Trigger control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_TriggerAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the PrimaryButton control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_PrimaryButtonAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the SecondaryButton control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_SecondaryButtonAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the Menu control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_MenuAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the Primary2DAxisClick control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_Primary2DAxisClickAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the Secondary2DAxisClick control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_Secondary2DAxisClickAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the Primary2DAxisTouch control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_Primary2DAxisTouchAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the Secondary2DAxisTouch control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_Secondary2DAxisTouchAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the PrimaryTouch control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_PrimaryTouchAction;

		[SerializeField]
		[Tooltip("The Input System Action used to control the SecondaryTouch control of the manipulated controller device(s). Must be a Button Control.")]
		private InputActionReference m_SecondaryTouchAction;

		[SerializeField]
		[Tooltip("Input Action asset containing controls for the simulated hands. Unity will automatically enable and disable it as needed.")]
		private InputActionAsset m_HandActionAsset;

		[SerializeField]
		[Tooltip("The resting hand expression to use when no other hand expression is active.")]
		private HandExpressionCapture m_RestingHandExpressionCapture;

		[SerializeField]
		[Tooltip("The list of hand expressions to simulate.")]
		private List<SimulatedHandExpression> m_SimulatedHandExpressions;

		[SerializeField]
		[Tooltip("The Transform that contains the Camera. This is usually the \"Head\" of XR Origins. Automatically set to the first enabled camera tagged MainCamera if unset.")]
		private Transform m_CameraTransform;

		[SerializeField]
		[Tooltip("The coordinate space in which keyboard translation should operate.")]
		private Space m_KeyboardTranslateSpace;

		[SerializeField]
		[Tooltip("The coordinate space in which mouse translation should operate.")]
		private Space m_MouseTranslateSpace;

		[SerializeField]
		[Tooltip("Speed of translation in the x-axis (left/right) when triggered by keyboard input.")]
		private float m_KeyboardXTranslateSpeed;

		[SerializeField]
		[Tooltip("Speed of translation in the y-axis (up/down) when triggered by keyboard input.")]
		private float m_KeyboardYTranslateSpeed;

		[SerializeField]
		[Tooltip("Speed of translation in the z-axis (forward/back) when triggered by keyboard input.")]
		private float m_KeyboardZTranslateSpeed;

		[SerializeField]
		[Tooltip("Speed multiplier applied for body translation when triggered by keyboard input.")]
		private float m_KeyboardBodyTranslateMultiplier;

		[SerializeField]
		[Tooltip("Sensitivity of translation in the x-axis (left/right) when triggered by mouse input.")]
		private float m_MouseXTranslateSensitivity;

		[SerializeField]
		[Tooltip("Sensitivity of translation in the y-axis (up/down) when triggered by mouse input.")]
		private float m_MouseYTranslateSensitivity;

		[SerializeField]
		[Tooltip("Sensitivity of translation in the z-axis (forward/back) when triggered by mouse scroll input.")]
		private float m_MouseScrollTranslateSensitivity;

		[SerializeField]
		[Tooltip("Sensitivity of rotation along the x-axis (pitch) when triggered by mouse input.")]
		private float m_MouseXRotateSensitivity;

		[SerializeField]
		[Tooltip("Sensitivity of rotation along the y-axis (yaw) when triggered by mouse input.")]
		private float m_MouseYRotateSensitivity;

		[SerializeField]
		[Tooltip("Sensitivity of rotation along the z-axis (roll) when triggered by mouse scroll input.")]
		private float m_MouseScrollRotateSensitivity;

		[SerializeField]
		[Tooltip("A boolean value of whether to invert the y-axis of mouse input when rotating by mouse input.\nA false value (default) means typical FPS style where moving the mouse up/down pitches up/down.\nA true value means flight control style where moving the mouse up/down pitches down/up.")]
		private bool m_MouseYRotateInvert;

		[SerializeField]
		[Tooltip("The desired cursor lock mode to toggle to from None (either Locked or Confined).")]
		private CursorLockMode m_DesiredCursorLockMode;

		[SerializeField]
		[Tooltip("Whether or not to remove other XR HMD devices in this session so that they don't conflict with the XR Device Simulator.")]
		private bool m_RemoveOtherHMDDevices;

		[SerializeField]
		[Tooltip("Whether to create a simulated Hand Tracking Subsystem and provider on startup. Requires the XR Hands package.")]
		private bool m_HandTrackingCapability;

		[SerializeField]
		[Tooltip("The optional Device Simulator UI prefab to use along with the XR Device Simulator.")]
		private GameObject m_DeviceSimulatorUI;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("The amount of the simulated grip on the controller when the Grip control is pressed.")]
		private float m_GripAmount;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("The amount of the simulated trigger pull on the controller when the Trigger control is pressed.")]
		private float m_TriggerAmount;

		[SerializeField]
		[Tooltip("Whether the HMD should report the pose as fully tracked or unavailable/inferred.")]
		private bool m_HMDIsTracked;

		[SerializeField]
		[Tooltip("Which tracking values the HMD should report as being valid or meaningful to use, which could mean either tracked or inferred.")]
		private InputTrackingState m_HMDTrackingState;

		[SerializeField]
		[Tooltip("Whether the left-hand controller should report the pose as fully tracked or unavailable/inferred.")]
		private bool m_LeftControllerIsTracked;

		[SerializeField]
		[Tooltip("Which tracking values the left-hand controller should report as being valid or meaningful to use, which could mean either tracked or inferred.")]
		private InputTrackingState m_LeftControllerTrackingState;

		[SerializeField]
		[Tooltip("Whether the right-hand controller should report the pose as fully tracked or unavailable/inferred.")]
		private bool m_RightControllerIsTracked;

		[SerializeField]
		[Tooltip("Which tracking values the right-hand controller should report as being valid or meaningful to use, which could mean either tracked or inferred.")]
		private InputTrackingState m_RightControllerTrackingState;

		[SerializeField]
		[Tooltip("Whether the left hand should report the pose as fully tracked or unavailable/inferred.")]
		private bool m_LeftHandIsTracked;

		[SerializeField]
		[Tooltip("Whether the right hand should report the pose as fully tracked or unavailable/inferred.")]
		private bool m_RightHandIsTracked;

		private TargetedDevices m_TargetedDeviceInput;

		private DeviceMode m_DeviceMode;

		private bool m_DeviceModeDirty;

		private bool m_StartedDeviceModeChange;

		private (Transform transform, Camera camera) m_CachedCamera;

		private float m_KeyboardXTranslateInput;

		private float m_KeyboardYTranslateInput;

		private float m_KeyboardZTranslateInput;

		private Vector2 m_MouseDeltaInput;

		private Vector2 m_MouseScrollInput;

		private bool m_RotateModeOverrideInput;

		private bool m_XConstraintInput;

		private bool m_YConstraintInput;

		private bool m_ZConstraintInput;

		private bool m_ResetInput;

		private Vector2 m_Axis2DInput;

		private Vector2 m_RestingHandAxis2DInput;

		private bool m_GripInput;

		private bool m_TriggerInput;

		private bool m_PrimaryButtonInput;

		private bool m_SecondaryButtonInput;

		private bool m_MenuInput;

		private bool m_Primary2DAxisClickInput;

		private bool m_Secondary2DAxisClickInput;

		private bool m_Primary2DAxisTouchInput;

		private bool m_Secondary2DAxisTouchInput;

		private bool m_PrimaryTouchInput;

		private bool m_SecondaryTouchInput;

		private bool m_ManipulatedRestingHandAxis2D;

		private Vector3 m_LeftControllerEuler;

		private Vector3 m_RightControllerEuler;

		private Vector3 m_CenterEyeEuler;

		private XRSimulatedHMDState m_HMDState;

		private XRSimulatedControllerState m_LeftControllerState;

		private XRSimulatedControllerState m_RightControllerState;

		private XRSimulatedHMD m_HMDDevice;

		private XRSimulatedController m_LeftControllerDevice;

		private XRSimulatedController m_RightControllerDevice;

		private bool m_OnInputDeviceChangeSubscribed;

		private XRSimulatedHandState m_LeftHandState;

		private XRSimulatedHandState m_RightHandState;

		public InputActionAsset deviceSimulatorActionAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionAsset controllerActionAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference keyboardXTranslateAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference keyboardYTranslateAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference keyboardZTranslateAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference manipulateLeftAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference manipulateRightAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference toggleManipulateLeftAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference toggleManipulateRightAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference toggleManipulateBodyAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference manipulateHeadAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference handControllerModeAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference cycleDevicesAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference stopManipulationAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference mouseDeltaAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference mouseScrollAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference rotateModeOverrideAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference toggleMouseTransformationModeAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference negateModeAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference xConstraintAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference yConstraintAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference zConstraintAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference resetAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference toggleCursorLockAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference toggleDevicePositionTargetAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference togglePrimary2DAxisTargetAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference toggleSecondary2DAxisTargetAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference axis2DAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference restingHandAxis2DAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference gripAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference triggerAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference primaryButtonAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference secondaryButtonAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference menuAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference primary2DAxisClickAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference secondary2DAxisClickAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference primary2DAxisTouchAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference secondary2DAxisTouchAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference primaryTouchAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference secondaryTouchAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionAsset handActionAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SimulatedHandExpression> simulatedHandExpressions => null;

		public Transform cameraTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Space keyboardTranslateSpace
		{
			get
			{
				return default(Space);
			}
			set
			{
			}
		}

		public Space mouseTranslateSpace
		{
			get
			{
				return default(Space);
			}
			set
			{
			}
		}

		public float keyboardXTranslateSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float keyboardYTranslateSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float keyboardZTranslateSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float keyboardBodyTranslateMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mouseXTranslateSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mouseYTranslateSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mouseScrollTranslateSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mouseXRotateSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mouseYRotateSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mouseScrollRotateSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool mouseYRotateInvert
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CursorLockMode desiredCursorLockMode
		{
			get
			{
				return default(CursorLockMode);
			}
			set
			{
			}
		}

		public bool removeOtherHMDDevices
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool handTrackingCapability
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GameObject deviceSimulatorUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float gripAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float triggerAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hmdIsTracked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InputTrackingState hmdTrackingState
		{
			get
			{
				return default(InputTrackingState);
			}
			set
			{
			}
		}

		public bool leftControllerIsTracked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InputTrackingState leftControllerTrackingState
		{
			get
			{
				return default(InputTrackingState);
			}
			set
			{
			}
		}

		public bool rightControllerIsTracked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InputTrackingState rightControllerTrackingState
		{
			get
			{
				return default(InputTrackingState);
			}
			set
			{
			}
		}

		public bool leftHandIsTracked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool rightHandIsTracked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TransformationMode mouseTransformationMode
		{
			[CompilerGenerated]
			get
			{
				return default(TransformationMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool negateMode
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Axis2DTargets axis2DTargets
		{
			[CompilerGenerated]
			get
			{
				return default(Axis2DTargets);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool manipulatingLeftDevice => false;

		public bool manipulatingRightDevice => false;

		public bool manipulatingLeftController => false;

		public bool manipulatingRightController => false;

		public bool manipulatingLeftHand => false;

		public bool manipulatingRightHand => false;

		public bool manipulatingFPS => false;

		public static XRDeviceSimulator instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private TargetedDevices targetedDeviceInput
		{
			get
			{
				return default(TargetedDevices);
			}
			set
			{
			}
		}

		public DeviceMode deviceMode => default(DeviceMode);

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		private void InitializeHandSubsystem()
		{
		}

		private bool FindCameraTransform()
		{
			return false;
		}

		protected virtual void ProcessPoseInput()
		{
		}

		protected virtual void ProcessControlInput()
		{
		}

		private void ApplyHandState()
		{
		}

		private void ToggleHandExpression(SimulatedHandExpression simulatedExpression)
		{
		}

		protected virtual void ProcessAxis2DControlInput()
		{
		}

		protected virtual void ProcessButtonControlInput(ref XRSimulatedControllerState controllerState)
		{
		}

		protected virtual void ProcessAnalogButtonControlInput(ref XRSimulatedControllerState controllerState)
		{
		}

		protected virtual void AddDevices()
		{
		}

		private void AddControllerDevices()
		{
		}

		protected virtual void RemoveDevices()
		{
		}

		private void RemoveControllerDevices()
		{
		}

		private void OnInputDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change)
		{
		}

		protected Vector3 GetResetScale()
		{
			return default(Vector3);
		}

		private static void GetAxes(Space translateSpace, Transform cameraTransform, out Vector3 right, out Vector3 up, out Vector3 forward)
		{
			right = default(Vector3);
			up = default(Vector3);
			forward = default(Vector3);
		}

		private static Quaternion GetDeltaRotation(Space translateSpace, in XRSimulatedControllerState state, in Quaternion inverseCameraParentRotation)
		{
			return default(Quaternion);
		}

		private static Quaternion GetDeltaRotation(Space translateSpace, in XRSimulatedHandState state, in Quaternion inverseCameraParentRotation)
		{
			return default(Quaternion);
		}

		private static Quaternion GetDeltaRotation(Space translateSpace, in XRSimulatedHMDState state, in Quaternion inverseCameraParentRotation)
		{
			return default(Quaternion);
		}

		private static Quaternion GetDeltaRotation(Space translateSpace, Quaternion rotation, in Quaternion inverseCameraParentRotation)
		{
			return default(Quaternion);
		}

		private static void Subscribe(InputActionReference reference, Action<InputAction.CallbackContext> performed = null, Action<InputAction.CallbackContext> canceled = null)
		{
		}

		private static void Unsubscribe(InputActionReference reference, Action<InputAction.CallbackContext> performed = null, Action<InputAction.CallbackContext> canceled = null)
		{
		}

		public static TransformationMode Negate(TransformationMode mode)
		{
			return default(TransformationMode);
		}

		private CursorLockMode Negate(CursorLockMode mode)
		{
			return default(CursorLockMode);
		}

		private static DeviceMode Negate(DeviceMode mode)
		{
			return default(DeviceMode);
		}

		private void SubscribeKeyboardXTranslateAction()
		{
		}

		private void UnsubscribeKeyboardXTranslateAction()
		{
		}

		private void SubscribeKeyboardYTranslateAction()
		{
		}

		private void UnsubscribeKeyboardYTranslateAction()
		{
		}

		private void SubscribeKeyboardZTranslateAction()
		{
		}

		private void UnsubscribeKeyboardZTranslateAction()
		{
		}

		private void SubscribeManipulateLeftAction()
		{
		}

		private void UnsubscribeManipulateLeftAction()
		{
		}

		private void SubscribeManipulateRightAction()
		{
		}

		private void UnsubscribeManipulateRightAction()
		{
		}

		private void SubscribeToggleManipulateLeftAction()
		{
		}

		private void UnsubscribeToggleManipulateLeftAction()
		{
		}

		private void SubscribeToggleManipulateRightAction()
		{
		}

		private void UnsubscribeToggleManipulateRightAction()
		{
		}

		private void SubscribeToggleManipulateBodyAction()
		{
		}

		private void UnsubscribeToggleManipulateBodyAction()
		{
		}

		private void SubscribeManipulateHeadAction()
		{
		}

		private void UnsubscribeManipulateHeadAction()
		{
		}

		private void SubscribeHandControllerModeAction()
		{
		}

		private void UnsubscribeHandControllerModeAction()
		{
		}

		private void SubscribeCycleDevicesAction()
		{
		}

		private void UnsubscribeCycleDevicesAction()
		{
		}

		private void SubscribeStopManipulationAction()
		{
		}

		private void UnsubscribeStopManipulationAction()
		{
		}

		private void SubscribeMouseDeltaAction()
		{
		}

		private void UnsubscribeMouseDeltaAction()
		{
		}

		private void SubscribeMouseScrollAction()
		{
		}

		private void UnsubscribeMouseScrollAction()
		{
		}

		private void SubscribeRotateModeOverrideAction()
		{
		}

		private void UnsubscribeRotateModeOverrideAction()
		{
		}

		private void SubscribeToggleMouseTransformationModeAction()
		{
		}

		private void UnsubscribeToggleMouseTransformationModeAction()
		{
		}

		private void SubscribeNegateModeAction()
		{
		}

		private void UnsubscribeNegateModeAction()
		{
		}

		private void SubscribeXConstraintAction()
		{
		}

		private void UnsubscribeXConstraintAction()
		{
		}

		private void SubscribeYConstraintAction()
		{
		}

		private void UnsubscribeYConstraintAction()
		{
		}

		private void SubscribeZConstraintAction()
		{
		}

		private void UnsubscribeZConstraintAction()
		{
		}

		private void SubscribeResetAction()
		{
		}

		private void UnsubscribeResetAction()
		{
		}

		private void SubscribeToggleCursorLockAction()
		{
		}

		private void UnsubscribeToggleCursorLockAction()
		{
		}

		private void SubscribeToggleDevicePositionTargetAction()
		{
		}

		private void UnsubscribeToggleDevicePositionTargetAction()
		{
		}

		private void SubscribeTogglePrimary2DAxisTargetAction()
		{
		}

		private void UnsubscribeTogglePrimary2DAxisTargetAction()
		{
		}

		private void SubscribeToggleSecondary2DAxisTargetAction()
		{
		}

		private void UnsubscribeToggleSecondary2DAxisTargetAction()
		{
		}

		private void SubscribeAxis2DAction()
		{
		}

		private void UnsubscribeAxis2DAction()
		{
		}

		private void SubscribeRestingHandAxis2DAction()
		{
		}

		private void UnsubscribeRestingHandAxis2DAction()
		{
		}

		private void SubscribeGripAction()
		{
		}

		private void UnsubscribeGripAction()
		{
		}

		private void SubscribeTriggerAction()
		{
		}

		private void UnsubscribeTriggerAction()
		{
		}

		private void SubscribePrimaryButtonAction()
		{
		}

		private void UnsubscribePrimaryButtonAction()
		{
		}

		private void SubscribeSecondaryButtonAction()
		{
		}

		private void UnsubscribeSecondaryButtonAction()
		{
		}

		private void SubscribeMenuAction()
		{
		}

		private void UnsubscribeMenuAction()
		{
		}

		private void SubscribePrimary2DAxisClickAction()
		{
		}

		private void UnsubscribePrimary2DAxisClickAction()
		{
		}

		private void SubscribeSecondary2DAxisClickAction()
		{
		}

		private void UnsubscribeSecondary2DAxisClickAction()
		{
		}

		private void SubscribePrimary2DAxisTouchAction()
		{
		}

		private void UnsubscribePrimary2DAxisTouchAction()
		{
		}

		private void SubscribeSecondary2DAxisTouchAction()
		{
		}

		private void UnsubscribeSecondary2DAxisTouchAction()
		{
		}

		private void SubscribePrimaryTouchAction()
		{
		}

		private void UnsubscribePrimaryTouchAction()
		{
		}

		private void SubscribeSecondaryTouchAction()
		{
		}

		private void UnsubscribeSecondaryTouchAction()
		{
		}

		private void OnKeyboardXTranslatePerformed(InputAction.CallbackContext context)
		{
		}

		private void OnKeyboardXTranslateCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnKeyboardYTranslatePerformed(InputAction.CallbackContext context)
		{
		}

		private void OnKeyboardYTranslateCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnKeyboardZTranslatePerformed(InputAction.CallbackContext context)
		{
		}

		private void OnKeyboardZTranslateCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnManipulateLeftPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnManipulateLeftCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnManipulateRightPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnManipulateRightCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnToggleManipulateLeftPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnToggleManipulateRightPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnToggleManipulateBodyPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnManipulateHeadPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnManipulateHeadCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnHandControllerModePerformed(InputAction.CallbackContext context)
		{
		}

		private void OnCycleDevicesPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnStopManipulationPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnMouseDeltaPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnMouseDeltaCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnMouseScrollPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnMouseScrollCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnRotateModeOverridePerformed(InputAction.CallbackContext context)
		{
		}

		private void OnRotateModeOverrideCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnToggleMouseTransformationModePerformed(InputAction.CallbackContext context)
		{
		}

		private void OnNegateModePerformed(InputAction.CallbackContext context)
		{
		}

		private void OnNegateModeCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnXConstraintPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnXConstraintCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnYConstraintPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnYConstraintCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnZConstraintPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnZConstraintCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnResetPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnResetCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnToggleCursorLockPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnToggleDevicePositionTargetPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnTogglePrimary2DAxisTargetPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnToggleSecondary2DAxisTargetPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnAxis2DPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnAxis2DCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnRestingHandAxis2DPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnRestingHandAxis2DCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnGripPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnGripCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnTriggerPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnTriggerCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnPrimaryButtonPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnPrimaryButtonCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnSecondaryButtonPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnSecondaryButtonCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnMenuPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnMenuCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnPrimary2DAxisClickPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnPrimary2DAxisClickCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnSecondary2DAxisClickPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnSecondary2DAxisClickCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnPrimary2DAxisTouchPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnPrimary2DAxisTouchCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnSecondary2DAxisTouchPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnSecondary2DAxisTouchCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnPrimaryTouchPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnPrimaryTouchCanceled(InputAction.CallbackContext context)
		{
		}

		private void OnSecondaryTouchPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnSecondaryTouchCanceled(InputAction.CallbackContext context)
		{
		}

		private static InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		internal unsafe static bool TryExecuteCommand(InputDeviceCommand* commandPtr, out long result)
		{
			result = default(long);
			return false;
		}
	}
}
