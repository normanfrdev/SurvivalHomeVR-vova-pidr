using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit
{
	public abstract class BaseInteractionEventArgs
	{
		public IXRInteractor interactorObject
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

		public IXRInteractable interactableObject
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

		[Obsolete("interactor has been deprecated. Use interactorObject instead.", true)]
		public XRBaseInteractor interactor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("interactable has been deprecated. Use interactableObject instead.", true)]
		public XRBaseInteractable interactable
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
