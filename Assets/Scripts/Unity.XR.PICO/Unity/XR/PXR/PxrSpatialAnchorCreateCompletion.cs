namespace Unity.XR.PXR
{
	public struct PxrSpatialAnchorCreateCompletion
	{
		public PxrStructureType type;

		public PxrResult futureResult;

		public ulong anchorHandle;

		public PxrUuid uuid;
	}
}
