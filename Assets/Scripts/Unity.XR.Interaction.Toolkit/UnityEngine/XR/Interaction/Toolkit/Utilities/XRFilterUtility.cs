using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal static class XRFilterUtility
	{
		public static bool Process(SmallRegistrationList<IXRHoverFilter> filters, IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
			return false;
		}

		public static bool Process(SmallRegistrationList<IXRSelectFilter> filters, IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
			return false;
		}

		public static float Process(SmallRegistrationList<IXRInteractionStrengthFilter> filters, IXRInteractor interactor, IXRInteractable interactable, float interactionStrength)
		{
			return 0f;
		}
	}
}
