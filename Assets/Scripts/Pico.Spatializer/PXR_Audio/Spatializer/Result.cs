namespace PXR_Audio.Spatializer
{
	public enum Result
	{
		Error = -1,
		Success = 0,
		SourceNotFound = -1001,
		SourceDataNotFound = -1002,
		SceneNotFound = -1003,
		SceneMeshNotFound = -1004,
		IllegalValue = -1005,
		ContextNotCreated = -1006,
		ContextNotReady = -1007,
		ContextRepeatedInitialization = -1008,
		EnvironmentalAcousticsDisabled = -1009,
		ApiDisabled = -1010,
		SourceInuse = -1011
	}
}
