namespace Unity.XR.PXR
{
	public enum PxrTrackingState
	{
		LostNoReason = 0,
		LostCamera = 1,
		LostHighLight = 2,
		LostLowLight = 3,
		LostLowFeatureCount = 4,
		LostReLocation = 5,
		LostInitialization = 6,
		LostNoCamera = 7,
		LostNoIMU = 8,
		LostIMUJitter = 9,
		LostUnknown = 10
	}
}
