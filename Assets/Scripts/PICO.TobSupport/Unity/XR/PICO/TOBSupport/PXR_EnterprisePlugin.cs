using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PICO.TOBSupport
{
	public class PXR_EnterprisePlugin
	{
		private const string TAG = "[PXR_EnterprisePlugin]";

		public const int MAX_SIZE = 12208032;

		public static string token;

		private static int curSize;

		private static bool camOpenned;

		private static FrameItemExt antiDistortionFrameItemExt;

		private static FrameItemExt distortionFrameItemExt;

		private static bool initDistortionFrame;

		public static Action<bool> BoolCallback;

		public static Action<int> IntCallback;

		public static Action<long> LongCallback;

		public static Action<string> StringCallback;

		private const string LibraryName = "PICO_TOBAPI";

		private static IntPtr? _VirtualDisplayPlugin;

		private static IntPtr createVirtualDisplayMethodId;

		private static IntPtr startAppMethodId;

		private static jvalue[] setUnityActivityParams;

		private static IntPtr? _Activity;

		private static IntPtr setUnityActivityMethodId;

		private static jvalue[] CVDParams;

		private static jvalue[] SAParams;

		private static IntPtr releaseVirtualDisplayMethodId;

		private static jvalue[] RVDParams;

		private static IntPtr setVirtualDisplaySurfaceMethodId;

		private static jvalue[] SFParams;

		private static IntPtr injectEventMMethodId;

		private static jvalue[] JEMParams;

		private static IntPtr injectEventKMethodId;

		private static jvalue[] JEParams;

		private static IntPtr resizeVirtualDisplayMethodId;

		private static jvalue[] RVParams;

		private static IntPtr Activity => (IntPtr)0;

		private static IntPtr VirtualDisplayPlugin => (IntPtr)0;

		[DllImport("libpxr_xrsdk_native", CallingConvention = CallingConvention.Cdecl)]
		public static extern int getHeadTrackingConfidence();

		[DllImport("libpxr_xrsdk_native", CallingConvention = CallingConvention.Cdecl)]
		public static extern int openVSTCamera();

		[DllImport("libpxr_xrsdk_native", CallingConvention = CallingConvention.Cdecl)]
		public static extern int closeVSTCamera();

		[DllImport("libpxr_xrsdk_native", CallingConvention = CallingConvention.Cdecl)]
		public static extern int getHeadTrackingData(long predictTime, ref SixDof data, int type);

		[DllImport("libpxr_xrsdk_native", CallingConvention = CallingConvention.Cdecl)]
		public static extern int acquireVSTCameraFrame(ref FrameItemExt frame);

		[DllImport("libpxr_xrsdk_native", CallingConvention = CallingConvention.Cdecl)]
		public static extern int acquireVSTCameraFrameAntiDistortion(string token, int width, int height, ref FrameItemExt frame);

		[DllImport("libpxr_xrsdk_native", CallingConvention = CallingConvention.Cdecl)]
		public static extern int getCameraParameters(string token, out RGBCameraParams rgb_Camera_Params);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetPredictedDisplayTime(ref double predictedDisplayTime);

		[DllImport("pxr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pxr_GetPredictedMainSensorState2(double predictTimeMs, ref PxrSensorState2 sensorState, ref int sensorFrameIndex);

		private static AndroidJavaObject GetEnumType(Enum enumType)
		{
			return null;
		}

		public static bool UPxr_InitEnterpriseService(bool isCamera = false)
		{
			return false;
		}

		public static void UPxr_SetBindCallBack(BindCallback mBoolCallback)
		{
		}

		public static void UPxr_BindEnterpriseService(Action<bool> callback = null)
		{
		}

		public static void UPxr_UnBindEnterpriseService()
		{
		}

		public static void GetServiceBinder()
		{
		}

		public static string UPxr_StateGetDeviceInfo(SystemInfoEnum type, int ext)
		{
			return null;
		}

		public static void UPxr_ControlSetDeviceAction(DeviceControlEnum deviceControl, Action<int> callback)
		{
		}

		public static void UPxr_ControlAPPManager(PackageControlEnum packageControl, string path, Action<int> callback, int ext)
		{
		}

		public static void UPxr_ControlSetAutoConnectWIFI(string ssid, string pwd, Action<bool> callback, int ext)
		{
		}

		public static void UPxr_ControlClearAutoConnectWIFI(Action<bool> callback)
		{
		}

		public static void UPxr_PropertySetHomeKey(HomeEventEnum eventEnum, HomeFunctionEnum function, Action<bool> callback)
		{
		}

		public static void UPxr_PropertySetHomeKeyAll(HomeEventEnum eventEnum, HomeFunctionEnum function, int timesetup, string pkg, string className, Action<bool> callback)
		{
		}

		public static void UPxr_PropertyDisablePowerKey(bool isSingleTap, bool enable, Action<int> callback)
		{
		}

		public static void UPxr_PropertySetScreenOffDelay(ScreenOffDelayTimeEnum timeEnum, Action<int> callback)
		{
		}

		public static void UPxr_PropertySetSleepDelay(SleepDelayTimeEnum timeEnum)
		{
		}

		public static void UPxr_SwitchSystemFunction(SystemFunctionSwitchEnum systemFunction, SwitchEnum switchEnum, int ext)
		{
		}

		public static void UPxr_SwitchSetUsbConfigurationOption(USBConfigModeEnum uSBConfigModeEnum, int ext)
		{
		}

		public static void UPxr_SetControllerPairTime(ControllerPairTimeEnum timeEnum, Action<int> callback, int ext)
		{
		}

		public static void UPxr_GetControllerPairTime(Action<int> callback, int ext)
		{
		}

		public static void UPxr_ScreenOn()
		{
		}

		public static void UPxr_ScreenOff()
		{
		}

		public static void UPxr_AcquireWakeLock()
		{
		}

		public static void UPxr_ReleaseWakeLock()
		{
		}

		public static void UPxr_EnableEnterKey()
		{
		}

		public static void UPxr_DisableEnterKey()
		{
		}

		public static void UPxr_EnableVolumeKey()
		{
		}

		public static void UPxr_DisableVolumeKey()
		{
		}

		public static void UPxr_EnableBackKey()
		{
		}

		public static void UPxr_DisableBackKey()
		{
		}

		public static void UPxr_ResetAllKeyToDefault(Action<bool> callback)
		{
		}

		public static void UPxr_SetAPPAsHome(SwitchEnum switchEnum, string packageName)
		{
		}

		public static void UPxr_KillAppsByPidOrPackageName(int[] pids, string[] packageNames, int ext)
		{
		}

		public static void UPxr_KillBackgroundAppsWithWhiteList(string[] packageNames, int ext)
		{
		}

		public static void UPxr_FreezeScreen(bool freeze)
		{
		}

		public static void UPxr_OpenMiracast()
		{
		}

		public static bool UPxr_IsMiracastOn()
		{
			return false;
		}

		public static void UPxr_CloseMiracast()
		{
		}

		public static void UPxr_StartScan()
		{
		}

		public static void UPxr_StopScan()
		{
		}

		public static void UPxr_ConnectWifiDisplay(string modelJson)
		{
		}

		public static void UPxr_DisConnectWifiDisplay()
		{
		}

		public static void UPxr_ForgetWifiDisplay(string address)
		{
		}

		public static void UPxr_RenameWifiDisplay(string address, string newName)
		{
		}

		public static void UPxr_SetWDModelsCallback(Action<List<WifiDisplayModel>> callback)
		{
		}

		public static void UPxr_SetWDJsonCallback(Action<string> callback)
		{
		}

		public static void UPxr_UpdateWifiDisplays()
		{
		}

		public static string UPxr_GetConnectedWD()
		{
			return null;
		}

		public static void UPxr_SwitchLargeSpaceScene(bool open, Action<bool> callback, int ext)
		{
		}

		public static void UPxr_GetSwitchLargeSpaceStatus(Action<string> callback, int ext)
		{
		}

		public static bool UPxr_SaveLargeSpaceMaps(int ext)
		{
			return false;
		}

		public static void UPxr_ExportMaps(Action<bool> callback, int ext)
		{
		}

		public static void UPxr_ImportMaps(Action<bool> callback, int ext)
		{
		}

		public static float[] UPxr_GetCpuUsages()
		{
			return null;
		}

		public static float[] UPxr_GetDeviceTemperatures(int type, int source)
		{
			return null;
		}

		public static void UPxr_Capture()
		{
		}

		public static void UPxr_Record()
		{
		}

		public static void UPxr_ControlSetAutoConnectWIFIWithErrorCodeCallback(string ssid, string pwd, int ext, Action<int> callback)
		{
		}

		public static void UPxr_AppKeepAlive(string appPackageName, bool keepAlive, int ext)
		{
		}

		public static void UPxr_TimingStartup(int year, int month, int day, int hour, int minute, bool open)
		{
		}

		public static void UPxr_TimingShutdown(int year, int month, int day, int hour, int minute, bool open)
		{
		}

		public static void UPxr_StartVrSettingsItem(StartVRSettingsEnum settingsEnum, bool hideOtherItem, int ext)
		{
		}

		public static void UPxr_SwitchVolumeToHomeAndEnter(SwitchEnum switchEnum, int ext)
		{
		}

		public static SwitchEnum UPxr_IsVolumeChangeToHomeAndEnter()
		{
			return default(SwitchEnum);
		}

		public static int UPxr_InstallOTAPackage(string otaPackagePath, int ext)
		{
			return 0;
		}

		public static string UPxr_GetAutoConnectWiFiConfig(int ext)
		{
			return null;
		}

		public static string UPxr_GetTimingStartupStatus(int ext)
		{
			return null;
		}

		public static string UPxr_GetTimingShutdownStatus(int ext)
		{
			return null;
		}

		public static int UPxr_GetControllerKeyState(ControllerKeyEnum pxrControllerKey, int ext)
		{
			return 0;
		}

		public static int UPxr_SetControllerKeyState(ControllerKeyEnum controllerKeyEnum, SwitchEnum status, int ext)
		{
			return 0;
		}

		public static SwitchEnum UPxr_ControlGetPowerOffWithUSBCable(int ext)
		{
			return default(SwitchEnum);
		}

		public static ScreenOffDelayTimeEnum UPxr_PropertyGetScreenOffDelay(int ext)
		{
			return default(ScreenOffDelayTimeEnum);
		}

		public static SleepDelayTimeEnum UPxr_PropertyGetSleepDelay(int ext)
		{
			return default(SleepDelayTimeEnum);
		}

		public static string UPxr_PropertyGetPowerKeyStatus(int ext)
		{
			return null;
		}

		public static int UPxr_GetEnterKeyStatus(int ext)
		{
			return 0;
		}

		public static int UPxr_GetVolumeKeyStatus(int ext)
		{
			return 0;
		}

		public static int UPxr_GetBackKeyStatus(int ext)
		{
			return 0;
		}

		public static string UPxr_PropertyGetHomeKeyStatus(HomeEventEnum homeEvent, int ext)
		{
			return null;
		}

		public static void UPxr_GetSwitchSystemFunctionStatus(SystemFunctionSwitchEnum systemFunction, Action<int> callback, int ext)
		{
		}

		public static string UPxr_SwitchGetUsbConfigurationOption(int ext)
		{
			return null;
		}

		public static string UPxr_GetCurrentLauncher(int ext)
		{
			return null;
		}

		public static int UPxr_PICOCastInit(Action<int> callback, int ext)
		{
			return 0;
		}

		public static int UPxr_PICOCastSetShowAuthorization(int authZ, int ext)
		{
			return 0;
		}

		public static int UPxr_PICOCastGetShowAuthorization(int ext)
		{
			return 0;
		}

		public static string UPxr_PICOCastGetUrl(PICOCastUrlTypeEnum urlType, int ext)
		{
			return null;
		}

		public static int UPxr_PICOCastStopCast(int ext)
		{
			return 0;
		}

		public static int UPxr_PICOCastSetOption(PICOCastOptionOrStatusEnum castOptionOrStatus, PICOCastOptionValueEnum castOptionValue, int ext)
		{
			return 0;
		}

		public static PICOCastOptionValueEnum UPxr_PICOCastGetOptionOrStatus(PICOCastOptionOrStatusEnum castOptionOrStatus, int ext)
		{
			return default(PICOCastOptionValueEnum);
		}

		public static int UPxr_SetSystemLanguage(string language, int ext)
		{
			return 0;
		}

		public static string UPxr_GetSystemLanguage(int ext)
		{
			return null;
		}

		public static int UPxr_ConfigWifi(string ssid, string pwd, int ext)
		{
			return 0;
		}

		public static string[] UPxr_GetConfiguredWifi(int ext)
		{
			return null;
		}

		public static int UPxr_SetSystemCountryCode(string countryCode, Action<int> callback, int ext)
		{
			return 0;
		}

		public static string UPxr_GetSystemCountryCode(int ext)
		{
			return null;
		}

		public static int UPxr_SetSkipInitSettingPage(int flag, int ext)
		{
			return 0;
		}

		public static int UPxr_GetSkipInitSettingPage(int ext)
		{
			return 0;
		}

		public static int UPxr_IsInitSettingComplete(int ext)
		{
			return 0;
		}

		public static int UPxr_StartActivity(string packageName, string className, string action, string extra, string[] categories, int[] flags, int ext)
		{
			return 0;
		}

		public static int UPxr_CustomizeAppLibrary(string[] packageNames, SwitchEnum switchEnum, int ext)
		{
			return 0;
		}

		public static int[] UPxr_GetControllerBattery(int ext)
		{
			return null;
		}

		public static int UPxr_GetControllerConnectState(int ext)
		{
			return 0;
		}

		public static string UPxr_GetAppLibraryHideList(int ext)
		{
			return null;
		}

		public static int UPxr_SetScreenCastAudioOutput(ScreencastAudioOutputEnum screencastAudioOutput, int ext)
		{
			return 0;
		}

		public static ScreencastAudioOutputEnum UPxr_GetScreenCastAudioOutput(int ext)
		{
			return default(ScreencastAudioOutputEnum);
		}

		public static int UPxr_CustomizeSettingsTabStatus(CustomizeSettingsTabEnum customizeSettingsTabEnum, SwitchEnum switchEnum, int ext)
		{
			return 0;
		}

		public static SwitchEnum UPxr_GetCustomizeSettingsTabStatus(CustomizeSettingsTabEnum customizeSettingsTabEnum, int ext)
		{
			return default(SwitchEnum);
		}

		public static void UPxr_SetPowerOffWithUSBCable(SwitchEnum switchEnum, int ext)
		{
		}

		public static void UPxr_RemoveControllerHomeKey(HomeEventEnum EventEnum)
		{
		}

		public static void UPxr_SetPowerOnOffLogo(PowerOnOffLogoEnum powerOnOffLogoEnum, string path, Action<bool> callback, int ext)
		{
		}

		public static void UPxr_SetIPD(float ipd, Action<int> callback)
		{
		}

		public static string UPxr_GetAutoMiracastConfig(int ext)
		{
			return null;
		}

		public static int UPxr_SetPicoCastMediaFormat(PicoCastMediaFormat mediaFormat, int ext)
		{
			return 0;
		}

		public static int UPxr_setMarkerInfoCallback(TrackingOriginModeFlags trackingMode, float cameraYOffset, Action<List<MarkerInfo>> mediaFormat)
		{
			return 0;
		}

		private static bool UPxr_GetToken()
		{
			return false;
		}

		public static int UPxr_GetHeadTrackingConfidence()
		{
			return 0;
		}

		public static bool UPxr_OpenVSTCamera()
		{
			return false;
		}

		public static bool UPxr_CloseVSTCamera()
		{
			return false;
		}

		public static int UPxr_GetHeadTrackingData(long predictTime, ref SixDof data, int type)
		{
			return 0;
		}

		public static int UPxr_AcquireVSTCameraFrame(out Frame frame)
		{
			frame = default(Frame);
			return 0;
		}

		public static int UPxr_AcquireVSTCameraFrameAntiDistortion(int width, int height, out Frame frame)
		{
			frame = default(Frame);
			return 0;
		}

		public static Pose ToUnityPose(Pose poseR)
		{
			return default(Pose);
		}

		public static Pose ToRGBCameraPose(RGBCameraParams cameraParams, Pose headPose)
		{
			return default(Pose);
		}

		private static void InitDistortionFrame()
		{
		}

		private static void InitAntiDistortionFrame(int size)
		{
		}

		public static RGBCameraParams UPxr_GetCameraParameters()
		{
			return default(RGBCameraParams);
		}

		public static double UPxr_GetPredictedDisplayTime()
		{
			return 0.0;
		}

		public static SensorState UPxr_GetPredictedMainSensorState(double predictTime)
		{
			return default(SensorState);
		}

		public static int UPxr_gotoSeeThroughFloorSetting(int ext)
		{
			return 0;
		}

		public static int UPxr_fileCopy(string srcPath, string dstPath, FileCopyCallback callback)
		{
			return 0;
		}

		public static void UPxr_IsMapInEffect(string path, Action<int> callback, int ext)
		{
		}

		public static void UPxr_ImportMapByPath(string path, Action<int> callback, int ext)
		{
		}

		public static void UPxr_SetWifiP2PDeviceName(string deviceName, Action<int> callback, int ext)
		{
		}

		public static string UPxr_GetWifiP2PDeviceName(int ext)
		{
			return null;
		}

		public static int UPxr_SetScreenBrightness(int brightness, int ext)
		{
			return 0;
		}

		public static void UPxr_SwitchSystemFunction(int systemFunction, int switchEnum, Action<int> callback, int ext)
		{
		}

		public static int UPxr_SetSystemKeyUsability(int key, int usability)
		{
			return 0;
		}

		public static int UPxr_SetLauncher(string packageName)
		{
			return 0;
		}

		public static int UPxr_SetSystemAutoSleepTime(SleepDelayTimeEnum delayTimeEnum)
		{
			return 0;
		}

		public static int UPxr_OpenTimingStartup(int year, int month, int day, int hour, int minute)
		{
			return 0;
		}

		public static int UPxr_OpenTimingStartup(int hour, int minute, int repeat)
		{
			return 0;
		}

		public static int UPxr_CloseTimingStartup()
		{
			return 0;
		}

		public static int UPxr_OpenTimingShutdown(int year, int month, int day, int hour, int minute)
		{
			return 0;
		}

		public static int UPxr_OpenTimingShutdown(int hour, int minute, int repeat)
		{
			return 0;
		}

		public static int UPxr_CloseTimingShutdown()
		{
			return 0;
		}

		public static int UPxr_SetTimeZone(string timeZone)
		{
			return 0;
		}

		public static void UPxr_AppCopyrightVerify(string packageName, Action<int> callback)
		{
		}

		public static int UPxr_GotoEnvironmentTextureCheck()
		{
			return 0;
		}

		[DllImport("PICO_TOBAPI", CallingConvention = CallingConvention.Cdecl)]
		public static extern float oxr_get_trackingorigin_height();

		public static int UPxr_SetSystemDate(int year, int month, int day)
		{
			return 0;
		}

		public static int UPxr_SetSystemTime(int hourOfDay, int minute, int second)
		{
			return 0;
		}

		public static int UPxr_KeepAliveBackground(int keepAlivePid, int flags, int level)
		{
			return 0;
		}

		public static int UPxr_OpenIPDDetectionPage()
		{
			return 0;
		}

		public static int UPxr_SetFloorHeight(float height)
		{
			return 0;
		}

		public static float UPxr_GetFloorHeight()
		{
			return 0f;
		}

		public static string UPxr_GetTimingStartupStatusTwo(int ext)
		{
			return null;
		}

		public static string UPxr_GetTimingShutDownStatusTwo(int ext)
		{
			return null;
		}

		public static string[] UPxr_GetRunningAppProcesses()
		{
			return null;
		}

		public static string UPxr_GetFocusedApp()
		{
			return null;
		}

		public static string UPxr_StartService(AndroidJavaObject intent)
		{
			return null;
		}

		public static string UPxr_StartForegroundService(AndroidJavaObject intent)
		{
			return null;
		}

		public static int UPxr_SendBroadcast(AndroidJavaObject intent)
		{
			return 0;
		}

		public static int UPxr_SendOrderedBroadcast(AndroidJavaObject intent, string receiverPermission)
		{
			return 0;
		}

		public static int UPxr_SetVirtualEnvironment(string envPath)
		{
			return 0;
		}

		public static string UPxr_GetVirtualEnvironment()
		{
			return null;
		}

		public static void SetUnityActivity()
		{
		}

		public static int UPxr_CreateVirtualDisplay(string displayName, IntPtr surfaceObj, int width, int height, int densityDpi, int flags)
		{
			return 0;
		}

		public static int UPxr_StartApp(int displayId, AndroidJavaObject intent)
		{
			return 0;
		}

		public static int UPxr_ReleaseVirtualDisplay(int displayId)
		{
			return 0;
		}

		public static int UPxr_SetVirtualDisplaySurface(int displayId, IntPtr surfaceObj)
		{
			return 0;
		}

		public static int UPxr_InjectEvent(int displayId, int action, int source, float x, float y)
		{
			return 0;
		}

		public static int UPxr_InjectEvent(int displayId, int action, int source, int keycode)
		{
			return 0;
		}

		public static int UPxr_ResizeVirtualDisplay(int displayId, int width, int height, int densityDpi)
		{
			return 0;
		}

		public static int UPxr_ShowGlobalMessageDialog(Texture2D icon, string title, string body, long time, int gap, int position)
		{
			return 0;
		}

		public static Point3D[] UPxr_GetLargeSpaceBoundsInfo()
		{
			return null;
		}

		public static void UPxr_OpenLargeSpaceQuickMode(int length, int width, int originType, bool openVst, float distance, int timeout, Action<int> callback)
		{
		}

		public static void UPxr_CloseLargeSpaceQuickMode()
		{
		}

		public static void UPxr_SetOriginOfLargeSpaceQuickMode(int originType, bool openVst, float distance, int timeout, Action<int> callback)
		{
		}

		public static void UPxr_SetBoundaryOfLargeSpaceQuickMode(int length, int width, Action<int> callback)
		{
		}

		public static LargeSpaceQuickModeInfo UPxr_GetLargeSpaceQuickModeInfo()
		{
			return null;
		}

		public static int UPxr_StartLeftControllerPair()
		{
			return 0;
		}

		public static int UPxr_MakeLeftControllerUnPair()
		{
			return 0;
		}

		public static int UPxr_StartRightControllerPair()
		{
			return 0;
		}

		public static int UPxr_MakeRightControllerUnPair()
		{
			return 0;
		}

		public static int UPxr_StopControllerPair()
		{
			return 0;
		}

		public static int UPxr_SetControllerPreferHand(bool isLeft)
		{
			return 0;
		}

		public static int UPxr_SetControllerVibrateAmplitude(int value)
		{
			return 0;
		}

		public static int UPxr_SetPowerManageMode(int value)
		{
			return 0;
		}

		public static int UPxr_StartRoomMark()
		{
			return 0;
		}

		public static int UPxr_ClearRoomMark()
		{
			return 0;
		}

		public static int UPxr_ClearEyeTrackData()
		{
			return 0;
		}

		public static int UPxr_SetEyeTrackRate(int value)
		{
			return 0;
		}

		public static int UPxr_SetTrackFrequency(int value)
		{
			return 0;
		}

		public static int UPxr_StartSetSecureBorder()
		{
			return 0;
		}

		public static int UPxr_SetDistanceSensitivity(int value)
		{
			return 0;
		}

		public static int UPxr_SetSpeedSensitivity(int value)
		{
			return 0;
		}

		public static int UPxr_SetMotionTrackerPredictionCoefficient(float value)
		{
			return 0;
		}

		public static float UPxr_GetMotionTrackerPredictionCoefficient()
		{
			return 0f;
		}

		public static int UPxr_StartMotionTrackerApp(int failMode, int avatarMode)
		{
			return 0;
		}

		public static int UPxr_SetSingleEyeSource(bool isLeft)
		{
			return 0;
		}

		public static int UPxr_SetViewVisual(int value)
		{
			return 0;
		}

		public static int UPxr_SetAcceptCastMode(int value)
		{
			return 0;
		}

		public static int UPxr_SetScreenCastMode(int value)
		{
			return 0;
		}

		public static int UPxr_SetScreenRecordShotRatio(int value)
		{
			return 0;
		}

		public static int UPxr_SetScreenResolution(int width, int height)
		{
			return 0;
		}

		public static int UPxr_SetScreenRecordFrameRate(int value)
		{
			return 0;
		}

		public static void UPxr_HideGlobalMessageDialog()
		{
		}

		public static int UPxr_ShowGlobalTipsDialog(Texture2D icon, string title, long time, int position, int bgColor)
		{
			return 0;
		}

		public static void UPxr_HideGlobalTipsDialog()
		{
		}

		public static int UPxr_ShowGlobalBigStatusDialog(Texture2D icon, string title, string body, long time, int gap, int position)
		{
			return 0;
		}

		public static void UPxr_HideGlobalBigStatusDialog()
		{
		}

		public static int UPxr_ShowGlobalSmallStatusDialog(Texture2D icon, string title, long time, int gap, int position)
		{
			return 0;
		}

		public static void UPxr_HideGlobalSmallStatusDialog()
		{
		}

		public static int UPxr_ShowGlobalDialogByType(string type, Texture2D icon, string title, string body, long time, int gap, int position, int bgColor)
		{
			return 0;
		}

		public static void UPxr_HideGlobalDialogByType(string type)
		{
		}

		public static int UPxr_Recenter()
		{
			return 0;
		}

		public static void UPxr_ScanQRCode(Action<string> callback)
		{
		}

		public static int UPxr_OnlineSystemUpdate(SystemUpdateCallback callback)
		{
			return 0;
		}

		public static int UPxr_OfflineSystemUpdate(OffLineSystemUpdateConfig systemUpdateConfig, SystemUpdateCallback callback)
		{
			return 0;
		}
	}
}
