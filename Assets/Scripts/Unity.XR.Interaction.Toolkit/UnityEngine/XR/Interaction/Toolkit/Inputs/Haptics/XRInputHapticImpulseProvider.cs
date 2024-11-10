using System;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	[Serializable]
	public class XRInputHapticImpulseProvider : IXRHapticImpulseProvider
	{
		public enum InputSourceMode
		{
			Unused = 0,
			InputAction = 1,
			InputActionReference = 2,
			ObjectReference = 3
		}

		[SerializeField]
		private InputSourceMode m_InputSourceMode;

		[SerializeField]
		private InputAction m_InputAction;

		[SerializeField]
		private InputActionReference m_InputActionReference;

		[SerializeField]
		[RequireInterface(typeof(IXRHapticImpulseProvider))]
		private Object m_ObjectReferenceObject;

		private readonly UnityObjectReferenceCache<IXRHapticImpulseProvider, Object> m_ObjectReference;

		private HapticControlActionManager m_HapticControlActionManager;

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

		public XRInputHapticImpulseProvider()
		{
		}

		public XRInputHapticImpulseProvider(string name = null, bool wantsInitialStateCheck = false, InputSourceMode inputSourceMode = InputSourceMode.InputActionReference)
		{
		}

		public void EnableDirectActionIfModeUsed()
		{
		}

		public void DisableDirectActionIfModeUsed()
		{
		}

		public IXRHapticImpulseProvider GetObjectReference()
		{
			return null;
		}

		public void SetObjectReference(IXRHapticImpulseProvider value)
		{
		}

		public IXRHapticImpulseChannelGroup GetChannelGroup()
		{
			return null;
		}
	}
}
