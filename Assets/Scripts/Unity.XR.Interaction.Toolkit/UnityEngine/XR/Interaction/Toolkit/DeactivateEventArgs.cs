using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit
{
	public class DeactivateEventArgs : BaseInteractionEventArgs
	{
		public new IXRActivateInteractor interactorObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new IXRActivateInteractable interactableObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
