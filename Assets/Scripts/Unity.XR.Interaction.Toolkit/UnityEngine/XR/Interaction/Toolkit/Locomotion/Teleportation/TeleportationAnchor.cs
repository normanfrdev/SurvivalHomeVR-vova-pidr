using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[AddComponentMenu("XR/Teleportation Anchor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TeleportationAnchor : BaseTeleportationInteractable
	{
		[SerializeField]
		[Tooltip("The Transform that represents the teleportation destination.")]
		private Transform m_TeleportAnchorTransform;

		public Transform teleportAnchorTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void OnValidate()
		{
		}

		protected override void Reset()
		{
		}

		protected void OnDrawGizmos()
		{
		}

		public override Transform GetAttachTransform(IXRInteractor interactor)
		{
			return null;
		}

		public void RequestTeleport()
		{
		}

		protected override bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
		{
			return false;
		}

		[ContextMenu("Teleport to anchor", false)]
		private void RequestTeleportFromEditor()
		{
		}

		[ContextMenu("Teleport to anchor", true)]
		private bool RequestTeleportFromEditorValidate()
		{
			return false;
		}
	}
}
