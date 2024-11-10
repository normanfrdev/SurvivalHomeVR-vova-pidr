namespace Unity.XR.PXR
{
	public enum PxrLayerCreateFlags
	{
		PxrLayerFlagAndroidSurface = 1,
		PxrLayerFlagProtectedContent = 2,
		PxrLayerFlagStaticImage = 4,
		PxrLayerFlagUseExternalImages = 0x10,
		PxrLayerFlag3DLeftRightSurface = 0x20,
		PxrLayerFlag3DTopBottomSurface = 0x40,
		PxrLayerFlagEnableFrameExtrapolation = 0x80,
		PxrLayerFlagEnableSubsampled = 0x100,
		PxrLayerFlagEnableFrameExtrapolationPTW = 0x200,
		PxrLayerFlagSharedImagesBetweenLayers = 0x400
	}
}
