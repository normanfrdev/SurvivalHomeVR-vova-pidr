using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	public sealed class XRSelectFilterDelegate : IXRSelectFilter
	{
		public Func<IXRSelectInteractor, IXRSelectInteractable, bool> delegateToProcess
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

		public bool canProcess
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

		public XRSelectFilterDelegate(Func<IXRSelectInteractor, IXRSelectInteractable, bool> delegateToProcess)
		{
		}

		public bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
			return false;
		}
	}
}
