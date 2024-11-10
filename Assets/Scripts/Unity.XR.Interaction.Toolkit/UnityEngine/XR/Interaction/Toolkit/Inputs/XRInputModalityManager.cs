using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs
{
	[AddComponentMenu("XR/XR Input Modality Manager", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager.html")]
	public class XRInputModalityManager : MonoBehaviour
	{
		public enum InputMode
		{
			None = 0,
			TrackedHand = 1,
			MotionController = 2
		}

		private class TrackedDeviceMonitor
		{
			private readonly List<int> m_MonitoredDevices;

			private bool m_Subscribed;

			public event Action<TrackedDevice> trackingAcquired
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public void AddDevice(TrackedDevice device)
			{
			}

			public void RemoveDevice(TrackedDevice device)
			{
			}

			public void ClearAllDevices()
			{
			}

			private void Subscribe()
			{
			}

			private void Unsubscribe()
			{
			}

			private void OnAfterInputUpdate()
			{
			}
		}

		private class InputDeviceMonitor
		{
			private readonly List<InputDevice> m_MonitoredDevices;

			private bool m_Subscribed;

			public event Action<InputDevice> trackingAcquired
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public void AddDevice(InputDevice device)
			{
			}

			public void RemoveDevice(InputDevice device)
			{
			}

			public void ClearAllDevices()
			{
			}

			private void Subscribe()
			{
			}

			private void Unsubscribe()
			{
			}

			private void OnTrackingAcquired(XRNodeState nodeState)
			{
			}
		}

		[HideInInspector]
		[SerializeField]
		[Tooltip("GameObject representing the left hand group of interactors. Will toggle on when using hand tracking and off when using motion controllers.")]
		private GameObject m_LeftHand;

		[HideInInspector]
		[SerializeField]
		[Tooltip("GameObject representing the right hand group of interactors. Will toggle on when using hand tracking and off when using motion controllers.")]
		private GameObject m_RightHand;

		[Header("Motion Controllers")]
		[SerializeField]
		[Tooltip("GameObject representing the left motion controller group of interactors. Will toggle on when using motion controllers and off when using hand tracking.")]
		private GameObject m_LeftController;

		[SerializeField]
		[Tooltip("GameObject representing the left motion controller group of interactors. Will toggle on when using motion controllers and off when using hand tracking.")]
		private GameObject m_RightController;

		[HideInInspector]
		[SerializeField]
		private UnityEvent m_TrackedHandModeStarted;

		[HideInInspector]
		[SerializeField]
		private UnityEvent m_TrackedHandModeEnded;

		[Header("Events")]
		[SerializeField]
		private UnityEvent m_MotionControllerModeStarted;

		[SerializeField]
		private UnityEvent m_MotionControllerModeEnded;

		private readonly TrackedDeviceMonitor m_TrackedDeviceMonitor;

		private readonly InputDeviceMonitor m_InputDeviceMonitor;

		private static BindableEnum<InputMode> s_CurrentInputMode;

		private InputMode m_LeftInputMode;

		private InputMode m_RightInputMode;

		public GameObject leftHand
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject rightHand
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject leftController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject rightController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent trackedHandModeStarted
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent trackedHandModeEnded
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent motionControllerModeStarted
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent motionControllerModeEnded
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static IReadOnlyBindableVariable<InputMode> currentInputMode => null;

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Update()
		{
		}

		private void SubscribeHandSubsystem()
		{
		}

		private void UnsubscribeHandSubsystem()
		{
		}

		private void LogMissingHandSubsystem()
		{
		}

		private void SetLeftMode(InputMode inputMode)
		{
		}

		private void SetRightMode(InputMode inputMode)
		{
		}

		private void OnModeChanged(InputMode oldInputMode, InputMode newInputMode, InputMode otherHandInputMode)
		{
		}

		private static void SafeSetActive(GameObject gameObject, bool active)
		{
		}

		private bool GetLeftHandIsTracked()
		{
			return false;
		}

		private bool GetRightHandIsTracked()
		{
			return false;
		}

		private void UpdateLeftMode()
		{
		}

		private void UpdateRightMode()
		{
		}

		private void UpdateMode(UnityEngine.InputSystem.XR.XRController controllerDevice, Action<InputMode> setModeMethod)
		{
		}

		private void UpdateMode(InputDevice controllerDevice, Action<InputMode> setModeMethod)
		{
		}

		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change)
		{
		}

		private void OnDeviceConnected(InputDevice device)
		{
		}

		private void OnDeviceDisconnected(InputDevice device)
		{
		}

		private void OnDeviceConfigChanged(InputDevice device)
		{
		}

		private void OnControllerTrackingAcquired(TrackedDevice device)
		{
		}

		private void OnControllerTrackingAcquired(InputDevice device)
		{
		}
	}
}
