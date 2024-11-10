namespace Unity.XR.PXR
{
	public struct PxrEventSenseDataProviderStateChanged
	{
		public ulong providerHandle;

		public PxrSenseDataProviderState newState;
	}
}
