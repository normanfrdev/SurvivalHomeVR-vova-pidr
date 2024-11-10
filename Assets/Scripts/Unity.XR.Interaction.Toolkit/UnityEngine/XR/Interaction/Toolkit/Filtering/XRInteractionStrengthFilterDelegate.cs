using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	public sealed class XRInteractionStrengthFilterDelegate : IXRInteractionStrengthFilter
	{
		public Func<IXRInteractor, IXRInteractable, float, float> delegateToProcess
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

		public XRInteractionStrengthFilterDelegate(Func<IXRInteractor, IXRInteractable, float, float> delegateToProcess)
		{
		}

		public float Process(IXRInteractor interactor, IXRInteractable interactable, float interactionStrength)
		{
			return 0f;
		}
	}
}
