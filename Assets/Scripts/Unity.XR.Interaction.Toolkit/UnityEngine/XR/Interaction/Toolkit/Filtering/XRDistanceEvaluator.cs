using System;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[Serializable]
	public class XRDistanceEvaluator : XRTargetEvaluator
	{
		[Tooltip("The maximum distance from the Interactor. Any target from this distance will receive a 0 normalized score.")]
		[SerializeField]
		private float m_MaxDistance;

		public float maxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Reset()
		{
		}

		protected override float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target)
		{
			return 0f;
		}
	}
}
