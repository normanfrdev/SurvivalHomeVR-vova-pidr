using System.Diagnostics;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Interactables
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[AddComponentMenu("XR/XR Interactable Snap Volume", 11)]
	[DefaultExecutionOrder(-99)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume.html")]
	public class XRInteractableSnapVolume : MonoBehaviour
	{
		[SerializeField]
		private XRInteractionManager m_InteractionManager;

		[SerializeField]
		[RequireInterface(typeof(IXRInteractable))]
		private Object m_InteractableObject;

		[SerializeField]
		private Collider m_SnapCollider;

		[SerializeField]
		private bool m_DisableSnapColliderWhenSelected;

		[SerializeField]
		private Collider m_SnapToCollider;

		private IXRInteractable m_Interactable;

		private IXRInteractable m_BoundInteractable;

		private IXRSelectInteractable m_BoundSelectInteractable;

		private XRInteractionManager m_RegisteredInteractionManager;

		public XRInteractionManager interactionManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Object interactableObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Collider snapCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool disableSnapColliderWhenSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Collider snapToCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IXRInteractable interactable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Conditional("UNITY_EDITOR")]
		protected virtual void Reset()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void FindCreateInteractionManager()
		{
		}

		private void RegisterWithInteractionManager()
		{
		}

		private void UnregisterWithInteractionManager()
		{
		}

		protected static Collider FindSnapCollider(GameObject gameObject)
		{
			return null;
		}

		internal static bool SupportsTriggerCollider(Collider col)
		{
			return false;
		}

		private void ValidateSnapCollider()
		{
		}

		private void SetSnapColliderEnabled(bool enable)
		{
		}

		public Vector3 GetClosestPoint(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector3 GetClosestPointOfAttachTransform(IXRInteractor interactor)
		{
			return default(Vector3);
		}

		private void SetBoundInteractable(IXRInteractable source)
		{
		}

		private void RefreshSnapColliderEnabled()
		{
		}

		private void OnFirstSelectEntered(SelectEnterEventArgs args)
		{
		}

		private void OnLastSelectExited(SelectExitEventArgs args)
		{
		}
	}
}
