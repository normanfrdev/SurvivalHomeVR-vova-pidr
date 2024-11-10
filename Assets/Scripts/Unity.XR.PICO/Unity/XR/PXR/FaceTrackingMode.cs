using UnityEngine;

namespace Unity.XR.PXR
{
	public enum FaceTrackingMode
	{
		[InspectorName("None")]
		PXR_FTM_NONE = -1,
		[InspectorName("Face Only")]
		PXR_FTM_FACE = 0,
		[InspectorName("Lipsync Only")]
		PXR_FTM_LIPS = 1,
		[InspectorName("Hybrid Viseme")]
		PXR_FTM_FACE_LIPS_VIS = 2,
		[InspectorName("Hybrid BlendShape")]
		PXR_FTM_FACE_LIPS_BS = 3
	}
}
