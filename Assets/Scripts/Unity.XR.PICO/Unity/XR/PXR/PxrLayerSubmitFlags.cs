namespace Unity.XR.PXR
{
	public enum PxrLayerSubmitFlags
	{
		PxrLayerFlagNoCompositionDepthTesting = 8,
		PxrLayerFlagUseExternalHeadPose = 0x20,
		PxrLayerFlagLayerPoseNotInTrackingSpace = 0x40,
		PxrLayerFlagHeadLocked = 0x80,
		PxrLayerFlagUseExternalImageIndex = 0x100,
		PxrLayerFlagPresentationProtection = 0x200,
		PxrLayerFlagSourceAlpha_1_0 = 0x400,
		PxrLayerFlagUseFrameExtrapolation = 0x800,
		PxrLayerFlagQuickSeethrough = 0x1000,
		PxrLayerFlagEnableNormalSuperSampling = 0x2000,
		PxrLayerFlagEnableQualitySuperSampling = 0x4000,
		PxrLayerFlagEnableNormalSharpening = 0x8000,
		PxrLayerFlagEnableQualitySharpening = 0x10000,
		PxrLayerFlagEnableFixedFoveatedSuperSampling = 0x20000,
		PxrLayerFlagEnableFixedFoveatedSharpening = 0x40000,
		PxrLayerFlagEnableSelfAdaptiveSharpening = 0x80000,
		PxrLayerFlagPremultipliedAlpha = 0x100000,
		PxrLayerFlagColorSpaceHdrPQ = 0x400000,
		PxrLayerFlagColorSpaceHdrHLG = 0x800000,
		PxrLayerFlagFixLayer = 0x2000000,
		PxrLayerFlagBlurredQuadModeSmallWindow = 0x4000000,
		PxrLayerFlagBlurredQuadModeImmersion = 0x8000000,
		PxrLayerFlagMRCComposition = 0x40000000
	}
}
