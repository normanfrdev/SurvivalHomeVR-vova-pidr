using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing
{
	[Serializable]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class ClimbSettings
	{
		[SerializeField]
		[Tooltip("Controls whether to allow unconstrained movement along the climb interactable's x-axis.")]
		private bool m_AllowFreeXMovement;

		[SerializeField]
		[Tooltip("Controls whether to allow unconstrained movement along the climb interactable's y-axis.")]
		private bool m_AllowFreeYMovement;

		[SerializeField]
		[Tooltip("Controls whether to allow unconstrained movement along the climb interactable's z-axis.")]
		private bool m_AllowFreeZMovement;

		public bool allowFreeXMovement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowFreeYMovement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowFreeZMovement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
