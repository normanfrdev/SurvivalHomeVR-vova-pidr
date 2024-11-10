using System;
using UnityEngine;
using UnityEngine.XR.Management;

namespace Unity.XR.PXR
{
	[Serializable]
	[XRConfigurationData("PICO", "Unity.XR.PXR.Settings")]
	public class PXR_Settings : ScriptableObject
	{
		public enum StereoRenderingModeAndroid
		{
			MultiPass = 0,
			Multiview = 1
		}

		public enum SystemDisplayFrequency
		{
			Default = 0,
			RefreshRate72 = 1,
			RefreshRate90 = 2,
			RefreshRate120 = 3
		}

		[SerializeField]
		[Tooltip("Set the Stereo Rendering Method")]
		public StereoRenderingModeAndroid stereoRenderingModeAndroid;

		[SerializeField]
		[Tooltip("Set the system display frequency")]
		public SystemDisplayFrequency systemDisplayFrequency;

		[SerializeField]
		[Tooltip("if enabled,will always discarding depth and resolving MSAA color to improve performance on tile-based architectures. This only affects Vulkan. Note that this may break user content")]
		public bool optimizeBufferDiscards;

		[SerializeField]
		[Tooltip("Enable Application SpaceWarp")]
		public bool enableAppSpaceWarp;

		[SerializeField]
		[Tooltip("Set the system splash screen picture in PNG format. [width,height] < [1024, 1024]")]
		public Texture2D systemSplashScreen;

		private string splashPath;

		public ushort GetStereoRenderingMode()
		{
			return 0;
		}

		public ushort GetSystemDisplayFrequency()
		{
			return 0;
		}

		public ushort GetOptimizeBufferDiscards()
		{
			return 0;
		}
	}
}
