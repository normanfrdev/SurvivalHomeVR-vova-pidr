using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	internal class RegisteredUIInteractorCache
	{
		private XRUIInputModule m_InputModule;

		private XRUIInputModule m_RegisteredInputModule;

		private readonly IUIInteractor m_UiInteractor;

		private readonly XRBaseInteractor m_BaseInteractor;

		public RegisteredUIInteractorCache(IUIInteractor uiInteractor)
		{
		}

		public void RegisterOrUnregisterXRUIInputModule(bool enabled)
		{
		}

		public void RegisterWithXRUIInputModule()
		{
		}

		public void UnregisterFromXRUIInputModule()
		{
		}

		private void FindOrCreateXRUIInputModule()
		{
		}

		public bool TryGetUIModel(out TrackedDeviceModel model)
		{
			model = default(TrackedDeviceModel);
			return false;
		}

		public bool IsOverUIGameObject()
		{
			return false;
		}
	}
}
