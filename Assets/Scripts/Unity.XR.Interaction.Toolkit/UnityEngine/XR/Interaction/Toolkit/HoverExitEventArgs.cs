using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit
{
	public class HoverExitEventArgs : BaseInteractionEventArgs
	{
		public new IXRHoverInteractor interactorObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new IXRHoverInteractable interactableObject
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

		public bool isCanceled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
