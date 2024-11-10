using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[AddComponentMenu("XR/Teleportation Area", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TeleportationArea : BaseTeleportationInteractable
	{
		protected override bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
		{
			return false;
		}
	}
}
