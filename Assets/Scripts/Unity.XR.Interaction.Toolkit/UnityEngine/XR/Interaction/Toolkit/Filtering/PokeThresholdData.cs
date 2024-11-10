using System;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[Serializable]
	public class PokeThresholdData
	{
		[SerializeField]
		[Tooltip("The axis along which the poke interaction will be constrained.")]
		private PokeAxis m_PokeDirection;

		[SerializeField]
		[Tooltip("Distance along the poke interactable interaction axis that allows for a poke to be triggered sooner/with less precision.")]
		private float m_InteractionDepthOffset;

		[SerializeField]
		[Tooltip("When enabled, the filter will check that a poke action is started and moves within the poke angle threshold along the poke direction axis.")]
		private bool m_EnablePokeAngleThreshold;

		[SerializeField]
		[Tooltip("The maximum allowed angle (in degrees) from the poke direction axis that will trigger a select interaction.")]
		[Range(0f, 89.9f)]
		private float m_PokeAngleThreshold;

		public PokeAxis pokeDirection
		{
			get
			{
				return default(PokeAxis);
			}
			set
			{
			}
		}

		public float interactionDepthOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enablePokeAngleThreshold
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float pokeAngleThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float GetSelectEntranceVectorDotThreshold()
		{
			return 0f;
		}
	}
}
