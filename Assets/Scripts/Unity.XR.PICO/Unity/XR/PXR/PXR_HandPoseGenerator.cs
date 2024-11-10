using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.PXR
{
	public class PXR_HandPoseGenerator : MonoBehaviour
	{
		public PXR_HandPoseConfig config;

		public PXR_HandPosePreview preview;

		public ShapesRecognizer.Finger thumb;

		public ShapesRecognizer.Finger index;

		public ShapesRecognizer.Finger middle;

		public ShapesRecognizer.Finger ring;

		public ShapesRecognizer.Finger pinky;

		public float shapesholdDuration;

		public List<BonesRecognizer.BonesGroup> Bones;

		public float bonesHoldDuration;

		public TransRecognizer.TrackAxis trackAxis;

		public TransRecognizer.SpaceType spaceType;

		public TransRecognizer.TrackTarget trackTarget;

		public float angleThreshold;

		public float thresholdWidth;

		public float transHoldDuration;
	}
}
