using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	public abstract class XRInputValueReader
	{
		public enum InputSourceMode
		{
			Unused = 0,
			InputAction = 1,
			InputActionReference = 2,
			ObjectReference = 3,
			ManualValue = 4
		}

		[SerializeField]
		private protected InputSourceMode m_InputSourceMode;

		[SerializeField]
		private protected InputAction m_InputAction;

		[SerializeField]
		private InputActionReference m_InputActionReference;

		private readonly UnityObjectReferenceCache<InputActionReference> m_InputActionReferenceCache;

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

		public InputAction inputAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputActionReference inputActionReference
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected XRInputValueReader()
		{
		}

		protected XRInputValueReader(InputAction inputAction, InputSourceMode inputSourceMode)
		{
		}

		public void EnableDirectActionIfModeUsed()
		{
		}

		public void DisableDirectActionIfModeUsed()
		{
		}

		private protected bool TryGetInputActionReference(out InputActionReference reference)
		{
			reference = null;
			return false;
		}
	}
	[Serializable]
	public class XRInputValueReader<TValue> : XRInputValueReader, IXRInputValueReader<TValue>, IXRInputValueReader where TValue : struct
	{
		private readonly struct BypassScope : IDisposable
		{
			private readonly XRInputValueReader<TValue> m_Reader;

			public BypassScope(XRInputValueReader<TValue> reader)
			{
			}

			public void Dispose()
			{
			}
		}

		[SerializeField]
		[RequireInterface(typeof(IXRInputValueReader))]
		private Object m_ObjectReferenceObject;

		[SerializeField]
		private TValue m_ManualValue;

		private bool m_CallingBypass;

		private readonly UnityObjectReferenceCache<IXRInputValueReader<TValue>, Object> m_ObjectReference;

		public TValue manualValue
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public IXRInputValueReader<TValue> bypass
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

		public XRInputValueReader()
		{
		}

		public XRInputValueReader(string name = null, InputSourceMode inputSourceMode = InputSourceMode.InputActionReference)
		{
		}

		public IXRInputValueReader<TValue> GetObjectReference()
		{
			return null;
		}

		public void SetObjectReference(IXRInputValueReader<TValue> value)
		{
		}

		public TValue ReadValue()
		{
			return default(TValue);
		}

		public bool TryReadValue(out TValue value)
		{
			value = default(TValue);
			return false;
		}

		private static TValue ReadValue(InputAction action)
		{
			return default(TValue);
		}

		private static bool TryReadValue(InputAction action, out TValue value)
		{
			value = default(TValue);
			return false;
		}
	}
}
