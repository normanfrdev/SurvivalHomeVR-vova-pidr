namespace Unity.XR.PXR
{
	public enum PxrSpatialTrackingStateMessage
	{
		Unknown = 0,
		Error = 1,
		Locating = 100,
		Located = 101,
		LocatingFailed = 102,
		LocatingFailedInvalidMap = 103,
		LocatingFailedNoMap = 104,
		LocateStopping = 105,
		LocateStopFailed = 106,
		LocateStopped = 107,
		MapCreating = 108,
		MapCreateFailed = 109,
		MapCreated = 110,
		MapSaving = 111,
		MapSaveFailed = 112,
		MapSaveFailedLowQuality = 113,
		MapSaveFailedInsufficentDiskSpace = 114,
		MapSaved = 115,
		MrEngineStarted = 116,
		MrEngineStopped = 117,
		MrEngineDestroyed = 118,
		MrMapLoss = 119
	}
}
