using System;
using UnityEngine;

namespace Unity.XR.PXR
{
	public static class PXR_Input
	{
		public enum ControllerDevice
		{
			G2 = 3,
			Neo2 = 4,
			Neo3 = 5,
			PICO_4 = 6,
			G3 = 7,
			PICO_4U = 8,
			NewController = 10
		}

		public enum Controller
		{
			LeftController = 0,
			RightController = 1
		}

		public enum VibrateController
		{
			No = 0,
			Left = 1,
			Right = 2,
			LeftAndRight = 3
		}

		public enum VibrateType
		{
			None = 0,
			LeftController = 1,
			RightController = 2,
			BothController = 3,
			LeftPICO4U = 4,
			RightPICO4U = 8,
			BothPICO4U = 12
		}

		public enum CacheType
		{
			DontCache = 0,
			CacheAndVibrate = 1,
			CacheNoVibrate = 2
		}

		public enum ChannelFlip
		{
			No = 0,
			Yes = 1
		}

		public enum CacheConfig
		{
			CacheAndVibrate = 1,
			CacheNoVibrate = 2
		}

		public static Controller GetDominantHand()
		{
			return default(Controller);
		}

		public static void SetDominantHand(Controller controller)
		{
		}

		[Obsolete("Please use SendHapticImpulse instead")]
		public static void SetControllerVibration(float strength, int time, Controller controller)
		{
		}

		public static ControllerDevice GetControllerDeviceType()
		{
			return default(ControllerDevice);
		}

		public static bool IsControllerConnected(Controller controller)
		{
			return false;
		}

		public static void SetControllerOriginOffset(Controller controller, Vector3 offset)
		{
		}

		public static Quaternion GetControllerPredictRotation(Controller controller, double predictTime)
		{
			return default(Quaternion);
		}

		public static Vector3 GetControllerPredictPosition(Controller controller, double predictTime)
		{
			return default(Vector3);
		}

		[Obsolete("Please use SendHapticImpulse instead")]
		public static int SetControllerVibrationEvent(uint hand, int frequency, float strength, int time)
		{
			return 0;
		}

		[Obsolete("Please use StopHapticBuffer instead")]
		public static int StopControllerVCMotor(int sourceId)
		{
			return 0;
		}

		[Obsolete("Deprecated")]
		public static int StartControllerVCMotor(string file, VibrateController vibrateController)
		{
			return 0;
		}

		[Obsolete("Deprecated")]
		public static int SetControllerAmp(float mode)
		{
			return 0;
		}

		[Obsolete("Please use SendHapticBuffer instead")]
		public static int StartVibrateBySharem(AudioClip audioClip, VibrateController vibrateController, ChannelFlip channelFlip, ref int sourceId)
		{
			return 0;
		}

		[Obsolete("Please use SendHapticBuffer instead")]
		public static int StartVibrateBySharem(float[] data, VibrateController vibrateController, int buffersize, int frequency, int channelMask, ChannelFlip channelFlip, ref int sourceId)
		{
			return 0;
		}

		[Obsolete("Please use SendHapticBuffer instead")]
		public static int SaveVibrateByCache(AudioClip audioClip, VibrateController vibrateController, ChannelFlip channelFlip, CacheConfig cacheConfig, ref int sourceId)
		{
			return 0;
		}

		[Obsolete("Please use SendHapticBuffer instead")]
		public static int SaveVibrateByCache(float[] data, VibrateController vibrateController, int buffersize, int frequency, int channelMask, ChannelFlip channelFlip, CacheConfig cacheConfig, ref int sourceId)
		{
			return 0;
		}

		[Obsolete("Please use StartHapticBuffer instead")]
		public static int StartVibrateByCache(int sourceId)
		{
			return 0;
		}

		[Obsolete("Please use StopHapticBuffer(clearCache) instead")]
		public static int ClearVibrateByCache(int sourceId)
		{
			return 0;
		}

		public static int SetControllerEnableKey(bool isEnable, PxrControllerKeyMap Key)
		{
			return 0;
		}

