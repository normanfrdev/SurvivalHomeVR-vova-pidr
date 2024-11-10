using System;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[Serializable]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TeleportVolumeDestinationSettings
	{
		[SerializeField]
		[Tooltip("Whether to delay evaluation of the destination anchor until the user has hovered over the volume for a certain amount of time.")]
		private bool m_EnableDestinationEvaluationDelay;

		[SerializeField]
		[Tooltip("The amount of time, in seconds, for which the user must hover over the volume before it designates a destination anchor.")]
		private float m_DestinationEvaluationDelayTime;

		[SerializeField]
		[Tooltip("Whether to periodically query the filter for its calculated destination. If the determined anchor is not the current destination, the volume will initiate re-evaluation of the destination anchor.")]
		private bool m_PollForDestinationChange;

		[SerializeField]
		[Tooltip("The amount of time, in seconds, between queries to the filter for its calculated destination anchor.")]
		private float m_DestinationPollFrequency;

		[SerializeField]
		[RequireInterface(typeof(ITeleportationVolumeAnchorFilter))]
		[Tooltip("The anchor filter used to evaluate a teleportation destination. If set to None, the volume will use the anchor furthest from the user as the destination.")]
		private Object m_DestinationFilterObject;

		private ITeleportationVolumeAnchorFilter m_DestinationEvaluationFilter;

		[NonSerialized]
		private bool m_AssignedFilter;

		public bool enableDestinationEvaluationDelay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float destinationEvaluationDelayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool pollForDestinationChange
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float destinationPollFrequency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Object destinationFilterObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ITeleportationVolumeAnchorFilter destinationEvaluationFilter
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
