namespace Unity.XR.PXR
{
	public struct PxrEventAnchorEntityLoaded
	{
		public ulong taskId;

		public PxrResult result;

		public uint count;

		public PxrPersistLocation location;
	}
}
