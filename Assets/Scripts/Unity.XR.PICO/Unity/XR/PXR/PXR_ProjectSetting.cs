using System;
using UnityEngine;

namespace Unity.XR.PXR
{
	[Serializable]
	public class PXR_ProjectSetting : ScriptableObject
	{
		public bool useContentProtect;

		public bool handTracking;

		public bool adaptiveHand;

		public bool highFrequencyHand;

		public bool openMRC;

		public bool faceTracking;

		public bool lipsyncTracking;

		public bool eyeTracking;

		public bool eyetrackingCalibration;

		public bool enableETFR;

		public bool latelatching;

		public bool latelatchingDebug;

		public bool enableSubsampled;

		public bool bodyTracking;

		public bool adaptiveResolution;

		public bool stageMode;

		public bool videoSeeThrough;

		public bool spatialAnchor;

		public bool sceneCapture;

		public bool sharedAnchor;

		public bool spatialMesh;

		public PxrMeshLod meshLod;

		public bool superResolution;

		public bool normalSharpening;

		public bool qualitySharpening;

		public bool fixedFoveatedSharpening;

		public bool selfAdaptiveSharpening;

		public bool arFoundation;

		public bool mrSafeguard;

		public bool enableRecommendMSAA;

		public bool recommendSubsamping;

		public bool recommendMSAA;

		public static PXR_ProjectSetting GetProjectConfig()
		{
			return null;
		}
	}
}
