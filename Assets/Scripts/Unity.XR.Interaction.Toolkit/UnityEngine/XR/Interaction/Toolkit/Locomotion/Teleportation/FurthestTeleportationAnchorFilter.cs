using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[CreateAssetMenu(fileName = "FurthestTeleportationAnchorFilter", menuName = "XR/Locomotion/Furthest Teleportation Anchor Filter")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.FurthestTeleportationAnchorFilter.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class FurthestTeleportationAnchorFilter : ScriptableObject, ITeleportationVolumeAnchorFilter
	{
		public int GetDestinationAnchorIndex(TeleportationMultiAnchorVolume teleportationVolume)
		{
			return 0;
		}
	}
}