		[Obsolete("Please use SendHapticBuffer instead")]
		public static int StartVibrateByPHF(TextAsset phfText, ref int sourceId, VibrateController vibrateController, ChannelFlip channelFlip, float amp)
		{
			return 0;
		}

		[Obsolete("Please use PauseHapticBuffer instead")]
		public static int PauseVibrate(int sourceId)
		{
			return 0;
		}

		[Obsolete("Please use ResumeHapticBuffer instead")]
		public static int ResumeVibrate(int sourceId)
		{
			return 0;
		}

		[Obsolete("Please use UpdateHapticBuffer instead")]
		public static int UpdateVibrateParams(int sourceId, VibrateController vibrateController, ChannelFlip channelFlip, float amp)
		{
			return 0;
		}

		public static int GetBodyTrackingPose(double predictTime, ref BodyTrackerResult bodyTrackerResult)
		{
			return 0;
		}

		public static int GetMotionTrackerConnectStateWithID(ref PxrMotionTracker1ConnectState state)
		{
			return 0;
		}

		public static int GetMotionTrackerBattery(int trackerId, ref int battery)
		{
			return 0;
		}

		public static int GetMotionTrackerCalibState(ref int calibrated)
		{
			return 0;
		}

		public static int SetBodyTrackingMode(BodyTrackingMode mode)
		{
			return 0;
		}

		public static int SetBodyTrackingBoneLength(BodyTrackingBoneLength boneLength)
		{
			return 0;
		}

		public static void SendHapticImpulse(VibrateType vibrateType, float amplitude, int duration, int frequency = 150)
		{
		}

		public static int SendHapticBuffer(VibrateType vibrateType, AudioClip audioClip, ChannelFlip channelFlip, ref int sourceId, CacheType cacheType = CacheType.DontCache)
		{
			return 0;
		}

		public static int SendHapticBuffer(VibrateType vibrateType, float[] pcmData, int buffersize, int frequency, int channelMask, ChannelFlip channelFlip, ref int sourceId, CacheType cacheType = CacheType.DontCache)
		{
			return 0;
		}

		public static int SendHapticBuffer(VibrateType vibrateType, TextAsset phfText, ChannelFlip channelFlip, float amplitudeScale, ref int sourceId)
		{
			return 0;
		}

		public static int StopHapticBuffer(int sourceId = 0, bool clearCache = false)
		{
			return 0;
		}

		public static int PauseHapticBuffer(int sourceId)
		{
			return 0;
		}

		public static int ResumeHapticBuffer(int sourceId)
		{
			return 0;
		}

		public static int StartHapticBuffer(int sourceId)
		{
			return 0;
		}

		public static int UpdateHapticBuffer(int sourceId, VibrateType vibrateType, ChannelFlip channelFlip, float amplitudeScale)
		{
			return 0;
		}

		public static int CreateHapticStream(string phfVersion, uint frameDurationMs, ref VibrateInfo hapticInfo, float speed, ref int id)
		{
			return 0;
		}

		public static int WriteHapticStream(int id, ref PxrPhfParamsNum frames, uint numFrames)
		{
			return 0;
		}

		public static int SetHapticStreamSpeed(int id, float speed)
		{
			return 0;
		}

		public static int GetHapticStreamSpeed(int id, ref float speed)
		{
			return 0;
		}

		public static int GetHapticStreamCurrentFrameSequence(int id, ref ulong frameSequence)
		{
			return 0;
		}

		public static int StartHapticStream(int source_id)
		{
			return 0;
		}

		public static int StopHapticStream(int source_id)
		{
			return 0;
		}

		public static int RemoveHapticStream(int source_id)
		{
			return 0;
		}

		public static PxrPhfFile AnalysisHapticStreamPHF(TextAsset phfText)
		{
			return default(PxrPhfFile);
		}

		public static void ResetController()
		{
		}

		public static void SetArmModelParameters(PxrGazeType gazetype, PxrArmModelType armmodeltype, float elbowHeight, float elbowDepth, float pointerTiltAngle)
		{
		}

		public static void GetControllerHandness(ref int deviceID)
		{
		}
	}
}
