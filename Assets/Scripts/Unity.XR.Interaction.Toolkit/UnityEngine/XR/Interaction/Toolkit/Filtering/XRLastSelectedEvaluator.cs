using System;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[Serializable]
	public class XRLastSelectedEvaluator : XRTargetEvaluator, IXRTargetEvaluatorLinkable
	{
		private readonly Dictionary<IXRInteractable, float> m_InteractableSelectionTimeMap;

		[Tooltip("Any Interactable which was last selected over Max Time seconds ago will receive a normalized score of 0.")]
		[SerializeField]
		private float m_MaxTime;

		public float maxTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void OnSelect(SelectEnterEventArgs args)
		{
		}

		public virtual void OnLink(IXRInteractor interactor)
		{
		}

		public virtual void OnUnlink(IXRInteractor interactor)
		{
		}

		protected override void OnDisable()
		{
		}

		protected override float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target)
		{
			return 0f;
		}
	}
}
