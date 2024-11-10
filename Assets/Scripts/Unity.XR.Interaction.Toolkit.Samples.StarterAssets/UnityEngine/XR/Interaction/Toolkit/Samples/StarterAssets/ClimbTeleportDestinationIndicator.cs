using UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	public class ClimbTeleportDestinationIndicator : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The interactor that drives the display and placement of the pointer object.")]
		private ClimbTeleportInteractor m_ClimbTeleportInteractor;

		[SerializeField]
		[Tooltip("The prefab to spawn when a teleport destination is chosen. The instance will spawn next to the destination and point its forward vector at the destination and its up vector at the camera.")]
		private GameObject m_PointerPrefab;

		[SerializeField]
		[Tooltip("The distance from the destination at which the pointer object spawns.")]
		private float m_PointerDistance;

		private TeleportationMultiAnchorVolume m_ActiveTeleportVolume;

		private Transform m_PointerInstance;

		public ClimbTeleportInteractor climbTeleportInteractor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject pointerPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float pointerDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private void OnInteractorHoverEntered(HoverEnterEventArgs args)
		{
		}

		private void OnInteractorHoverExited(HoverExitEventArgs args)
		{
		}

		private void OnClimbTeleportDestinationAnchorChanged(TeleportationMultiAnchorVolume teleportVolume)
		{
		}

		private void HideIndicator()
		{
		}
	}
}
