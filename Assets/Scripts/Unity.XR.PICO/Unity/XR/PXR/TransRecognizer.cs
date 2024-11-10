using System;

namespace Unity.XR.PXR
{
	[Serializable]
	public class TransRecognizer
	{
		public enum SpaceType
		{
			WorldSpace = 0,
			LocalXY = 1,
			LocalYZ = 2,
			LocalXZ = 3
		}

		public enum TrackAxis
		{
			Fingers = 0,
			Palm = 1,
			Thumb = 2
		}

		public enum TrackTarget
		{
			TowardsFace = 0,
			AwayFromFace = 1,
			WorldUp = 2,
			WorldDown = 3
		}

		public TrackAxis trackAxis;

		public SpaceType spaceType;

		public TrackTarget trackTarget;

		public float angleThreshold;

		public float thresholdWidth;

		public float holdDuration;
	}
}
