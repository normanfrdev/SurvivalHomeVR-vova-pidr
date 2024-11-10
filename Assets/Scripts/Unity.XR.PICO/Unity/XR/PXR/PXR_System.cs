namespace Unity.XR.PXR
{
	public class PXR_System
	{
		public static string GetSDKVersion()
		{
			return null;
		}

		public static double GetPredictedDisplayTime()
		{
			return 0.0;
		}

		public static bool SetExtraLatencyMode(int mode)
		{
			return false;
		}

		public static int GetSensorStatus()
		{
			return 0;
		}

		public static void SetSystemDisplayFrequency(float rate)
		{
		}

		public static float GetSystemDisplayFrequency()
		{
			return 0f;
		}

		public static int GetPredictedMainSensorStateNew(ref PxrSensorState2 sensorState, ref int sensorFrameIndex)
		{
			return 0;
		}

		public static int ContentProtect(int data)
		{
			return 0;
		}

		public static void EnableFaceTracking(bool enable)
		{
		}

		public static void EnableLipSync(bool enable)
		{
		}

		public static void GetFaceTrackingData(long ts, GetDataType flags, ref PxrFaceTrackingInfo faceTrackingInfo)
		{
		}

		public static int SetPerformanceLevels(PxrPerfSettings which, PxrSettingsLevel level)
		{
			return 0;
		}

		public static PxrSettingsLevel GetPerformanceLevels(PxrPerfSettings which)
		{
			return default(PxrSettingsLevel);
		}

		public static int SetEyeFOV(EyeType eye, float fovLeft, float fovRight, float fovUp, float fovDown)
		{
			return 0;
		}

		public static int SetFaceTrackingStatus(PxrFtLipsyncValue value)
		{
			return 0;
		}

		public static void SetTrackingOrigin(PxrTrackingOrigin originMode)
		{
		}

		public static void GetTrackingOrigin(out PxrTrackingOrigin originMode)
		{
			originMode = default(PxrTrackingOrigin);
		}

		public static bool StartBatteryReceiver(string objName)
		{
			return false;
		}

		public static bool StopBatteryReceiver()
		{
			return false;
		}

		public static bool SetCommonBrightness(int brightness)
		{
			return false;
		}

		public static int GetCommonBrightness()
		{
			return 0;
		}

		public static int[] GetScreenBrightnessLevel()
		{
			return null;
		}

		public static void SetScreenBrightnessLevel(int brightness, int level)
		{
		}

		public static bool StartAudioReceiver(string objName)
		{
			return false;
		}

		public static bool StopAudioReceiver()
		{
			return false;
		}

		public static int GetMaxVolumeNumber()
		{
			return 0;
		}

		public static int GetCurrentVolumeNumber()
		{
			return 0;
		}

		public static bool VolumeUp()
		{
			return false;
		}

		public static bool VolumeDown()
		{
			return false;
		}

		public static bool SetVolumeNum(int volume)
		{
			return false;
		}

		public static string GetProductName()
		{
			return null;
		}
	}
}
