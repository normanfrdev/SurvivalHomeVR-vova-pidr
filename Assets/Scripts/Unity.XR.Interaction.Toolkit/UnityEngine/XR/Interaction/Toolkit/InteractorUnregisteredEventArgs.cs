using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit
{
	public class InteractorUnregisteredEventArgs : BaseRegistrationEventArgs
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
	}
}
