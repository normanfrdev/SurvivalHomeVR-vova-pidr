namespace Unity.XR.PXR
{
	public enum BodyTrackingGetDataFlags
	{
		PXR_BODY_NONE = 0,
		PXR_BODY_POSE = 1,
		PXR_BODY_ACTION = 2,
		PXR_BODY_VELO_ACC = 4,
		PXR_BODY_MAX_ENUM = int.MaxValue
	}
}
