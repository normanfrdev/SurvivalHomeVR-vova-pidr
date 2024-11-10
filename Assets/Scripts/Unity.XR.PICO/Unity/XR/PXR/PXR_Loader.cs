using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;

namespace Unity.XR.PXR
{
	public class PXR_Loader : XRLoaderHelper
	{
		public delegate Quaternion ConvertRotationWith2VectorDelegate(Vector3 from, Vector3 to);

		internal enum LoaderState
		{
			Uninitialized = 0,
			InitializeAttempted = 1,
			Initialized = 2,
			StartAttempted = 3,
			Started = 4,
			StopAttempted = 5,
			Stopped = 6,
			DeinitializeAttempted = 7
		}

		private const string TAG = "PXR_Loader";

		private static List<XRDisplaySubsystemDescriptor> displaySubsystemDescriptors;

		private static List<XRInputSubsystemDescriptor> inputSubsystemDescriptors;

		private static List<XRMeshSubsystemDescriptor> meshSubsystemDescriptors;

		private List<LoaderState> validLoaderInitStates;

		private List<LoaderState> validLoaderStartStates;

		private List<LoaderState> validLoaderStopStates;

		private List<LoaderState> validLoaderDeinitStates;

		private List<LoaderState> runningStates;

		public XRDisplaySubsystem displaySubsystem => null;

		public XRInputSubsystem inputSubsystem => null;

		public XRMeshSubsystem meshSubsystem => null;

		internal LoaderState currentLoaderState
		{
			[CompilerGenerated]
			get
			{
				return default(LoaderState);
			}
			[CompilerGenerated]
			private set
			{
			}
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

		[MonoPInvokeCallback(typeof(ConvertRotationWith2VectorDelegate))]
		private static Quaternion ConvertRotationWith2Vector(Vector3 from, Vector3 to)
		{
			return default(Quaternion);
		}

		[MonoPInvokeCallback(typeof(EventDataBufferCallBack))]
		private static void EventDataBufferFunction(ref PxrEventDataBuffer eventDB)
		{
		}

		public PXR_Settings GetSettings()
		{
			return null;
		}
	}
}
