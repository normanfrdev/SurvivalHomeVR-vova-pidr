namespace Unity.XR.PXR
{
	public struct PxrEventSpatialSceneCaptured
	{
		public ulong taskId;

		public PxrResult result;

		public PxrSpatialSceneCaptureStatus status;
	}
}
