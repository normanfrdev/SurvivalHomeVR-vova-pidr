using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Transformers
{
	public abstract class XRBaseGrabTransformer : MonoBehaviour, IXRGrabTransformer
	{
		public enum RegistrationMode
		{
			None = 0,
			Single = 1,
			Multiple = 2,
			SingleAndMultiple = 3
		}

		public virtual bool canProcess => false;

		protected virtual RegistrationMode registrationMode => default(RegistrationMode);

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void OnLink(XRGrabInteractable grabInteractable)
		{
		}

		public virtual void OnGrab(XRGrabInteractable grabInteractable)
		{
		}

		public virtual void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale)
		{
		}

		public abstract void Process(XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale);

		public virtual void OnUnlink(XRGrabInteractable grabInteractable)
		{
		}
	}
}
