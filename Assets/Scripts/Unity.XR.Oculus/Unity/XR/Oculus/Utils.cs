using System;
using UnityEngine;

namespace Unity.XR.Oculus
{
	public static class Utils
	{
		public struct EnvironmentDepthFrameDesc
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

		public struct EnvironmentDepthCreateParams
		{
			public bool removeHands;
		}

		private static EnvironmentDepthCreateParams s_EnvironmentDepthCreateParams;

		public static bool useDynamicFoveatedRendering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int foveatedRenderingLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool eyeTrackedFoveatedRenderingSupported => false;

		public static bool eyeTrackedFoveatedRenderingEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void SetColorScaleAndOffset(Vector4 colorScale, Vector4 colorOffset)
		{
		}

		public static SystemHeadset GetSystemHeadsetType()
		{
			return default(SystemHeadset);
		}

		private static void ScenePermissionGrantedCallback(string permissionName)
		{
		}

		public static bool IsScenePermissionGranted()
		{
			return false;
		}

		public static void SetupEnvironmentDepth(EnvironmentDepthCreateParams createParams)
		{
		}

		public static void SetEnvironmentDepthRendering(bool isEnabled)
		{
		}

		public static void ShutdownEnvironmentDepth()
		{
		}

		public static bool GetEnvironmentDepthTextureId(ref uint id)
		{
			return false;
		}

		public static EnvironmentDepthFrameDesc GetEnvironmentDepthFrameDesc(int eye)
		{
			return default(EnvironmentDepthFrameDesc);
		}

		public static bool SetEnvironmentDepthHandRemoval(bool isEnabled)
		{
			return false;
		}

		public static bool GetEnvironmentDepthSupported()
		{
			return false;
		}

		public static bool GetEnvironmentDepthHandRemovalSupported()
		{
			return false;
		}

		private static void PermissionGrantedCallback(string permissionName)
		{
		}

		public static bool IsEyeTrackingPermissionGranted()
		{
			return false;
		}

		[Obsolete("Please use foveatedRenderingLevel instead.", false)]
		public static bool SetFoveationLevel(int level)
		{
			return false;
		}

		[Obsolete("Please use useDynamicFoveatedRendering instead", false)]
		public static bool EnableDynamicFFR(bool enable)
		{
			return false;
		}

		[Obsolete("Please use foveatedRenderingLevel instead.", false)]
		public static int GetFoveationLevel()
		{
			return 0;
		}
	}
}
