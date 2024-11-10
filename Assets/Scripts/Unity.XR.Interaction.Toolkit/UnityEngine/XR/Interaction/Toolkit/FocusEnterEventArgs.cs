using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit
{
	public class FocusEnterEventArgs : BaseInteractionEventArgs
	{
		public IXRInteractionGroup interactionGroup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public new IXRFocusInteractable interactableObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInteractionManager manager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
