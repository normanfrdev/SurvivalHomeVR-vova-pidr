namespace PXR_Audio.Spatializer
{
	public enum SourceProperty : uint
	{
		Mode = 1u,
		Position = 2u,
		Orientation = 4u,
		Directivity = 8u,
		VolumetricRadius = 16u,
		VolumetricSpread = 32u,
		SourceGain = 64u,
		ReflectionGain = 128u,
		DopplerOnOff = 256u,
		AttenuationMode = 512u,
		DirectAttenuationCallback = 1024u,
		IndirectAttenuationCallback = 2048u,
		RangeMin = 4096u,
		RangeMax = 8192u,
		All = uint.MaxValue,
		None = 0u
	}
}
