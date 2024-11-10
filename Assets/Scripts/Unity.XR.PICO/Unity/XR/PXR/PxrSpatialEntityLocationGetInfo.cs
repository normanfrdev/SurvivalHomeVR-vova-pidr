namespace Unity.XR.PXR
{
	public struct PxrSpatialEntityLocationGetInfo
	{
		public PxrStructureType type;

		public ulong entity;

		public PxrSceneComponentType componentType;

		public ulong baseSpace;

		public ulong time;
	}
}
