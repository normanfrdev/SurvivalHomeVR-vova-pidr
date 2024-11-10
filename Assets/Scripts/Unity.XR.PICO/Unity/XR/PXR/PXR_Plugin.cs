using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.XR.PXR
{
	public static class PXR_Plugin
	{
		public static class System
		{
			public static Action RecenterSuccess;

			public static Action FocusStateAcquired;

			public static Action FocusStateLost;

			public static Action SensorReady;

			public static Action<int> SessionStateChanged;

			public static Action<int> InputDeviceChanged;

			public static Action<float> DisplayRefreshRateChangedAction;

			public static string ProductName;

			private static bool lastAppFocusState;

			private static bool lastSensorReadyState;

			private const string TAG = "[PXR_Plugin/System]";

			private static bool isInitAudio;

			public static float UPxr_VstModelOffset()
			{
				return 0f;
			}

			public static void UPxr_SetTrackingOrigin(PxrTrackingOrigin mode)
			{
			}

			public static void UPxr_GetTrackingOrigin(ref PxrTrackingOrigin mode)
			{
			}

			public static bool UPxr_LoadPICOPlugin()
			{
				return false;
			}

			public static void UPxr_UnloadPICOPlugin()
			{
			}

			public static bool UPxr_QueryDeviceAbilities(PxrDeviceAbilities abilities)
			{
				return false;
			}

			public static void UPxr_InitializeFocusCallback()
			{
			}

			public static void UPxr_DeinitializeFocusCallback()
			{
			}

			public static void UPxr_SetEventDataBufferCallBack(EventDataBufferCallBack callback)
			{
			}

			public static bool UPxr_GetFocusState()
			{
				return false;
			}

			public static bool UPxr_IsSensorReady()
			{
				return false;
			}

			private static void UPxr_FocusUpdate()
			{
			}

			private static void UPxr_SensorReadyStateUpdate()
			{
			}

			public static string UPxr_GetSDKVersion()
			{
				return null;
			}

			public static int UPxr_LogSdkApi(string sdkInfo)
			{
				return 0;
			}

			public static float UPxr_GetSystemDisplayFrequency()
			{
				return 0f;
			}

			public static double UPxr_GetPredictedDisplayTime()
			{
				return 0.0;
			}

			public static bool UPxr_SetExtraLatencyMode(int mode)
			{
				return false;
			}

			public static int UPxr_UpdateAdaptiveResolution(ref int width, AdaptiveResolutionPowerSetting powerSetting)
			{
				return 0;
			}

			public static void UPxr_SetUserDefinedSettings(UserDefinedSettings settings)
			{
			}

			public static void UPxr_Construct(PXR_Loader.ConvertRotationWith2VectorDelegate fromToRotation)
			{
			}

			public static bool UPxr_GetHomeKey()
			{
				return false;
			}

			public static void UPxr_InitHomeKey()
			{
			}

			public static bool UPxr_GetMRCEnable()
			{
				return false;
			}

			public static int UPxr_GetExternalCameraInfo(out ExternalCameraInfo cameraInfo)
			{
				cameraInfo = default(ExternalCameraInfo);
				return 0;
			}

			public static int UPxr_GetExternalCameraPose(PxrTrackingOrigin pxrTrackingOrigin, ref PxrPosef outPose)
			{
				return 0;
			}

			public static void UPxr_EnableEyeTracking(bool enable)
			{
			}

			public static void UPxr_EnableFaceTracking(bool enable)
			{
			}

			public static void UPxr_EnableLipSync(bool enable)
			{
			}

			public static int UPxr_GetFaceTrackingData(long ts, int flags, ref PxrFaceTrackingInfo faceTrackingInfo)
			{
				return 0;
			}

			public static int UPxr_SetFaceTrackingStatus(PxrFtLipsyncValue value)
			{
				return 0;
			}

			public static bool UPxr_StopBatteryReceiver()
			{
				return false;
			}

			public static bool UPxr_StartBatteryReceiver(string objName)
			{
				return false;
			}

			public static bool UPxr_InitAudioDevice()
			{
				return false;
			}

			public static bool UPxr_SetBrightness(int brightness)
			{
				return false;
			}

			public static int UPxr_GetCurrentBrightness()
			{
				return 0;
			}

			public static int[] UPxr_GetScreenBrightnessLevel()
			{
				return null;
			}

			public static void UPxr_SetScreenBrightnessLevel(int vrBrightness, int level)
			{
			}

			public static bool UPxr_StartAudioReceiver(string startreceivre)
			{
				return false;
			}

			public static bool UPxr_StopAudioReceiver()
			{
				return false;
			}

			public static int UPxr_GetMaxVolumeNumber()
			{
				return 0;
			}

			public static int UPxr_GetCurrentVolumeNumber()
			{
				return 0;
			}

			public static bool UPxr_VolumeUp()
			{
				return false;
			}

			public static bool UPxr_VolumeDown()
			{
				return false;
			}

			public static bool UPxr_SetVolumeNum(int volume)
			{
				return false;
			}

			public static string UPxr_GetDeviceMode()
			{
				return null;
			}

			public static string UPxr_GetProductName()
			{
				return null;
			}

			public static float UPxr_GetConfigFloat(ConfigType type)
			{
				return 0f;
			}

			public static int UPxr_GetConfigInt(ConfigType type)
			{
				return 0;
			}

			public static int UPxr_SetConfigInt(ConfigType configSetIndex, int configSetData)
			{
				return 0;
			}

			public static int UPxr_ContentProtect(int data)
			{
				return 0;
			}

			public static int UPxr_SetConfigString(ConfigType configSetIndex, string configSetData)
			{
				return 0;
			}

			public static int UPxr_SetSystemDisplayFrequency(float rate)
			{
				return 0;
			}

			public static int UPxr_SetPerformanceLevels(PxrPerfSettings which, PxrSettingsLevel level)
			{
				return 0;
			}

			public static PxrSettingsLevel UPxr_GetPerformanceLevels(PxrPerfSettings which)
			{
				return default(PxrSettingsLevel);
			}

			public static string UPxr_GetDeviceSN()
			{
				return null;
			}

			public static void UPxr_Sleep()
			{
			}

			public static void UPxr_SetSecure(bool isOpen)
			{
			}

			public static int UPxr_GetColorRes(string name)
			{
				return 0;
			}

			public static int UPxr_GetConfigInt(string name)
			{
				return 0;
			}

			public static string UPxr_GetConfigString(string name)
			{
				return null;
			}

			public static string UPxr_GetDrawableLocation(string name)
			{
				return null;
			}

			public static int UPxr_GetTextSize(string name)
			{
				return 0;
			}

			public static string UPxr_GetLangString(string name)
			{
				return null;
			}

			public static string UPxr_GetStringValue(string id, int type)
			{
				return null;
			}

			public static int UPxr_GetIntValue(string id, int type)
			{
				return 0;
			}

			public static float UPxr_GetFloatValue(string id)
			{
				return 0f;
			}

			public static string UPxr_GetObjectOrArray(string id, int type)
			{
				return null;
			}

			public static int UPxr_GetCharSpace(string id)
			{
				return 0;
			}

			public static float[] UPxr_GetDisplayFrequenciesAvailable()
			{
				return null;
			}

			public static int UPxr_GetSensorStatus()
			{
				return 0;
			}

			public static int UPxr_GetPredictedMainSensorStateNew(ref PxrSensorState2 sensorState, ref int sensorFrameIndex)
			{
				return 0;
			}

			public static int UPxr_GetAPIVersion()
			{
				return 0;
			}

			public static void UPxr_SetLogInfoActive(bool value)
			{
			}

			public static void UPxr_OpenPackage(string pkgName)
			{
			}
		}

		public static class Boundary
		{
			private const string TAG = "[PXR_Plugin/Boundary]";

			public static int seeThroughState;

			public static Action<int> SeethroughStateChangedAction;

			public static PxrBoundaryTriggerInfo UPxr_TestNodeIsInBoundary(BoundaryTrackingNode node, BoundaryType boundaryType)
			{
				return default(PxrBoundaryTriggerInfo);
			}

			public static PxrBoundaryTriggerInfo UPxr_TestPointIsInBoundary(PxrVector3f point, BoundaryType boundaryType)
			{
				return default(PxrBoundaryTriggerInfo);
			}

			public static Vector3[] UPxr_GetBoundaryGeometry(BoundaryType boundaryType)
			{
				return null;
			}

			public static Vector3 UPxr_GetBoundaryDimensions(BoundaryType boundaryType)
			{
				return default(Vector3);
			}

			public static void UPxr_SetBoundaryVisiable(bool value)
			{
			}

			public static bool UPxr_GetBoundaryVisiable()
			{
				return false;
			}

			public static bool UPxr_GetBoundaryConfigured()
			{
				return false;
			}

			public static bool UPxr_GetBoundaryEnabled()
			{
				return false;
			}

			public static int UPxr_SetSeeThroughBackground(bool value)
			{
				return 0;
			}

			public static void UPxr_SetSeeThroughState(bool value)
			{
			}

			public static void UPxr_ResetSeeThroughSensor()
			{
			}

			public static PxrTrackingState UPxr_GetSeeThroughTrackingState()
			{
				return default(PxrTrackingState);
			}

			public static int UPxr_SetGuardianSystemDisable(bool value)
			{
				return 0;
			}

			public static int UPxr_ResumeGuardianSystemForSTS()
			{
				return 0;
			}

			public static int UPxr_PauseGuardianSystemForSTS()
			{
				return 0;
			}

			public static int UPxr_ShutdownSdkGuardianSystem()
			{
				return 0;
			}

			public static int UPxr_GetRoomModeState()
			{
				return 0;
			}

			public static int UPxr_DisableBoundary()
			{
				return 0;
			}
		}

		public static class Render
		{
			private const string TAG = "[PXR_Plugin/Render]";

			public static bool UPxr_SetFoveationLevel(FoveationLevel level)
			{
				return false;
			}

			public static bool UPxr_SetEyeFoveationLevel(FoveationLevel level)
			{
				return false;
			}

			public static void UPxr_SetFFRSubsampled(bool enable)
			{
			}

			public static FoveationLevel UPxr_GetFoveationLevel()
			{
				return default(FoveationLevel);
			}

			public static int UPxr_SetFoveationParameters(float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum)
			{
				return 0;
			}

			public static int UPxr_GetFrustum(EyeType eye, ref float fovLeft, ref float fovRight, ref float fovUp, ref float fovDown, ref float near, ref float far)
			{
				return 0;
			}

			public static int UPxr_SetFrustum(EyeType eye, float fovLeft, float fovRight, float fovUp, float fovDown, float near, float far)
			{
				return 0;
			}

			public static int UPxr_SetEyeFOV(EyeType eye, float fovLeft, float fovRight, float fovUp, float fovDown)
			{
				return 0;
			}

			public static void UPxr_CreateLayer(IntPtr layerParam)
			{
			}

			public static void UPxr_CreateLayerParam(PxrLayerParam layerParam)
			{
			}

			public static int UPxr_GetLayerNextImageIndex(int layerId, ref int imageIndex)
			{
				return 0;
			}

			public static int UPxr_GetLayerImageCount(int layerId, EyeType eye, ref uint imageCount)
			{
				return 0;
			}

			public static int UPxr_GetLayerImage(int layerId, EyeType eye, int imageIndex, ref ulong image)
			{
				return 0;
			}

			public static void UPxr_GetLayerImagePtr(int layerId, EyeType eye, int imageIndex, ref IntPtr image)
			{
			}

			public static int UPxr_SetConfigIntArray(int[] configSetData)
			{
				return 0;
			}

			public static int UPxr_SetConfigFloatArray(ConfigType configIndex, float[] configSetData, int dataCount)
			{
				return 0;
			}

			public static int UPxr_GetLayerAndroidSurface(int layerId, EyeType eye, ref IntPtr androidSurface)
			{
				return 0;
			}

			public static int UPxr_DestroyLayer(int layerId)
			{
				return 0;
			}

			public static void UPxr_DestroyLayerByRender(int layerId)
			{
			}

			public static int UPxr_SubmitLayer(IntPtr layer)
			{
				return 0;
			}

			public static int UPxr_SubmitLayerQuad(PxrLayerQuad layer)
			{
				return 0;
			}

			public static bool UPxr_SubmitLayerQuad2(PxrLayerQuad2 layer)
			{
				return false;
			}

			public static bool UPxr_GetLayerNextImageIndexByRender(int layerId, ref int imageIndex)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerQuadByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerQuad2ByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerBlurredQuad2ByRender(IntPtr ptr, float scale, float shift, float fov, float ipd, float extAlpha)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerCylinderByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerCylinder2ByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerEquirectByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerEquirect2ByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerCube2ByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerEac2ByRender(IntPtr ptr)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerFisheyeByRender(IntPtr ptr)
			{
				return false;
			}

			public static int UPxr_SubmitLayerCylinder(PxrLayerCylinder layer)
			{
				return 0;
			}

			public static bool UPxr_SubmitLayerCylinder2(PxrLayerCylinder2 layer)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerEquirect(PxrLayerEquirect layer)
			{
				return false;
			}

			public static bool UPxr_SubmitLayerEquirect2(PxrLayerEquirect2 layer)
			{
				return false;
			}

			public static int UPxr_SubmitLayerCube2(PxrLayerCube2 layer)
			{
				return 0;
			}

			public static int UPxr_SubmitLayerEac2(PxrLayerEac2 layer)
			{
				return 0;
			}

			public static bool UPxr_SubmitLayerFisheye(PxrLayerFisheye layer)
			{
				return false;
			}

			public static void UPxr_SetLayerBlend(bool enable, PxrLayerBlend layerBlend)
			{
			}

			public static void UPxr_SetLayerColorScale(float x, float y, float z, float w)
			{
			}

			public static void UPxr_SetLayerColorBias(float x, float y, float z, float w)
			{
			}

			public static void UPxr_SetSpaceWarp(bool value)
			{
			}

			public static void UPxr_SetAppSpacePosition(float x, float y, float z)
			{
			}

			public static void UPxr_SetAppSpaceRotation(float x, float y, float z, float w)
			{
			}

			public static void UPxr_EnablePremultipliedAlpha(bool enable)
			{
			}
		}

		public static class Sensor
		{
			private const string TAG = "[PXR_Plugin/Sensor]";

			public static int UPxr_ResetSensor(ResetSensorOption resetSensorOption)
			{
				return 0;
			}

			public static int UPvr_Enable6DofModule(bool enable)
			{
				return 0;
			}

			public static void UPxr_InitPsensor()
			{
			}

			public static int UPxr_GetPSensorState()
			{
				return 0;
			}

			public static void UPxr_UnregisterPsensor()
			{
			}

			public static int UPxr_SetSensorLostCustomMode(bool value)
			{
				return 0;
			}

			public static int UPxr_SetSensorLostCMST(bool value)
			{
				return 0;
			}

			public static int UPxr_HMDUpdateSwitch(bool value)
			{
				return 0;
			}
		}

		public static class Controller
		{
			private const string TAG = "[PXR_Plugin/Controller]";

			public static int UPxr_SetControllerVibration(uint hand, float strength, int time)
			{
				return 0;
			}

			public static int UPxr_SetControllerEnableKey(bool isEnable, PxrControllerKeyMap Key)
			{
				return 0;
			}

			public static int UPxr_GetBodyTrackingPose(double predictTime, ref BodyTrackerResult bodyTrackerResult)
			{
				return 0;
			}

			public static int UPxr_GetMotionTrackerConnectStateWithID(ref PxrMotionTracker1ConnectState state)
			{
				return 0;
			}

			public static int UPxr_GetMotionTrackerBattery(int trackerId, ref int battery)
			{
				return 0;
			}

			public static int UPxr_GetMotionTrackerCalibState(ref int calibrated)
			{
				return 0;
			}

			public static int UPxr_SetBodyTrackingMode(BodyTrackingMode mode)
			{
				return 0;
			}

			public static int UPxr_SetBodyTrackingBoneLength(BodyTrackingBoneLength boneLength)
			{
				return 0;
			}

			public static int UPxr_SetControllerVibrationEvent(uint hand, int frequency, float strength, int time)
			{
				return 0;
			}

			public static int UPxr_GetControllerType()
			{
				return 0;
			}

			public static int UPxr_StopControllerVCMotor(int id)
			{
				return 0;
			}

			public static int UPxr_StartControllerVCMotor(string file, int slot)
			{
				return 0;
			}

			public static int UPxr_SetControllerAmp(float mode)
			{
				return 0;
			}

			public static int UPxr_SetControllerDelay()
			{
				return 0;
			}

			public static string UPxr_GetVibrateDelayTime(ref int x)
			{
				return null;
			}

			public static int UPxr_StartVibrateBySharem(float[] data, int slot, int buffersize, int sampleRate, int channelMask, int bitrate, int channelFlip, ref int sourceId)
			{
				return 0;
			}

			public static int UPxr_SaveVibrateByCache(float[] data, int slot, int buffersize, int sampleRate, int channelMask, int bitrate, int slotconfig, int enableV, ref int sourceId)
			{
				return 0;
			}

			public static int UPxr_StartVibrateByCache(int clicpid)
			{
				return 0;
			}

			public static int UPxr_ClearVibrateByCache(int clicpid)
			{
				return 0;
			}

			public static int UPxr_StartVibrateByPHF(string data, int buffersize, ref int sourceId, int slot, int reversal, float amp)
			{
				return 0;
			}

			public static int UPxr_PauseVibrate(int sourceID)
			{
				return 0;
			}

			public static int UPxr_ResumeVibrate(int sourceID)
			{
				return 0;
			}

			public static int UPxr_UpdateVibrateParams(int clicp_id, int slot, int reversal, float amp)
			{
				return 0;
			}

			public static int UPxr_CreateHapticStream(string phfVersion, uint frameDurationMs, ref VibrateInfo hapticInfo, float speed, ref int id)
			{
				return 0;
			}

			public static int UPxr_WriteHapticStream(int id, ref PxrPhfParamsNum frames, uint numFrames)
			{
				return 0;
			}

			public static int UPxr_SetPHFHapticSpeed(int id, float speed)
			{
				return 0;
			}

			public static int UPxr_GetPHFHapticSpeed(int id, ref float speed)
			{
				return 0;
			}

			public static int UPxr_GetCurrentFrameSequence(int id, ref ulong frameSequence)
			{
				return 0;
			}

			public static int UPxr_StartPHFHaptic(int source_id)
			{
				return 0;
			}

			public static int UPxr_StopPHFHaptic(int source_id)
			{
				return 0;
			}

			public static int UPxr_RemovePHFHaptic(int source_id)
			{
				return 0;
			}

			public static int UPxr_SetControllerMainInputHandle(uint hand)
			{
				return 0;
			}

			public static PXR_Input.Controller UPxr_GetControllerMainInputHandle()
			{
				return default(PXR_Input.Controller);
			}

			public static int UPxr_GetControllerTrackingState(uint deviceID, double predictTime, float[] headSensorData, ref PxrControllerTracking tracking)
			{
				return 0;
			}

			public static void UPxr_SetControllerOriginOffset(int controllerID, Vector3 offset)
			{
			}

			public static void UPxr_ResetController()
			{
			}

			public static void UPxr_SetArmModelParameters(PxrGazeType gazetype, PxrArmModelType armmodeltype, float elbowHeight, float elbowDepth, float pointerTiltAngle)
			{
			}

			public static void UPxr_GetControllerHandness(ref int deviceID)
			{
			}
		}

		public static class HandTracking
		{
			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetHandTrackerSettingState(ref bool settingState);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetHandTrackerActiveInputType(ref ActiveInputDevice activeInputDevice);

			[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetHandTrackerAimState(HandType hand, ref HandAimState aimState);

			[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetHandTrackerJointLocations(HandType hand, ref HandJointLocations jointLocations);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetHandTrackerHandScale(int hand, ref float scale);

			public static bool UPxr_GetHandTrackerSettingState()
			{
				return false;
			}

			public static ActiveInputDevice UPxr_GetHandTrackerActiveInputType()
			{
				return default(ActiveInputDevice);
			}

			public static bool UPxr_GetHandTrackerAimState(HandType hand, ref HandAimState aimState)
			{
				return false;
			}

			public static bool UPxr_GetHandTrackerJointLocations(HandType hand, ref HandJointLocations jointLocations)
			{
				return false;
			}

			public static bool UPxr_GetHandScale(int hand, ref float scale)
			{
				return false;
			}
		}

		public static class MotionTracking
		{
			private const string TAG = "MotionTracking";

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_WantEyeTrackingService();

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private unsafe static extern int Pxr_GetEyeTrackingSupported(ref bool supported, ref int supportedModesCount, EyeTrackingMode* supportedModes);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_StartEyeTracking1(ref EyeTrackingStartInfo startInfo);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_StopEyeTracking1(ref EyeTrackingStopInfo stopInfo);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetEyeTrackingState(ref bool isTracking, ref EyeTrackingState state);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetEyeTrackingData1(ref EyeTrackingDataGetInfo getInfo, ref EyeTrackingData data);

			[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetEyeOpenness(ref float leftEyeOpenness, ref float rightEyeOpenness);

			[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetEyePupilInfo(ref EyePupilInfo eyePupilPosition);

			[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetPerEyePose(ref long timestamp, ref Posef leftEyePose, ref Posef rightPose);

			[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetEyeBlink(ref long timestamp, ref bool isLeftBlink, ref bool isRightBlink);

			public static int UPxr_WantEyeTrackingService()
			{
				return 0;
			}

			public static int UPxr_GetEyeTrackingSupported(ref bool supported, ref int supportedModesCount, ref EyeTrackingMode[] supportedModes)
			{
				return 0;
			}

			public static int UPxr_StartEyeTracking1(ref EyeTrackingStartInfo startInfo)
			{
				return 0;
			}

			public static int UPxr_StopEyeTracking1(ref EyeTrackingStopInfo stopInfo)
			{
				return 0;
			}

			public static int UPxr_GetEyeTrackingState(ref bool isTracking, ref EyeTrackingState state)
			{
				return 0;
			}

			public static int UPxr_GetEyeTrackingData1(ref EyeTrackingDataGetInfo getInfo, ref EyeTrackingData data)
			{
				return 0;
			}

			public static int UPxr_GetEyeOpenness(ref float leftEyeOpenness, ref float rightEyeOpenness)
			{
				return 0;
			}

			public static int UPxr_GetEyePupilInfo(ref EyePupilInfo eyePupilPosition)
			{
				return 0;
			}

			public static int UPxr_GetPerEyePose(ref long timestamp, ref Posef leftEyePose, ref Posef rightPose)
			{
				return 0;
			}

			public static int UPxr_GetEyeBlink(ref long timestamp, ref bool isLeftBlink, ref bool isRightBlink)
			{
				return 0;
			}

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_WantFaceTrackingService();

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private unsafe static extern int Pxr_GetFaceTrackingSupported(ref bool supported, ref int supportedModesCount, FaceTrackingMode* supportedModes);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_StartFaceTracking(ref FaceTrackingStartInfo startInfo);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_StopFaceTracking(ref FaceTrackingStopInfo stopInfo);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetFaceTrackingState(ref bool isTracking, ref FaceTrackingState state);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetFaceTrackingData1(ref FaceTrackingDataGetInfo getInfo, ref FaceTrackingData data);

			public static int UPxr_WantFaceTrackingService()
			{
				return 0;
			}

			public static int UPxr_GetFaceTrackingSupported(ref bool supported, ref int supportedModesCount, ref FaceTrackingMode[] supportedModes)
			{
				return 0;
			}

			public static int UPxr_StartFaceTracking(ref FaceTrackingStartInfo startInfo)
			{
				return 0;
			}

			public static int UPxr_StopFaceTracking(ref FaceTrackingStopInfo stopInfo)
			{
				return 0;
			}

			public static int UPxr_GetFaceTrackingState(ref bool isTracking, ref FaceTrackingState state)
			{
				return 0;
			}

			public static int UPxr_GetFaceTrackingData1(ref FaceTrackingDataGetInfo getInfo, ref FaceTrackingData data)
			{
				return 0;
			}

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_StartBodyTrackingCalibApp(string calibFlagString, int calibMode);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_WantBodyTrackingService();

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetBodyTrackingSupported(ref bool supported, ref int supportedModesCount, ref int supportedModes);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_StartBodyTracking(ref BodyTrackingStartInfo startInfo);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_StopBodyTracking(ref BodyTrackingStopInfo stopInfo);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetBodyTrackingState(ref bool isTracking, ref BodyTrackingState state);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetBodyTrackingData(ref BodyTrackingGetDataInfo getInfo, ref BodyTrackingData data);

			public static int UPxr_StartMotionTrackerCalibApp()
			{
				return 0;
			}

			public static int UPxr_WantBodyTrackingService()
			{
				return 0;
			}

			public static int UPxr_GetBodyTrackingSupported(ref bool supported)
			{
				return 0;
			}

			public static int UPxr_StartBodyTracking(BodyTrackingMode mode, BodyTrackingBoneLength boneLength)
			{
				return 0;
			}

			public static int UPxr_StopBodyTracking()
			{
				return 0;
			}

			public static int UPxr_GetBodyTrackingState(ref bool isTracking, ref BodyTrackingState state)
			{
				return 0;
			}

			public static int UPxr_GetBodyTrackingData(ref BodyTrackingGetDataInfo getInfo, ref BodyTrackingData data)
			{
				return 0;
			}

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetMotionTrackerConnectState(ref MotionTrackerConnectState connectState);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetMotionTrackerType(ref MotionTrackerType trackerType);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_CheckMotionTrackerModeAndNumber(MotionTrackerMode mode, int number);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetMotionTrackerMode(ref MotionTrackerMode trackerMode);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetMotionTrackerLocationsWithConfidence(double predictTime, TrackerSN trackerSN, ref MotionTrackerLocations locations, ref MotionTrackerConfidence confidence);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetExtDevTrackerConnectState(ref ExtDevTrackerConnectState connectState);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_SetExtDevTrackerMotorVibrate(ref ExtDevTrackerMotorVibrate motorVibrate);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_SetExtDevTrackerPassDataState(bool state);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_SetExtDevTrackerByPassData(ref ExtDevTrackerPassData passData);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetExtDevTrackerByPassData(ref ExtDevTrackerPassDataArray passData, int length, ref int realLength);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetExtDevTrackerBattery(ref TrackerSN trackerSN, ref int out_battery, ref int out_charger);

			[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
			private static extern int Pxr_GetExtDevTrackerKeyData(ref TrackerSN trackerSN, ref ExtDevTrackerKeyData keyData);

			public static int UPxr_GetMotionTrackerConnectStateWithSN(ref MotionTrackerConnectState connectState)
			{
				return 0;
			}

			public static MotionTrackerType UPxr_GetMotionTrackerDeviceType()
			{
				return default(MotionTrackerType);
			}

			public static MotionTrackerMode UPxr_GetMotionTrackerMode()
			{
				return default(MotionTrackerMode);
			}

			public static int UPxr_CheckMotionTrackerModeAndNumber(MotionTrackerMode mode, int number)
			{
				return 0;
			}

			public static int UPxr_GetMotionTrackerLocations(double predictTime, TrackerSN trackerSN, ref MotionTrackerLocations locations, ref MotionTrackerConfidence confidence)
			{
				return 0;
			}

			public static int UPxr_GetExtDevTrackerConnectState(ref ExtDevTrackerConnectState connectState)
			{
				return 0;
			}

			public static int UPxr_SetExtDevTrackerMotorVibrate(ref ExtDevTrackerMotorVibrate motorVibrate)
			{
				return 0;
			}

			public static int UPxr_SetExtDevTrackerPassDataState(bool state)
			{
				return 0;
			}

			public static int UPxr_SetExtDevTrackerByPassData(ref ExtDevTrackerPassData passData)
			{
				return 0;
			}

			public static int UPxr_GetExtDevTrackerByPassData(ref ExtDevTrackerPassDataArray passData, ref int realLength)
			{
				return 0;
			}

			public static int UPxr_GetExtDevTrackerBattery(ref TrackerSN trackerSN, ref int battery, ref int charger)
			{
				return 0;
			}

			public static int UPxr_GetExtDevTrackerKeyData(ref TrackerSN trackerSN, ref ExtDevTrackerKeyData keyData)
			{
				return 0;
			}
		}

		public static class MixedReality
		{
			private const string TAG = "[PXR_Plugin/MixedReality]";

			public static Dictionary<ulong, PxrSceneComponentData> SceneAnchorData;

			public static Dictionary<Guid, PxrSpatialMeshInfo> SpatialMeshData;

			public static Dictionary<Guid, ulong> meshAnchorLastData;

			private static readonly Dictionary<Guid, List<IDisposable>> nativeMeshArrays;

			private const int MAX_EVENT = 20;

			private static IntPtr[] eventArrayHandle;

			public static ulong SpatialAnchorProviderHandle
			{
				[CompilerGenerated]
				get
				{
					return 0uL;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public static ulong SceneCaptureProviderHandle
			{
				[CompilerGenerated]
				get
				{
					return 0uL;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public static ulong SemiAutoSceneCaptureProviderHandle
			{
				[CompilerGenerated]
				get
				{
					return 0uL;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public static ulong AutoSceneCaptureProviderHandle
			{
				[CompilerGenerated]
				get
				{
					return 0uL;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public static bool UPxr_UseMRLegacyApi()
			{
				return false;
			}

			public static PxrSceneComponentType UPxr_ConvertAnchorCTypeToSceneCType(PxrAnchorComponentTypeFlags flag)
			{
				return default(PxrSceneComponentType);
			}

			public static PxrSpatialSceneDataTypeFlags UPxr_ConvertSemanticToSceneFlag(PxrSemanticLabel label)
			{
				return default(PxrSpatialSceneDataTypeFlags);
			}

			public static PxrResult UPxr_CreateSenseDataProvider(ref PxrSenseDataProviderCreateInfoBaseHeader info, out ulong providerHandle)
			{
				providerHandle = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_CreateSpatialAnchorSenseDataProvider()
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_CreateSceneCaptureSenseDataProvider()
			{
				return default(PxrResult);
			}

			public static ulong UPxr_GetSpatialMeshProviderHandle()
			{
				return 0uL;
			}

			public static void UPxr_AddOrUpdateMesh(PxrSpatialMeshInfo meshInfo)
			{
			}

			public static void UPxr_RemoveMesh(Guid uuid)
			{
			}

			public static void UPxr_DisposeMesh()
			{
			}

			public static void UPxr_ClearMeshes()
			{
			}

			public static ulong UPxr_GetSenseDataProviderHandle(PxrSenseDataProviderType type)
			{
				return 0uL;
			}

			public static PxrResult UPxr_StartSenseDataProviderAsync(ulong providerHandle, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_StartSenseDataProviderComplete(ulong future, out PxrSenseDataProviderStartCompletion completion)
			{
				completion = default(PxrSenseDataProviderStartCompletion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSenseDataProviderState(ulong providerHandle, out PxrSenseDataProviderState state)
			{
				state = default(PxrSenseDataProviderState);
				return default(PxrResult);
			}

			public static PxrResult UPxr_StopSenseDataProvide(ulong providerHandle)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_DestroySenseDataProvider(ulong providerHandle)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_QuerySenseDataAsync(ulong providerHandle, ref PxrSenseDataQueryInfo info, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_DestroySenseDataQueryResult(ulong queryResultHandle)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_QuerySenseDataByUuidAsync(Guid[] uuids, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_QuerySenseDataBySemanticAsync(PxrSemanticLabel[] labels, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_QuerySenseDataComplete(ulong providerHandle, ulong future, out PxrSenseDataQueryCompletion completion)
			{
				completion = default(PxrSenseDataQueryCompletion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetQueriedSenseData(ulong providerHandle, ulong snapshotHandle, out List<PxrQueriedSpatialEntityInfo> entityinfos)
			{
				entityinfos = null;
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialEntityUuid(ulong entityHandle, out Guid uuid)
			{
				uuid = default(Guid);
				return default(PxrResult);
			}

			public static PxrResult UPxr_EnumerateSpatialEntityComponentTypes(ulong snapshotHandle, ulong spatialEntityHandle, out PxrSceneComponentType[] types)
			{
				types = null;
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialEntityComponentInfo(ulong snapshotHandle, ref PxrSpatialEntityComponentInfoGetInfoBaseHeader getInfo, ref PxrSpatialEntityComponentInfoBaseHeader componentInfo)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialEntityLocationInfo(ulong snapshotHandle, ulong spatialEntityHandle, out Vector3 position, out Quaternion rotation)
			{
				position = default(Vector3);
				rotation = default(Quaternion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialMesh(ulong snapshotHandle, ulong entityHandle, ref PxrSpatialMeshInfo meshInfo)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialMeshVerticesAndIndices(ulong snapshotHandle, ulong entityHandle, out ushort[] indices, out Vector3[] vertices)
			{
				indices = null;
				vertices = null;
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialMeshSemantics(ulong snapshotHandle, ulong spatialEntityHandle, out PxrSemanticLabel[] labels)
			{
				labels = null;
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialEntitySemanticInfo(ulong snapshotHandle, ulong spatialEntityHandle, out PxrSemanticLabel label)
			{
				label = default(PxrSemanticLabel);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialEntityBox3DInfo(ulong snapshotHandle, ulong spatialEntityHandle, out Vector3 position, out Quaternion rotation, out Vector3 extent)
			{
				position = default(Vector3);
				rotation = default(Quaternion);
				extent = default(Vector3);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialEntityBox2DInfo(ulong snapshotHandle, ulong spatialEntityHandle, out Vector2 offset, out Vector2 extent)
			{
				offset = default(Vector2);
				extent = default(Vector2);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetSpatialEntityPolygonInfo(ulong snapshotHandle, ulong spatialEntityHandle, out Vector2[] vertices)
			{
				vertices = null;
				return default(PxrResult);
			}

			public static PxrResult UPxr_RetrieveSpatialEntityAnchor(ulong snapshotHandle, ulong spatialEntityHandle, out ulong anchorHandle)
			{
				anchorHandle = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_PollFuture(ulong future, out PxrFutureState futureState)
			{
				futureState = default(PxrFutureState);
				return default(PxrResult);
			}

			public static PxrResult UPxr_CreateSpatialAnchorAsync(ulong providerHandle, Vector3 position, Quaternion rotation, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_CreateSpatialAnchorComplete(ulong providerHandle, ulong future, out PxrSpatialAnchorCreateCompletion completion)
			{
				completion = default(PxrSpatialAnchorCreateCompletion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_DestroyAnchor(ulong anchorHandle)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorUuid(ulong anchorHandle, out Guid uuid)
			{
				uuid = default(Guid);
				return default(PxrResult);
			}

			public static PxrResult UPxr_LocateAnchor(ulong anchorHandle, out Vector3 position, out Quaternion rotation)
			{
				position = default(Vector3);
				rotation = default(Quaternion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_PersistSpatialAnchorAsync(ulong providerHandle, ulong anchorHandle, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_PersistSpatialAnchorComplete(ulong providerHandle, ulong future, out PxrSpatialAnchorPersistCompletion completion)
			{
				completion = default(PxrSpatialAnchorPersistCompletion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_UnPersistSpatialAnchorAsync(ulong providerHandle, ulong anchorHandle, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_UnPersistSpatialAnchorComplete(ulong providerHandle, ulong future, out PxrSpatialAnchorUnpersistCompletion completion)
			{
				completion = default(PxrSpatialAnchorUnpersistCompletion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_StartSceneCaptureAsync(out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_StartSceneCaptureComplete(ulong future, out PxrSceneCaptureStartCompletion completion)
			{
				completion = default(PxrSceneCaptureStartCompletion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_ShareSpatialAnchorAsync(ulong anchorHandle, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_ShareSpatialAnchorComplete(ulong future, out PxrSpatialAnchorShareCompletion completion)
			{
				completion = default(PxrSpatialAnchorShareCompletion);
				return default(PxrResult);
			}

			public static PxrResult UPxr_DownloadSharedSpatialAnchorsAsync(Guid uuid, out ulong future)
			{
				future = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_DownloadSharedSpatialAnchorsComplete(ulong future, out PxrSharedSpatialAnchorDownloadCompletion completion)
			{
				completion = default(PxrSharedSpatialAnchorDownloadCompletion);
				return default(PxrResult);
			}

			public static int UPxr_EnableVideoSeeThroughEffect(bool value)
			{
				return 0;
			}

			public static int UPxr_SetVideoSeeThroughEffect(PxrLayerEffect type, float value, float duration)
			{
				return 0;
			}

			public static int UPxr_SetVideoSeeThroughLUT(ref byte[] data, int width, int height, int row, int col)
			{
				return 0;
			}

			public static PxrResult UPxr_CreateAnchorEntity(ref PxrAnchorEntityCreateInfo info, out ulong anchorHandle)
			{
				anchorHandle = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_DestroyAnchorEntity(ref PxrAnchorEntityDestroyInfo info)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_PersistAnchorEntity(ref PxrAnchorEntityPersistInfo info, out ulong taskId)
			{
				taskId = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_UnpersistAnchorEntity(ref PxrAnchorEntityUnPersistInfo info, out ulong taskId)
			{
				taskId = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_ClearPersistedAnchorEntity(ref PxrAnchorEntityClearInfo info, out ulong taskId)
			{
				taskId = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorPose(ulong anchorHandle, PxrTrackingOrigin origin, out PxrPosef pose)
			{
				pose = default(PxrPosef);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorEntityUuid(ulong anchorHandle, out PxrUuid uuid)
			{
				uuid = default(PxrUuid);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorComponentFlags(ulong anchorHandle, out ulong flag)
			{
				flag = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_LoadAnchorEntity(ref PxrAnchorEntityLoadInfo info, out ulong taskId)
			{
				taskId = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorEntityLoadResults(ulong taskId, ref PxrAnchorEntityLoadResults result)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_StartSpatialSceneCapture(out ulong taskId)
			{
				taskId = default(ulong);
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorVolumeInfo(ulong anchorHandle, ref PxrAnchorVolumeInfo info)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorPlanePolygonInfo(ulong anchorHandle, ref PxrAnchorPlanePolygonInfo info)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorPlaneBoundaryInfo(ulong anchorHandle, ref PxrAnchorPlaneBoundaryInfo info)
			{
				return default(PxrResult);
			}

			public static PxrResult UPxr_GetAnchorSceneLabel(ulong anchorHandle, out PxrSceneLabel label)
			{
				label = default(PxrSceneLabel);
				return default(PxrResult);
			}

			public static bool UPxr_PollEventQueue(ref List<PxrEventDataBuffer> bufferList)
			{
				return false;
			}
		}

		private const string PXR_SDK_Version = "3.0.4";

		public const string PXR_PLATFORM_DLL = "PxrPlatform";

		public const string PXR_API_DLL = "pxr_api";

		private static int PXR_API_Version;

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_PollFutureEXT(ref PxrFuturePollInfo pollInfo, ref PxrFuturePollResult pollResult);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_CreateSenseDataProvider(ref PxrSenseDataProviderCreateInfoBaseHeader createInfo, out ulong providerHandle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartSenseDataProviderAsync(ulong providerHandle, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartSenseDataProviderComplete(ulong future, ref PxrSenseDataProviderStartCompletion completion);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetSenseDataProviderState(ulong providerHandle, ref PxrSenseDataProviderState state);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_QuerySenseDataComplete(ulong providerHandle, ulong future, ref PxrSenseDataQueryCompletion completion);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_DestroySenseDataQueryResult(ulong snapshotHandle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StopSenseDataProvider(ulong providerHandle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_DestroySenseDataProvider(ulong providerHandle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_QuerySenseDataAsync(ulong providerHandle, ref PxrSenseDataQueryInfo info, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetQueriedSenseData(ulong providerHandle, ref PxrQueriedSenseDataGetInfo info, ref PxrQueriedSenseData senseData);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetSpatialEntityUuid(ulong spatialEntity, out PxrUuid uuid);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_EnumerateSpatialEntityComponentTypes(ulong snapshotHandle, ulong spatialEntity, uint inputCount, out uint outputCount, IntPtr types);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetSpatialEntityComponentInfo(ulong snapshotHandle, ref PxrSpatialEntityComponentInfoGetInfoBaseHeader componentGetInfo, ref PxrSpatialEntityComponentInfoBaseHeader componentInfo);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_RetrieveSpatialEntityAnchor(ulong snapshotHandle, ref PxrSpatialEntityAnchorRetrieveInfo info, out ulong anchorHandle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_DestroyAnchor(ulong anchorHandle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetAnchorUuid(ulong anchorHandle, out PxrUuid uuid);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_LocateAnchor(ref PxrAnchorLocateInfo info, ref PxrSpaceLocation location);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_CreateSpatialAnchorAsync(ulong providerHandle, ref PxrSpatialAnchorCreateInfo info, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_CreateSpatialAnchorComplete(ulong providerHandle, ulong future, ref PxrSpatialAnchorCreateCompletion completion);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_PersistSpatialAnchorAsync(ulong providerHandle, ref PxrSpatialAnchorPersistInfo info, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_PersistSpatialAnchorComplete(ulong providerHandle, ulong future, ref PxrSpatialAnchorPersistCompletion completion);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_UnpersistSpatialAnchorAsync(ulong providerHandle, ref PxrSpatialAnchorUnpersistInfo info, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_UnpersistSpatialAnchorComplete(ulong providerHandle, ulong future, ref PxrSpatialAnchorUnpersistCompletion completion);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartSceneCaptureAsync(ulong providerHandle, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartSceneCaptureComplete(ulong providerHandle, ulong future, ref PxrSceneCaptureStartCompletion completion);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_ShareSpatialAnchorAsync(ulong providerHandle, ref PxrSpatialAnchorShareInfo info, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_ShareSpatialAnchorComplete(ulong providerHandle, ulong future, ref PxrSpatialAnchorShareCompletion completion);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_DownloadSharedSpatialAnchorAsync(ulong providerHandle, ref PxrSharedSpatialAnchorDownloadInfo info, out ulong future);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_DownloadSharedSpatialAnchorComplete(ulong providerHandle, ulong future, ref PxrSharedSpatialAnchorDownloadCompletion completion);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong Pxr_GetSpatialMeshProviderHandle();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern void Pxr_AddOrUpdateMesh(ulong id1, ulong id2, int numVertices, void* vertices, int numTriangles, void* indices, Vector3 position, Quaternion rotation);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_RemoveMesh(ulong id1, ulong id2);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_ClearMeshes();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_EnablePassthroughStyle(bool value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetPassthroughStyle(PxrLayerEffect type, float value, float duration);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetPassthroughLUT(ref byte[] data, int width, int height, int row, int col);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_CreateAnchorEntity(ref PxrAnchorEntityCreateInfo info, out ulong anchorHandle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_DestroyAnchorEntity(ref PxrAnchorEntityDestroyInfo info);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorPose(ulong anchorHandle, PxrTrackingOrigin origin, out PxrPosef pose);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorEntityUuid(ulong anchorHandle, out PxrUuid uuid);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorComponentFlags(ulong anchorHandle, out ulong flag);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorSceneLabel(ulong anchorHandle, out PxrSceneLabel label);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorPlaneBoundaryInfo(ulong anchorHandle, ref PxrAnchorPlaneBoundaryInfo info);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorPlanePolygonInfo(ulong anchorHandle, ref PxrAnchorPlanePolygonInfo info);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorBoxInfo(ulong anchorHandle, ref PxrAnchorVolumeInfo info);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_PersistAnchorEntity(ref PxrAnchorEntityPersistInfo info, out ulong taskId);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_UnpersistAnchorEntity(ref PxrAnchorEntityUnPersistInfo info, out ulong taskId);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_ClearPersistedAnchorEntity(ref PxrAnchorEntityClearInfo info, out ulong taskId);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_LoadAnchorEntity(ref PxrAnchorEntityLoadInfo info, out ulong taskId);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_GetAnchorEntityLoadResults(ulong taskId, ref PxrAnchorEntityLoadResults results);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern PxrResult Pxr_StartSpatialSceneCapture(out ulong taskId);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pxr_PollEventFromXRPlugin(ref int eventNum, IntPtr[] eventData);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_CameraStart();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_CameraStop();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_CameraDestroy();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Pxr_CameraGetRenderEventFunc();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_CameraSetRenderEventPending();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_CameraWaitForRenderEvent();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_CameraUpdateFrame(int eye);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_CameraCreateTexturesMainThread();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_CameraDeleteTexturesMainThread();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_CameraUpdateTexturesMainThread();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_SetFoveationLevelEnable(int enable);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_SetEyeFoveationLevelEnable(int enable);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetFFRSubsampled(bool enable);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_LoadPlugin();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_UnloadPlugin();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_GetHomeKey();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_InitHomeKey();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_GetMRCEnable();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetUserDefinedSettings(UserDefinedSettings settings);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_Construct(PXR_Loader.ConvertRotationWith2VectorDelegate fromToRotation);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_GetFocusState();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_IsSensorReady();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetSensorStatus();

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_GetLayerImagePtr(int layerId, EyeType eye, int imageIndex, ref IntPtr image);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_CreateLayerParam(PxrLayerParam layerParam);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_DestroyLayerByRender(int layerId);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_EnableEyeTracking(bool enable);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_EnableFaceTracking(bool enable);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_EnableLipsync(bool enable);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_SetEventDataBufferCallBack(EventDataBufferCallBack callback);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_EnablePremultipliedAlpha(bool enable);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_SetGraphicOption(GraphicsAPI option);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_CreateLayer(IntPtr layerParam);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetLayerNextImageIndex(int layerId, ref int imageIndex);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetLayerImageCount(int layerId, EyeType eye, ref uint imageCount);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetLayerImage(int layerId, EyeType eye, int imageIndex, ref ulong image);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetConfigIntArray(ConfigType configIndex, int[] configSetData, int dataCount);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetConfigFloatArray(ConfigType configIndex, float[] configSetData, int dataCount);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetLayerAndroidSurface(int layerId, EyeType eye, ref IntPtr androidSurface);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_DestroyLayer(int layerId);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayer(IntPtr layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerQuad(PxrLayerQuad layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerQuad2(PxrLayerQuad2 layer);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetLayerNextImageIndexByRender(int layerId, ref int imageIndex);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerQuadByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerQuad2ByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerBlurredQuad2ByRender(IntPtr ptr, float scale, float shift, float fov, float ipd, float extAlpha);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerCylinderByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerCylinder2ByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerEquirectByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerEquirect2ByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerCube2ByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerEac2ByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerFisheyeByRender(IntPtr ptr);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_HMDUpdateSwitch(bool enable);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerCylinder(PxrLayerCylinder layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerCylinder2(PxrLayerCylinder2 layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerEquirect(PxrLayerEquirect layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerEquirect2(PxrLayerEquirect2 layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerCube2(PxrLayerCube2 layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerEac2(PxrLayerEac2 layer);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SubmitLayerFisheye(PxrLayerFisheye layer);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_SetLayerBlend(bool enable, PxrLayerBlend layerBlend);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetLayerColorScale(float x, float y, float z, float w);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetLayerColorBias(float x, float y, float z, float w);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern FoveationLevel Pxr_GetFoveationLevel();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetFoveationParams(FoveationParams foveationParams);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetFrustum(EyeType eye, float fovLeft, float fovRight, float fovUp, float fovDown, float near, float far);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetFrustum(EyeType eye, ref float fovLeft, ref float fovRight, ref float fovUp, ref float fovDown, ref float near, ref float far);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetConfigFloat(ConfigType configIndex, ref float value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetConfigInt(ConfigType configIndex, ref int value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetConfigInt(ConfigType configSetIndex, int configSetData);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetConfigString(ConfigType configSetIndex, string configSetData);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetConfigUint64(ConfigType configSetIndex, ulong configSetData);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_ResetSensor(ResetSensorOption option);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetSensorLostCustomMode(bool value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetSensorLostCMST(bool value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_GetDisplayRefreshRatesAvailable(ref int configCount, ref IntPtr configArray);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetDisplayRefreshRate(float refreshRate);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetPredictedDisplayTime(ref double predictedDisplayTime);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_SetExtraLatencyMode(int mode);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetTrackingMode(ref ulong trackingModeFlags);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetTrackingOrigin(PxrTrackingOrigin mode);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetTrackingOrigin(ref PxrTrackingOrigin mode);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_UpdateContentProtectState(int state);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_UpdateDisplayRefreshRate(int rate);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetPredictedMainSensorState2(double predictTimeMs, ref PxrSensorState2 sensorState, ref int sensorFrameIndex);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_SetControllerOriginOffset(int controllerID, Vector3 offset);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetControllerTrackingState(uint deviceID, double predictTime, float[] headSensorData, ref PxrControllerTracking tracking);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetControllerMainInputHandle(uint deviceID);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetControllerMainInputHandle(ref int deviceID);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetControllerVibration(uint deviceID, float strength, int time);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetControllerEnableKey(bool isEnable, PxrControllerKeyMap Key);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_ResetController(uint deviceID);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetArmModelParameters(PxrGazeType gazetype, PxrArmModelType armmodeltype, float elbowHeight, float elbowDepth, float pointerTiltAngle);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetControllerHandness(ref int handness);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetControllerVibrationEvent(uint deviceID, int frequency, float strength, int time);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetControllerCapabilities(uint deviceID, ref PxrControllerCapability capability);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StopControllerVCMotor(int clientId);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartControllerVCMotor(string file, int slot);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetControllerAmp(float mode);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetControllerDelay(int delay);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern string Pxr_GetVibrateDelayTime(ref int length);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartVibrateBySharemF(float[] data, ref AudioClipData parameter, ref int source_id);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartVibrateByCache(int clicpid);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_ClearVibrateByCache(int clicpid);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartVibrateByPHF(string data, int buffersize, ref int sourceID, ref VibrateInfo vibrateInfo);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_PauseVibrate(int sourceID);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_ResumeVibrate(int sourceID);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_UpdateVibrateParams(int clicp_id, ref VibrateInfo vibrateInfo);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_CreateHapticStream(string phfVersion, uint frameDurationMs, ref VibrateInfo hapticInfo, float speed, ref int id);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_WriteHapticStream(int id, ref PxrPhfParamsNum frames, uint numFrames);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetPHFHapticSpeed(int id, float speed);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetPHFHapticSpeed(int id, ref float speed);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_GetCurrentFrameSequence(int id, ref ulong frameSequence);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StartPHFHaptic(int source_id);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_StopPHFHaptic(int source_id);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_RemovePHFHaptic(int source_id);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pxr_SetLogInfoActive(bool value);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetVideoSeethroughState(bool value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_TestNodeIsInBoundary(BoundaryTrackingNode node, bool isPlayArea, ref PxrBoundaryTriggerInfo info);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_TestPointIsInBoundary(ref PxrVector3f point, bool isPlayArea, ref PxrBoundaryTriggerInfo info);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetBoundaryGeometry(bool isPlayArea, uint pointsCountInput, ref uint pointsCountOutput, PxrVector3f[] outPoints);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetBoundaryDimensions(bool isPlayArea, out PxrVector3f dimension);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_GetBoundaryConfigured();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_GetBoundaryEnabled();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetBoundaryVisible(bool value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetSeeThroughBackground(bool value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pxr_GetBoundaryVisible();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_ResetSensorHard();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetTrackingState();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetGuardianSystemDisable(bool disable);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_ResumeGuardianSystemForSTS();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_PauseGuardianSystemForSTS();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_ShutdownSdkGuardianSystem();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetRoomModeState();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_DisableBoundary();

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetTrackingMode(double trackingMode);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetFaceTrackingData(long ts, int flags, ref PxrFaceTrackingInfo faceTrackingInfo);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetSpaceWarp(int value);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetAppSpacePosition(float x, float y, float z);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pxr_SetAppSpaceRotation(float x, float y, float z, float w);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetTrackingStatus(string key, string value);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetPerformanceLevels(PxrPerfSettings which, PxrSettingsLevel level);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetPerformanceLevels(PxrPerfSettings which, ref PxrSettingsLevel level);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetBodyTrackingPose(double predictTime, ref BodyTrackerResult bodyTrackerResult);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_SetBodyTrackingMode(int mode);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetFitnessBandConnectState(ref PxrMotionTracker1ConnectState state);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetFitnessBandBattery(int trackerId, ref int battery);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetFitnessBandCalibState(ref int calibrated);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_LogSdkApi(string sdkInfo);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pxr_SetBodyTrackingAlgParam(BodyTrackingAlgParamType AlgParamType, ref BodyTrackingAlgParam Param);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_UpdateAdaptiveResolution(ref PxrExtent2Di dimensions, AdaptiveResolutionPowerSetting powerSetting);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetExternalCameraInfo(ref ExternalCameraInfo cameraInfo);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetExternalCameraPose(PxrTrackingOrigin pxrTrackingOrigin, ref PxrPosef outPose);

		[DllImport("PxrPlatform", CallingConvention = CallingConvention.Cdecl)]
		private static extern float Pxr_VstModelOffset();
	}
}
