using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Interactables
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public static class XRSelectInteractableExtensions
	{
		public static IXRSelectInteractor GetOldestInteractorSelecting(this IXRSelectInteractable interactable)
		{
			return null;
		}

		public static bool IsSelectedByLeft(this IXRSelectInteractable interactable)
		{
			return false;
		}

		public static bool IsSelectedByRight(this IXRSelectInteractable interactable)
		{
			return false;
		}

		private static bool IsSelectedBy(IXRSelectInteractable interactable, InteractorHandedness handedness)
		{
			return false;
		}
	}
}
