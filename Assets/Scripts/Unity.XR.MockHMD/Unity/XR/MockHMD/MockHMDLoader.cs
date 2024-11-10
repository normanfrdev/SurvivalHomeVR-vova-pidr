using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine.XR.Management;

namespace Unity.XR.MockHMD
{
	public class MockHMDLoader : XRLoaderHelper
	{
		private static List<XRDisplaySubsystemDescriptor> s_DisplaySubsystemDescriptors;

		private static List<XRInputSubsystemDescriptor> s_InputSubsystemDescriptors;

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
	}
}
