namespace Unity.XR.PXR
{
	public struct PxrAnchorLocateInfo
	{
		public PxrStructureType type;

		public PxrTrackingOrigin baseSpace;

		public ulong time;

		public ulong anchorHandle;
	}
}
