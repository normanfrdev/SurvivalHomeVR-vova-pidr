using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[CreateAssetMenu(fileName = "GazeTeleportationAnchorFilter", menuName = "XR/Locomotion/Gaze Teleportation Anchor Filter")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class GazeTeleportationAnchorFilter : ScriptableObject, ITeleportationVolumeAnchorFilter
	{
		[SerializeField]
		[Range(0f, 180f)]
		[Tooltip("The maximum angle (in degrees) between the camera forward and the direction from the camera to an anchor for the anchor to be considered a valid destination.")]
		private float m_MaxGazeAngle;

		[SerializeField]
		[Tooltip("The curve used to score an anchor by its angle from the camera forward. The X axis is the normalized angle, where 0 is 0 degrees and 1 is the Max Gaze Angle. The Y axis is the score, where a higher value means a better destination.")]
		private AnimationCurve m_GazeAngleScoreCurve;

		[SerializeField]
		[Tooltip("Whether to weight an anchor's score by its distance from the user.")]
		private bool m_EnableDistanceWeighting;

		[SerializeField]
		[Tooltip("The curve used to weight an anchor's score by its distance from the user. The X axis is the normalized distance, where 0 is the closest anchor and 1 is the furthest anchor. The Y axis is the weight.")]
		private AnimationCurve m_DistanceWeightCurve;

		private float[] m_AnchorWeights;

		public float maxGazeAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve gazeAngleScoreCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enableDistanceWeighting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AnimationCurve distanceWeightCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void Reset()
		{
		}

		public int GetDestinationAnchorIndex(TeleportationMultiAnchorVolume teleportationVolume)
		{
			return 0;
		}
	}
}
