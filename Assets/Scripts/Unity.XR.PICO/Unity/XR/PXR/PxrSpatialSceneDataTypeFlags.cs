namespace Unity.XR.PXR
{
	public enum PxrSpatialSceneDataTypeFlags
	{
		Unknown = 1,
		Floor = 2,
		Ceiling = 4,
		Wall = 8,
		Door = 0x10,
		Window = 0x20,
		Opening = 0x40,
		Object = 0x80
	}
}
