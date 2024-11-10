namespace Unity.XR.PXR
{
	public struct PxrSpatialAnchorCreateInfo
	{
		public PxrStructureType type;

		public PxrTrackingOrigin baseSpace;

		public PxrPosef pose;

		public double time;
	}
}
