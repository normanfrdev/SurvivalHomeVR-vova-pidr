using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;

namespace Unity.XR.Oculus
{
	public class OculusLoader : XRLoaderHelper
	{
		private enum DeviceSupportedResult
		{
			Supported = 0,
			NotSupported = 1,
			ExitApplication = 2
		}

		private static List<XRDisplaySubsystemDescriptor> s_DisplaySubsystemDescriptors;

		private static List<XRInputSubsystemDescriptor> s_InputSubsystemDescriptors;

		public XRDisplaySubsystem displaySubsystem => null;

		public XRInputSubsystem inputSubsystem => null;

		private static DeviceSupportedResult IsDeviceSupported()
		{
			return default(DeviceSupportedResult);
		}

		public override bool Initialize()
		{
			return false;
		}

		public override bool Start()
		{
			return false;
		}

		public override bool Stop()
		{
			return false;
		}

		public override bool Deinitialize()
		{
			return false;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void RuntimeLoadOVRPlugin()
		{
		}

		public OculusSettings GetSettings()
		{
			return null;
		}

		private bool CheckUnityVersionCompatibility()
		{
			return false;
		}
	}
}
