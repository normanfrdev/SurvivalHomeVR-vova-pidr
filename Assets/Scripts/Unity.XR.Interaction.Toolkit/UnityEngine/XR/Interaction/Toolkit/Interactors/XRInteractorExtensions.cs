using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public static class XRInteractorExtensions
	{
		public static bool IsBlockedByInteractionWithinGroup(this IXRInteractor interactor)
		{
			return false;
		}
	}
}
