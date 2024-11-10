using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[Serializable]
	public class XRInputButtonReader : IXRInputButtonReader, IXRInputValueReader<float>, IXRInputValueReader
	{
		private struct BypassScope : IDisposable
		{
			private readonly XRInputButtonReader m_Reader;

			public BypassScope(XRInputButtonReader reader)
			{
			}

			public void Dispose()
			{
			}
		}

		public enum InputSourceMode
		{
			Unused = 0,
			InputAction = 1,
			InputActionReference = 2,
			ObjectReference = 3,
			ManualValue = 4
		}

		[SerializeField]
		private InputSourceMode m_InputSourceMode;

		[SerializeField]
		private InputAction m_InputActionPerformed;

		[SerializeField]
		private InputAction m_InputActionValue;

		[SerializeField]
		private InputActionReference m_InputActionReferencePerformed;

		[SerializeField]
		private InputActionReference m_InputActionReferenceValue;

		[SerializeField]
		[RequireInterface(typeof(IXRInputButtonReader))]
		private Object m_ObjectReferenceObject;

		[SerializeField]
		private bool m_ManualPerformed;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_ManualValue;

		[SerializeField]
		private bool m_ManualQueuePerformed;

		[SerializeField]
		private bool m_ManualQueueWasPerformedThisFrame;

		[SerializeField]
		private bool m_ManualQueueWasCompletedThisFrame;

		[SerializeField]
		private float m_ManualQueueValue;

		[SerializeField]
		private int m_ManualQueueTargetFrame;

		private int m_ManualFramePerformed;

		private int m_ManualFrameCompleted;

		private bool m_CallingBypass;

		private readonly UnityObjectReferenceCache<IXRInputButtonReader, Object> m_ObjectReference;

		private readonly UnityObjectReferenceCache<InputActionReference> m_InputActionReferencePerformedCache;

		private readonly UnityObjectReferenceCache<InputActionReference> m_InputActionReferenceValueCache;

		public InputSourceMode inputSourceMode
		{
			get
			{
				return default(InputSourceMode);
			}
			set
			{
			}
		}

		public InputAction inputActionPerformed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputAction inputActionValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference inputActionReferencePerformed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference inputActionReferenceValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool manualPerformed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float manualValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int manualFramePerformed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int manualFrameCompleted
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IXRInputButtonReader bypass
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

		public XRInputButtonReader()
		{
		}

		public XRInputButtonReader(string name = null, string valueName = null, bool wantsInitialStateCheck = false, InputSourceMode inputSourceMode = InputSourceMode.InputActionReference)
		{
		}

		public void EnableDirectActionIfModeUsed()
		{
		}

		public void DisableDirectActionIfModeUsed()
		{
		}

		public IXRInputButtonReader GetObjectReference()
		{
			return null;
		}

		public void SetObjectReference(IXRInputButtonReader value)
		{
		}

		public void QueueManualState(bool performed, float value)
		{
		}

		public void QueueManualState(bool performed, float value, bool performedThisFrame, bool completedThisFrame)
		{
		}

		private void RefreshManualIfNeeded()
		{
		}

		public bool ReadIsPerformed()
		{
			return false;
		}

		public bool ReadWasPerformedThisFrame()
		{
			return false;
		}

		public bool ReadWasCompletedThisFrame()
		{
			return false;
		}

		public float ReadValue()
		{
			return 0f;
		}

		public bool TryReadValue(out float value)
		{
			value = default(float);
			return false;
		}

		private static bool IsPerformed(InputAction action)
		{
			return false;
		}

		private static bool WasPerformedThisFrame(InputAction action)
		{
			return false;
		}

		private static bool WasCompletedThisFrame(InputAction action)
		{
			return false;
		}

		private float ReadValueToFloat(InputAction action)
		{
			return 0f;
		}

		private bool TryReadValue(InputAction action, out float value)
		{
			value = default(float);
			return false;
		}

		private bool TryGetInputActionReferencePerformed(out InputActionReference reference)
		{
			reference = null;
			return false;
		}

		private bool TryGetInputActionReferenceValue(out InputActionReference reference)
		{
			reference = null;
			return false;
		}
	}
}
