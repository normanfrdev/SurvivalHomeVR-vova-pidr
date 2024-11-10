namespace PXR_Audio.Spatializer
{
	internal enum MeshProperty : uint
	{
		Enabled = 1u,
		Material = 2u,
		Absorption = 4u,
		Scattering = 8u,
		Transmission = 16u,
		ToWorldTransform = 32u,
		All = uint.MaxValue,
		None = 0u
	}
}
