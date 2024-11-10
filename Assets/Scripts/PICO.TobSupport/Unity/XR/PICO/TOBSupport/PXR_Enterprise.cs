using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PICO.TOBSupport
{
	public class PXR_Enterprise
	{
		public static bool InitEnterpriseService(bool isCamera = false)
		{
			return false;
		}

		public static void BindEnterpriseService(Action<bool> callback = null)
		{
		}

		public static void UnBindEnterpriseService()
		{
		}

		public static string StateGetDeviceInfo(SystemInfoEnum type, int ext = 0)
		{
			return null;
		}

		public static void ControlSetDeviceAction(DeviceControlEnum deviceControl, Action<int> callback)
		{
		}

		public static void ControlAPPManager(PackageControlEnum packageControl, string path, Action<int> callback, int ext = 0)
		{
		}

		public static void ControlSetAutoConnectWIFI(string ssid, string pwd, Action<bool> callback, int ext = 0)
		{
		}

		public static void ControlClearAutoConnectWIFI(Action<bool> callback)
		{
		}

		public static void PropertySetHomeKey(HomeEventEnum eventEnum, HomeFunctionEnum function, Action<bool> callback)
		{
		}

		public static void PropertySetHomeKeyAll(HomeEventEnum eventEnum, HomeFunctionEnum function, int timesetup, string pkg, string className, Action<bool> callback)
		{
		}

		public static void PropertyDisablePowerKey(bool isSingleTap, bool enable, Action<int> callback)
		{
		}

		public static void PropertySetScreenOffDelay(ScreenOffDelayTimeEnum timeEnum, Action<int> callback)
		{
		}

		public static void PropertySetSleepDelay(SleepDelayTimeEnum timeEnum)
		{
		}

		public static void SwitchSystemFunction(SystemFunctionSwitchEnum systemFunction, SwitchEnum switchEnum, int ext = 0)
		{
		}

		public static void SwitchSetUsbConfigurationOption(USBConfigModeEnum uSBConfigModeEnum, int ext = 0)
		{
		}

		public static void SetControllerPairTime(ControllerPairTimeEnum timeEnum, Action<int> callback, int ext = 0)
		{
		}

		public static void GetControllerPairTime(Action<int> callback, int ext = 0)
		{
		}

		public static void ScreenOn()
		{
		}

		public static void ScreenOff()
		{
		}

		public static void AcquireWakeLock()
		{
		}

		public static void ReleaseWakeLock()
		{
		}

		public static void EnableEnterKey()
		{
		}

		public static void DisableEnterKey()
		{
		}

		public static void EnableVolumeKey()
		{
		}

		public static void DisableVolumeKey()
		{
		}

		public static void EnableBackKey()
		{
		}

		public static void DisableBackKey()
		{
		}

		public static void ResetAllKeyToDefault(Action<bool> callback)
		{
		}

		public static void SetAPPAsHome(SwitchEnum switchEnum, string packageName)
		{
		}

		public static void KillAppsByPidOrPackageName(int[] pids, string[] packageNames, int ext = 0)
		{
		}

		public static void KillBackgroundAppsWithWhiteList(string[] packageNames, int ext = 0)
		{
		}

		public static void FreezeScreen(bool freeze)
		{
		}

		public static void OpenMiracast()
		{
		}

		public static bool IsMiracastOn()
		{
			return false;
		}

		public static void CloseMiracast()
		{
		}

		public static void StartScan()
		{
		}

		public static void StopScan()
		{
		}

		public static void ConnectWifiDisplay(string modelJson)
		{
		}

		public static void DisConnectWifiDisplay()
		{
		}

		public static void ForgetWifiDisplay(string address)
		{
		}

		public static void RenameWifiDisplay(string address, string newName)
		{
		}

		public static void SetWDModelsCallback(Action<List<WifiDisplayModel>> models)
		{
		}

		public static void SetWDJsonCallback(Action<string> callback)
		{
		}

		public static void UpdateWifiDisplays()
		{
		}

		public static string GetConnectedWD()
		{
			return null;
		}

		public static void SwitchLargeSpaceScene(bool open, Action<bool> callback, int ext = 0)
		{
		}

		public static void GetSwitchLargeSpaceStatus(Action<string> callback, int ext = 0)
		{
		}

		public static bool SaveLargeSpaceMaps(int ext = 0)
		{
			return false;
		}

		public static void ExportMaps(Action<bool> callback, int ext = 0)
		{
		}

		public static void ImportMaps(Action<bool> callback, int ext = 0)
		{
		}

		public static float[] GetCpuUsages()
		{
			return null;
		}

		public static float[] GetDeviceTemperatures(int type, int source)
		{
			return null;
		}

		public static void Capture()
		{
		}

		public static void Record()
		{
		}

		public static void ControlSetAutoConnectWIFIWithErrorCodeCallback(string ssid, string pwd, int ext, Action<int> callback)
		{
		}

		public static void AppKeepAlive(string appPackageName, bool keepAlive, int ext)
		{
		}

		public static void TimingStartup(int year, int month, int day, int hour, int minute, bool open)
		{
		}

		public static void TimingShutdown(int year, int month, int day, int hour, int minute, bool open)
		{
		}

		public static void StartVrSettingsItem(StartVRSettingsEnum settingsEnum, bool hideOtherItem, int ext)
		{
		}

		public static void SwitchVolumeToHomeAndEnter(SwitchEnum switchEnum, int ext)
		{
		}

		public static SwitchEnum IsVolumeChangeToHomeAndEnter()
		{
			return default(SwitchEnum);
		}

		public static int InstallOTAPackage(string otaPackagePath, int ext = 0)
		{
			return 0;
		}

		public static string GetAutoConnectWiFiConfig(int ext = 0)
		{
			return null;
		}

		public static string GetTimingStartupStatus(int ext = 0)
		{
			return null;
		}

		public static string GetTimingShutdownStatus(int ext = 0)
		{
			return null;
		}

		public static int GetControllerKeyState(ControllerKeyEnum pxrControllerKey, int ext = 0)
		{
			return 0;
		}

		public static int SetControllerKeyState(ControllerKeyEnum pxrControllerKey, SwitchEnum status, int ext = 0)
		{
			return 0;
		}

		public static SwitchEnum GetPowerOffWithUSBCable(int ext = 0)
		{
			return default(SwitchEnum);
		}

		public static ScreenOffDelayTimeEnum GetScreenOffDelay(int ext = 0)
		{
			return default(ScreenOffDelayTimeEnum);
		}

		public static SleepDelayTimeEnum GetSleepDelay(int ext = 0)
		{
			return default(SleepDelayTimeEnum);
		}

		public static string GetPowerKeyStatus(int ext = 0)
		{
			return null;
		}

		public static int GetEnterKeyStatus(int ext = 0)
		{
			return 0;
		}

		public static int GetVolumeKeyStatus(int ext = 0)
		{
			return 0;
		}

		public static int GetBackKeyStatus(int ext = 0)
		{
			return 0;
		}

		public static string GetHomeKeyStatus(HomeEventEnum homeEvent, int ext = 0)
		{
			return null;
		}

		public static void GetSwitchSystemFunctionStatus(SystemFunctionSwitchEnum systemFunction, Action<int> callback, int ext = 0)
		{
		}

		public static string GetUsbConfigurationOption(int ext = 0)
		{
			return null;
		}

		public static string GetCurrentLauncher(int ext = 0)
		{
			return null;
		}

		public static int PICOCastInit(Action<int> callback, int ext = 0)
		{
			return 0;
		}

		public static int PICOCastSetShowAuthorization(int authZ, int ext = 0)
		{
			return 0;
		}

		public static int PICOCastGetShowAuthorization(int ext = 0)
		{
			return 0;
		}

		public static string PICOCastGetUrl(PICOCastUrlTypeEnum urlType, int ext = 0)
		{
			return null;
		}

		public static int PICOCastStopCast(int ext = 0)
		{
			return 0;
		}

		public static int PICOCastSetOption(PICOCastOptionOrStatusEnum castOptionOrStatus, PICOCastOptionValueEnum castOptionValue, int ext = 0)
		{
			return 0;
		}

		public static PICOCastOptionValueEnum PICOCastGetOptionOrStatus(PICOCastOptionOrStatusEnum castOptionOrStatus, int ext = 0)
		{
			return default(PICOCastOptionValueEnum);
		}

		public static int SetSystemLanguage(string language, int ext = 0)
		{
			return 0;
		}

		public static string GetSystemLanguage(int ext = 0)
		{
			return null;
		}

		public static int ConfigWifi(string ssid, string pwd, int ext = 0)
		{
			return 0;
		}

		public static string[] GetConfiguredWifi(int ext = 0)
		{
			return null;
		}

		public static int SetSystemCountryCode(string countryCode, Action<int> callback, int ext = 0)
		{
			return 0;
		}

		public static string GetSystemCountryCode(int ext = 0)
		{
			return null;
		}

		public static int SetSkipInitSettingPage(int flag, int ext = 0)
		{
			return 0;
		}

		public static int GetSkipInitSettingPage(int ext = 0)
		{
			return 0;
		}

		public static int IsInitSettingComplete(int ext = 0)
		{
			return 0;
		}

		public static int StartActivity(string packageName, string className, string action, string extra, string[] categories, int[] flags, int ext = 0)
		{
			return 0;
		}

		public static int CustomizeAppLibrary(string[] packageNames, SwitchEnum switchEnum, int ext = 0)
		{
			return 0;
		}

		public static int[] GetControllerBattery(int ext = 0)
		{
			return null;
		}

		public static int GetControllerConnectState(int ext = 0)
		{
			return 0;
		}

		public static string GetAppLibraryHideList(int ext = 0)
		{
			return null;
		}

		public static int SetScreenCastAudioOutput(ScreencastAudioOutputEnum screencastAudioOutput, int ext = 0)
		{
			return 0;
		}

		public static ScreencastAudioOutputEnum GetScreenCastAudioOutput(int ext = 0)
		{
			return default(ScreencastAudioOutputEnum);
		}

		public static int UPxr_CustomizeSettingsTabStatus(CustomizeSettingsTabEnum customizeSettingsTabEnum, SwitchEnum switchEnum, int ext = 0)
		{
			return 0;
		}

		public static SwitchEnum UPxr_GetCustomizeSettingsTabStatus(CustomizeSettingsTabEnum customizeSettingsTabEnum, int ext = 0)
		{
			return default(SwitchEnum);
		}

		public static void SetPowerOffWithUSBCable(SwitchEnum switchEnum, int ext = 0)
		{
		}

		public static void RemoveControllerHomeKey(HomeEventEnum EventEnum)
		{
		}

		public static void SetPowerOnOffLogo(PowerOnOffLogoEnum powerOnOffLogoEnum, string path, Action<bool> callback, int ext = 0)
		{
		}

		public static void SetIPD(float ipd, Action<int> callback)
		{
		}

		public static string GetAutoMiracastConfig(int ext = 0)
		{
			return null;
		}

		public static int SetPicoCastMediaFormat(PicoCastMediaFormat mediaFormat, int ext = 0)
		{
			return 0;
		}

		public static int SetMarkerInfoCallback(TrackingOriginModeFlags trackingMode, float cameraYOffset, Action<List<MarkerInfo>> markerInfos)
		{
			return 0;
		}

		public static bool OpenVSTCamera()
		{
			return false;
		}

		public static bool CloseVSTCamera()
		{
			return false;
		}

		public static RGBCameraParams GetCameraParameters()
		{
			return default(RGBCameraParams);
		}

		public static int GetHeadTrackingConfidence()
		{
			return 0;
		}

		public static int AcquireVSTCameraFrame(out Frame frame)
		{
			frame = default(Frame);
			return 0;
		}

		public static int AcquireVSTCameraFrameAntiDistortion(int width, int height, out Frame frame)
		{
			frame = default(Frame);
			return 0;
		}

		public static double GetPredictedDisplayTime()
		{
			return 0.0;
		}

		public static SensorState GetPredictedMainSensorState(double predictTime)
		{
			return default(SensorState);
		}

		public static int GotoSeeThroughFloorSetting(int ext = 0)
		{
			return 0;
		}

		public static int FileCopy(string srcPath, string dstPath, FileCopyCallback callback)
		{
			return 0;
		}

		public static void IsMapInEffect(string path, Action<int> callback, int ext = 0)
		{
		}

		public static void ImportMapByPath(string path, Action<int> callback, int ext = 0)
		{
		}

		public static void SetWifiP2PDeviceName(string deviceName, Action<int> callback, int ext = 0)
		{
		}

		public static string GetWifiP2PDeviceName(int ext = 0)
		{
			return null;
		}

		public static int SetScreenBrightness(int brightness, int ext = 0)
		{
			return 0;
		}

		public static void SwitchSystemFunction(int systemFunction, int switchEnum, Action<int> callback, int ext = 0)
		{
		}

		public static int SetSystemKeyUsability(int key, int usability)
		{
			return 0;
		}

		public static int SetLauncher(string packageName)
		{
			return 0;
		}

		public static int SetSystemAutoSleepTime(SleepDelayTimeEnum delayTimeEnum)
		{
			return 0;
		}

		public static int OpenTimingStartup(int year, int month, int day, int hour, int minute)
		{
			return 0;
		}

		public static int CloseTimingStartup()
		{
			return 0;
		}

		public static int OpenTimingShutdown(int year, int month, int day, int hour, int minute)
		{
			return 0;
		}

		public static int CloseTimingShutdown()
		{
			return 0;
		}

		public static int SetTimeZone(string timeZone)
		{
			return 0;
		}

		public static void AppCopyrightVerify(string packageName, Action<int> callback)
		{
		}

		public static int GotoEnvironmentTextureCheck()
		{
			return 0;
		}

		public static int SetSystemDate(int year, int month, int day)
		{
			return 0;
		}

		public static int SetSystemTime(int hourOfDay, int minute, int second)
		{
			return 0;
		}

		public static string[] GetRunningAppProcesses()
		{
			return null;
		}

		public static string GetFocusedApp()
		{
			return null;
		}

		public static int KeepAliveBackground(int keepAlivePid, int flags, int level)
		{
			return 0;
		}

		public static int OpenIPDDetectionPage()
		{
			return 0;
		}

		public static int SetFloorHeight(float height)
		{
			return 0;
		}

		public static float GetFloorHeight()
		{
			return 0f;
		}

		public static int OpenTimingShutdown(int hour, int minute, int repeat)
		{
			return 0;
		}

		public static int OpenTimingStartup(int hour, int minute, int repeat)
		{
			return 0;
		}

		public static string GetTimingStartupStatusTwo(int ext = 0)
		{
			return null;
		}

		public static string GetTimingShutDownStatusTwo(int ext = 0)
		{
			return null;
		}

		public static string StartService(Intent intent)
		{
			return null;
		}

		public static string StartService(AndroidJavaObject intent)
		{
			return null;
		}

		public static string StartForegroundService(Intent intent)
		{
			return null;
		}

		public static string StartForegroundService(AndroidJavaObject intent)
		{
			return null;
		}

		public static int SendBroadcast(Intent intent)
		{
			return 0;
		}

		public static int SendBroadcast(AndroidJavaObject intent)
		{
			return 0;
		}

		public static int SendOrderedBroadcast(Intent intent, string receiverPermission = "")
		{
			return 0;
		}

		public static int SendOrderedBroadcast(AndroidJavaObject intent, string receiverPermission = "")
		{
			return 0;
		}

		public static int SetVirtualEnvironment(string envPath)
		{
			return 0;
		}

		public static string GetVirtualEnvironment()
		{
			return null;
		}

		public static int CreateVirtualDisplay(string displayName, IntPtr surfaceObj, int densityDpi, int flags)
		{
			return 0;
		}

		public static int StartApp(int displayId, Intent intent)
		{
			return 0;
		}

		public static int StartApp(int displayId, AndroidJavaObject intent)
		{
			return 0;
		}

		public static int ReleaseVirtualDisplay(int displayId)
		{
			return 0;
		}

		public static int SetVirtualDisplaySurface(int displayId, IntPtr surfaceObj)
		{
			return 0;
		}

		public static int InjectEvent(int displayId, int action, int source, float x, float y)
		{
			return 0;
		}

		public static int InjectEvent(int displayId, int action, int source, int keycode)
		{
			return 0;
		}

		public static int ShowGlobalMessageDialog(Texture2D icon, string title, string body, long time, int gap, int position)
		{
			return 0;
		}

		public static Point3D[] GetLargeSpaceBoundsInfo()
		{
			return null;
		}

		public static void OpenLargeSpaceQuickMode(int length, int width, int originType, bool openVst, float distance, int timeout, Action<int> callback)
		{
		}

		public static void CloseLargeSpaceQuickMode()
		{
		}

		public static void SetOriginOfLargeSpaceQuickMode(int originType, bool openVst, float distance, int timeout, Action<int> callback)
		{
		}

		public static void SetBoundaryOfLargeSpaceQuickMode(int length, int width, Action<int> callback)
		{
		}

		public static LargeSpaceQuickModeInfo GetLargeSpaceQuickModeInfo()
		{
			return null;
		}

		public static int StartLeftControllerPair()
		{
			return 0;
		}

		public static int MakeLeftControllerUnPair()
		{
			return 0;
		}

		public static int StartRightControllerPair()
		{
			return 0;
		}

		public static int MakeRightControllerUnPair()
		{
			return 0;
		}

		public static int StopControllerPair()
		{
			return 0;
		}

		public static int SetControllerPreferHand(bool isLeft)
		{
			return 0;
		}

		public static int SetControllerVibrateAmplitude(int value)
		{
			return 0;
		}

		public static int SetPowerManageMode(int value)
		{
			return 0;
		}

		public static int StartRoomMark()
		{
			return 0;
		}

		public static int ClearRoomMark()
		{
			return 0;
		}

		public static int ClearEyeTrackData()
		{
			return 0;
		}

		public static int SetEyeTrackRate(int value)
		{
			return 0;
		}

		public static int SetTrackFrequency(int value)
		{
			return 0;
		}

		public static int StartSetSecureBorder()
		{
			return 0;
		}

		public static int SetDistanceSensitivity(int value)
		{
			return 0;
		}

		public static int SetSpeedSensitivity(int value)
		{
			return 0;
		}

		public static int SetMotionTrackerPredictionCoefficient(float value)
		{
			return 0;
		}

		public static float GetMotionTrackerPredictionCoefficient()
		{
			return 0f;
		}

		public static int StartMotionTrackerApp(int failMode, int avatarMode)
		{
			return 0;
		}

		public static int SetSingleEyeSource(bool isLeft)
		{
			return 0;
		}

		public static int SetViewVisual(int value)
		{
			return 0;
		}

		public static int SetAcceptCastMode(int value)
		{
			return 0;
		}

		public static int SetScreenCastMode(int value)
		{
			return 0;
		}

		public static int SetScreenRecordShotRatio(int value)
		{
			return 0;
		}

		public static int SetScreenResolution(int width, int height)
		{
			return 0;
		}

		public static int SetScreenRecordFrameRate(int value)
		{
			return 0;
		}

		public static int ShowGlobalTipsDialog(Texture2D icon, string title, long time, int position, int bgColor)
		{
			return 0;
		}

		public static void HideGlobalMessageDialog()
		{
		}

		public static void HideGlobalTipsDialog()
		{
		}

		public static int ShowGlobalBigStatusDialog(Texture2D icon, string title, string body, long time, int gap, int position)
		{
			return 0;
		}

		public static void HideGlobalBigStatusDialog()
		{
		}

		public static int ShowGlobalSmallStatusDialog(Texture2D icon, string title, long time, int gap, int position)
		{
			return 0;
		}

		public static void HideGlobalSmallStatusDialog()
		{
		}

		public static int ShowGlobalDialogByType(string type, Texture2D icon, string title, string body, long time, int gap, int position, int bgColor)
		{
			return 0;
		}

		public static void HideGlobalDialogByType(string type)
		{
		}

		public static int Recenter()
		{
			return 0;
		}

		public static void ScanQRCode(Action<string> callback)
		{
		}

		public static int OnlineSystemUpdate(SystemUpdateCallback callback)
		{
			return 0;
		}

		public static int OfflineSystemUpdate(OffLineSystemUpdateConfig systemUpdateConfig, SystemUpdateCallback callback)
		{
			return 0;
		}
	}
}
