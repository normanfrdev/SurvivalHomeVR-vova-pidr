using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Interactables
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public static class XRHoverInteractableExtensions
	{
		public static IXRHoverInteractor GetOldestInteractorHovering(this IXRHoverInteractable interactable)
		{
			return null;
		}

		public static bool IsHoveredByLeft(this IXRHoverInteractable interactable)
		{
			return false;
		}

		public static bool IsHoveredByRight(this IXRHoverInteractable interactable)
		{
			return false;
		}

		private static bool IsHoveredBy(IXRHoverInteractable interactable, InteractorHandedness handedness)
		{
			return false;
		}
	}
}
