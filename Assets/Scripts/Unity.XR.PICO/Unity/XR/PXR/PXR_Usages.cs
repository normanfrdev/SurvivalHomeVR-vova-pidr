using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	public static class PXR_Usages
	{
		public static InputFeatureUsage<Vector3> combineEyePoint;

		public static InputFeatureUsage<Vector3> combineEyeVector;

		public static InputFeatureUsage<Vector3> leftEyePoint;

		public static InputFeatureUsage<Vector3> leftEyeVector;

		public static InputFeatureUsage<Vector3> rightEyePoint;

		public static InputFeatureUsage<Vector3> rightEyeVector;

		public static InputFeatureUsage<float> leftEyeOpenness;

		public static InputFeatureUsage<float> rightEyeOpenness;

		public static InputFeatureUsage<uint> leftEyePoseStatus;

		public static InputFeatureUsage<uint> rightEyePoseStatus;

		public static InputFeatureUsage<uint> combinedEyePoseStatus;

		public static InputFeatureUsage<float> leftEyePupilDilation;

		public static InputFeatureUsage<float> rightEyePupilDilation;

		public static InputFeatureUsage<Vector3> leftEyePositionGuide;

		public static InputFeatureUsage<Vector3> rightEyePositionGuide;

		public static InputFeatureUsage<Vector3> foveatedGazeDirection;

		public static InputFeatureUsage<uint> foveatedGazeTrackingState;

		public static InputFeatureUsage<bool> triggerTouch;

		public static InputFeatureUsage<float> grip1DAxis;

		public static InputFeatureUsage<bool> controllerStatus;
	}
}
