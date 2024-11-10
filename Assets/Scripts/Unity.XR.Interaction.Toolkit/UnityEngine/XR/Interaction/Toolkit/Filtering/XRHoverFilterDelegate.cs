using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	public sealed class XRHoverFilterDelegate : IXRHoverFilter
	{
		public Func<IXRHoverInteractor, IXRHoverInteractable, bool> delegateToProcess
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

		public XRHoverFilterDelegate(Func<IXRHoverInteractor, IXRHoverInteractable, bool> delegateToProcess)
		{
		}

		public bool Process(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
			return false;
		}
	}
}
