using System;
using UnityEngine;
using UnityEngine.XR.Management;

namespace Unity.XR.Oculus
{
	[Serializable]
	[XRConfigurationData("Oculus", "Unity.XR.Oculus.Settings")]
	public class OculusSettings : ScriptableObject
	{
		public enum StereoRenderingModeDesktop
		{
			MultiPass = 0,
			SinglePassInstanced = 1
		}

		public enum StereoRenderingModeAndroid
		{
			MultiPass = 0,
			Multiview = 2
		}

		public enum FoveationMethod
		{
			FixedFoveatedRendering = 0,
			EyeTrackedFoveatedRendering = 1
		}

		[SerializeField]
		[Tooltip("The current stereo rendering mode selected for desktop-based Oculus platforms.")]
		public StereoRenderingModeDesktop m_StereoRenderingModeDesktop;

		[SerializeField]
		[Tooltip("The current stereo rendering mode selected for Android-based Oculus platforms.")]
		public StereoRenderingModeAndroid m_StereoRenderingModeAndroid;

		[SerializeField]
		[Tooltip("Allows Unity and the Oculus runtime to share a common depth buffer for better scene integration with the Dash.")]
		public bool SharedDepthBuffer;

		[SerializeField]
		[Tooltip("Enables support for submitting the depth buffer on mobile. This allows for depth testing between layers on mobile Oculus platforms.")]
		public bool DepthSubmission;

		[SerializeField]
		[Tooltip("Initialize the Oculus Plugin with Dash support which allows the Oculus Dash to composite over the Unity application.")]
		public bool DashSupport;

		[SerializeField]
		[Tooltip("If enabled, the GLES graphics driver will bypass validation code, potentially running faster at the expense of detecting and reporting errors. GLES only.")]
		public bool LowOverheadMode;

		[SerializeField]
		[Tooltip("If enabled, the depth buffer and MSAA contents will be discarded rather than resolved. This is an optimization that can possibly break rendering in certain cases. Vulkan only.")]
		public bool OptimizeBufferDiscards;

		[SerializeField]
		[Tooltip("Enables a latency optimization technique which can reduce simulation latency by several ms, depending on application workload. Note: Phase Sync is now always active and this setting has been deprecated.")]
		[Obsolete("Phase Sync is always active and this setting has been deprecated", false)]
		public bool PhaseSync;

		[SerializeField]
		[Tooltip("Allows the application to render with symmetric projection matrices.")]
		public bool SymmetricProjection;

		[SerializeField]
		[Tooltip("Enables a subsampled eye texture layout, which can improve performance when using FFR and reduce FFR related artifacts. Vulkan and Quest 2/Quest Pro only.")]
		public bool SubsampledLayout;

		[SerializeField]
		[Tooltip("Choose which foveated rendering method is used when foveation is enabled.")]
		public FoveationMethod FoveatedRenderingMethod;

		[SerializeField]
		[Tooltip("Reduces tracked rendering latency by updating head and controller poses as late as possible before rendering. Vulkan only.")]
		public bool LateLatching;

		[SerializeField]
		[Tooltip("Debug mode for Late Latching which will print information about the Late Latching system as well as any errors.")]
		public bool LateLatchingDebug;

		[SerializeField]
		[Tooltip("When the Tracking Origin Mode is set to Floor, the tracking origin won't change with a system recenter.")]
		public bool EnableTrackingOriginStageMode;

		[SerializeField]
		[Tooltip("A frame synthesis technology to allow your application to render at half frame rate, while still delivering a smooth experience. Note that this currently requires a custom version of the URP provided by Oculus in order to work, and should not be enabled if you aren't using that customized Oculus URP package.")]
		public bool SpaceWarp;

		[SerializeField]
		[Tooltip("Adds a Quest 2 entry to the supported devices list in the Android manifest.")]
		public bool TargetQuest2;

		[SerializeField]
		[Tooltip("Adds a Quest Pro entry to the supported devices list in the Android manifest.")]
		public bool TargetQuestPro;

		[SerializeField]
		[Tooltip("Adds a Quest 3 entry to the supported devices list in the Android manifest.")]
		public bool TargetQuest3;

		[SerializeField]
		[Tooltip("Adds a PNG under the Assets folder as the system splash screen image. If set, the OS will display the system splash screen as a high quality compositor layer as soon as the app is starting to launch until the app submits the first frame.")]
		public Texture2D SystemSplashScreen;

		public static OculusSettings s_Settings;

		public ushort GetStereoRenderingMode()
		{
			return 0;
		}

		public void Awake()
		{
		}
	}
}
