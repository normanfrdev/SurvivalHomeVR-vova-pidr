using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.XR.Oculus
{
	public static class NativeMethods
	{
		internal struct UserDefinedSettings
		{
			public ushort sharedDepthBuffer;

			public ushort dashSupport;

			public ushort stereoRenderingMode;

			public ushort colorSpace;

			public ushort lowOverheadMode;

			public ushort optimizeBufferDiscards;

			public ushort symmetricProjection;

			public ushort subsampledLayout;

			public ushort lateLatching;

			public ushort lateLatchingDebug;

			public ushort enableTrackingOriginStageMode;

			public ushort spaceWarp;

			public ushort depthSubmission;

			public ushort foveatedRenderingMethod;
		}

		internal struct EnvironmentDepthFrameDescInternal
		{
			public bool isValid;

			public double createTime;

			public double predictedDisplayTime;

			public int swapchainIndex;

			public Vector3 createPoseLocation;

			public Vector4 createPoseRotation;

			public float fovLeftAngle;

			public float fovRightAngle;

			public float fovTopAngle;

			public float fovDownAngle;

			public float nearZ;

			public float farZ;

			public float minDepth;

			public float maxDepth;
		}

		internal struct EnvironmentDepthCreateParamsInternal
		{
			public bool removeHands;
		}

		private static class Internal
		{
			[DllImport("OculusXRPlugin")]
			internal static extern void SetColorScale(float x, float y, float z, float w);

			[DllImport("OculusXRPlugin")]
			internal static extern void SetColorOffset(float x, float y, float z, float w);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetIsSupportedDevice();

			[DllImport("OculusXRPlugin", CharSet = CharSet.Unicode)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool LoadOVRPlugin(string ovrpPath);

			[DllImport("OculusXRPlugin")]
			internal static extern void UnloadOVRPlugin();

			[DllImport("OculusXRPlugin")]
			internal static extern void SetUserDefinedSettings(UserDefinedSettings settings);

			[DllImport("OculusXRPlugin")]
			internal static extern int SetCPULevel(int cpuLevel);

			[DllImport("OculusXRPlugin")]
			internal static extern int SetGPULevel(int gpuLevel);

			[DllImport("OculusXRPlugin", CharSet = CharSet.Auto)]
			internal static extern void GetOVRPVersion(byte[] version);

			[DllImport("OculusXRPlugin")]
			internal static extern void EnablePerfMetrics([MarshalAs(UnmanagedType.I1)] bool enable);

			[DllImport("OculusXRPlugin")]
			internal static extern void EnableAppMetrics([MarshalAs(UnmanagedType.I1)] bool enable);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool SetDeveloperModeStrict([MarshalAs(UnmanagedType.I1)] bool active);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetAppHasInputFocus();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetBoundaryConfigured();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetBoundaryDimensions(Boundary.BoundaryType boundaryType, out Vector3 dimensions);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetBoundaryVisible();

			[DllImport("OculusXRPlugin")]
			internal static extern void SetBoundaryVisible([MarshalAs(UnmanagedType.I1)] bool boundaryVisible);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetAppShouldQuit();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetDisplayAvailableFrequencies(IntPtr ptr, ref int numFrequencies);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool SetDisplayFrequency(float refreshRate);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetDisplayFrequency(out float refreshRate);

			[DllImport("OculusXRPlugin")]
			internal static extern SystemHeadset GetSystemHeadsetType();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetTiledMultiResSupported();

			[DllImport("OculusXRPlugin")]
			internal static extern void SetTiledMultiResLevel(int level);

			[DllImport("OculusXRPlugin")]
			internal static extern int GetTiledMultiResLevel();

			[DllImport("OculusXRPlugin")]
			internal static extern void SetTiledMultiResDynamic([MarshalAs(UnmanagedType.I1)] bool isDynamic);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetEyeTrackedFoveatedRenderingSupported();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetEyeTrackedFoveatedRenderingEnabled();

			[DllImport("OculusXRPlugin")]
			internal static extern void SetEyeTrackedFoveatedRenderingEnabled([MarshalAs(UnmanagedType.I1)] bool isEnabled);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetShouldRestartSession();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool SetupEnvironmentDepth(ref EnvironmentDepthCreateParamsInternal createParams);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool SetEnvironmentDepthRendering([MarshalAs(UnmanagedType.I1)] bool isEnabled);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool ShutdownEnvironmentDepth();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetEnvironmentDepthTextureId(ref uint id);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetEnvironmentDepthFrameDesc(ref EnvironmentDepthFrameDescInternal frameDesc, int eye);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool SetEnvironmentDepthHandRemoval([MarshalAs(UnmanagedType.I1)] bool isEnabled);

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetEnvironmentDepthSupported();

			[DllImport("OculusXRPlugin")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool GetEnvironmentDepthHandRemovalSupported();
		}

		internal static void SetColorScale(float x, float y, float z, float w)
		{
		}

		internal static void SetColorOffset(float x, float y, float z, float w)
		{
		}

		internal static bool GetIsSupportedDevice()
		{
			return false;
		}

		internal static bool LoadOVRPlugin(string ovrpPath)
		{
			return false;
		}

		internal static void UnloadOVRPlugin()
		{
		}

		internal static void SetUserDefinedSettings(UserDefinedSettings settings)
		{
		}

		internal static int SetCPULevel(int cpuLevel)
		{
			return 0;
		}

		internal static int SetGPULevel(int gpuLevel)
		{
			return 0;
		}

		internal static void GetOVRPVersion(byte[] version)
		{
		}

		internal static void EnablePerfMetrics(bool enable)
		{
		}

		internal static void EnableAppMetrics(bool enable)
		{
		}

		internal static bool SetDeveloperModeStrict(bool active)
		{
			return false;
		}

		internal static bool GetHasInputFocus()
		{
			return false;
		}

		internal static bool GetBoundaryConfigured()
		{
			return false;
		}

		internal static bool GetBoundaryDimensions(Boundary.BoundaryType boundaryType, out Vector3 dimensions)
		{
			dimensions = default(Vector3);
			return false;
		}

		internal static bool GetBoundaryVisible()
		{
			return false;
		}

		internal static void SetBoundaryVisible(bool boundaryVisible)
		{
		}

		internal static bool GetAppShouldQuit()
		{
			return false;
		}

		internal static bool GetDisplayAvailableFrequencies(IntPtr ptr, ref int numFrequencies)
		{
			return false;
		}

		internal static bool SetDisplayFrequency(float refreshRate)
		{
			return false;
		}

		internal static bool GetDisplayFrequency(out float refreshRate)
		{
			refreshRate = default(float);
			return false;
		}

		internal static SystemHeadset GetSystemHeadsetType()
		{
			return default(SystemHeadset);
		}

		internal static bool GetTiledMultiResSupported()
		{
			return false;
		}

		internal static void SetTiledMultiResLevel(int level)
		{
		}

		internal static int GetTiledMultiResLevel()
		{
			return 0;
		}

		internal static void SetTiledMultiResDynamic(bool isDynamic)
		{
		}

		internal static bool GetEyeTrackedFoveatedRenderingSupported()
		{
			return false;
		}

		internal static bool GetEyeTrackedFoveatedRenderingEnabled()
		{
			return false;
		}

		internal static void SetEyeTrackedFoveatedRenderingEnabled(bool isEnabled)
		{
		}

		internal static bool GetShouldRestartSession()
		{
			return false;
		}

		internal static void SetupEnvironmentDepth(Utils.EnvironmentDepthCreateParams createParams)
		{
		}

		internal static void SetEnvironmentDepthRendering(bool isEnabled)
		{
		}

		internal static void ShutdownEnvironmentDepth()
		{
		}

		internal static bool GetEnvironmentDepthTextureId(ref uint id)
		{
			return false;
		}

		internal static Utils.EnvironmentDepthFrameDesc GetEnvironmentDepthFrameDesc(int eye)
		{
			return default(Utils.EnvironmentDepthFrameDesc);
		}

		internal static bool SetEnvironmentDepthHandRemoval(bool isEnabled)
		{
			return false;
		}

		internal static bool GetEnvironmentDepthSupported()
		{
			return false;
		}

		internal static bool GetEnvironmentDepthHandRemovalSupported()
		{
			return false;
		}
	}
}
