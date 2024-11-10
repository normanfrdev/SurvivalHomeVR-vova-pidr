using System;

namespace Unity.XR.PXR
{
	public class PXR_MotionTracking
	{
		public const int PXR_EYE_TRACKING_API_VERSION = 1;

		public const int PXR_FACE_TRACKING_API_VERSION = 1;

		public const int PXR_BODY_TRACKING_API_VERSION = 1;

		public static Action<int, int> BodyTrackingAbnormalCalibrationData;

		public static Action<BodyTrackingStatusCode, BodyTrackingErrorCode> BodyTrackingStateError;

		public static Action<int, BodyActionList> BodyTrackingAction;

		public static Action<int, int> MotionTrackerNumberOfConnections;

		public static Action<int, int> MotionTrackerBatteryLevel;

		public static Action<MotionTrackerEventData> MotionTrackerKeyAction;

		public static Action<MotionTrackerMode> MotionTrackingModeChangedAction;

		public static Action<ExtDevConnectEventData> ExtDevConnectAction;

		public static Action<ExtDevBatteryEventData> ExtDevBatteryAction;

		public static Action<int> ExtDevPassDataAction;

		public static int WantEyeTrackingService()
		{
			return 0;
		}

		public static int GetEyeTrackingSupported(ref bool supported, ref int supportedModesCount, ref EyeTrackingMode[] supportedModes)
		{
			return 0;
		}

		public static int StartEyeTracking(ref EyeTrackingStartInfo startInfo)
		{
			return 0;
		}

		public static int StopEyeTracking(ref EyeTrackingStopInfo stopInfo)
		{
			return 0;
		}

		public static int GetEyeTrackingState(ref bool isTracking, ref EyeTrackingState state)
		{
			return 0;
		}

		public static int GetEyeTrackingData(ref EyeTrackingDataGetInfo getInfo, ref EyeTrackingData data)
		{
			return 0;
		}

		public static int GetEyeOpenness(ref float leftEyeOpenness, ref float rightEyeOpenness)
		{
			return 0;
		}

		public static int GetEyePupilInfo(ref EyePupilInfo eyePupilPosition)
		{
			return 0;
		}

		public static int GetPerEyePose(ref long timestamp, ref Posef leftEyePose, ref Posef rightPose)
		{
			return 0;
		}

		public static int GetEyeBlink(ref long timestamp, ref bool isLeftBlink, ref bool isRightBlink)
		{
			return 0;
		}

		public static int WantFaceTrackingService()
		{
			return 0;
		}

		public static int GetFaceTrackingSupported(ref bool supported, ref int supportedModesCount, ref FaceTrackingMode[] supportedModes)
		{
			return 0;
		}

		public static int StartFaceTracking(ref FaceTrackingStartInfo startInfo)
		{
			return 0;
		}

		public static int StopFaceTracking(ref FaceTrackingStopInfo stopInfo)
		{
			return 0;
		}

		public static int GetFaceTrackingState(ref bool isTracking, ref FaceTrackingState state)
		{
			return 0;
		}

		public static int GetFaceTrackingData(ref FaceTrackingDataGetInfo getInfo, ref FaceTrackingData data)
		{
			return 0;
		}

		public static int StartMotionTrackerCalibApp()
		{
			return 0;
		}

		public static int GetBodyTrackingSupported(ref bool supported)
		{
			return 0;
		}

		public static int StartBodyTracking(BodyTrackingMode mode, BodyTrackingBoneLength boneLength)
		{
			return 0;
		}

		public static int StopBodyTracking()
		{
			return 0;
		}

		public static int GetBodyTrackingState(ref bool isTracking, ref BodyTrackingState state)
		{
			return 0;
		}

		public static int GetBodyTrackingData(ref BodyTrackingGetDataInfo getInfo, ref BodyTrackingData data)
		{
			return 0;
		}

		public static int GetMotionTrackerConnectStateWithSN(ref MotionTrackerConnectState connectState)
		{
			return 0;
		}

		public static MotionTrackerType GetMotionTrackerDeviceType()
		{
			return default(MotionTrackerType);
		}

		public static int CheckMotionTrackerModeAndNumber(MotionTrackerMode mode, MotionTrackerNum number = MotionTrackerNum.NONE)
		{
			return 0;
		}

		public static MotionTrackerMode GetMotionTrackerMode()
		{
			return default(MotionTrackerMode);
		}

		public static int GetMotionTrackerLocations(TrackerSN trackerSN, ref MotionTrackerLocations locations, ref MotionTrackerConfidence confidence, double predictTime = 0.0)
		{
			return 0;
		}

		public static int GetExtDevTrackerConnectState(ref ExtDevTrackerConnectState connectState)
		{
			return 0;
		}

		public static int SetExtDevTrackerMotorVibrate(ref ExtDevTrackerMotorVibrate motorVibrate)
		{
			return 0;
		}

		public static int SetExtDevTrackerPassDataState(bool state)
		{
			return 0;
		}

		public static int SetExtDevTrackerByPassData(ref ExtDevTrackerPassData passData)
		{
			return 0;
		}

		public static int GetExtDevTrackerByPassData(ref ExtDevTrackerPassDataArray passData, ref int realLength)
		{
			return 0;
		}

		public static int GetExtDevTrackerBattery(ref TrackerSN trackerSN, ref int battery, ref int charger)
		{
			return 0;
		}

		public static int GetExtDevTrackerKeyData(ref TrackerSN trackerSN, ref ExtDevTrackerKeyData keyData)
		{
			return 0;
		}
	}
}
