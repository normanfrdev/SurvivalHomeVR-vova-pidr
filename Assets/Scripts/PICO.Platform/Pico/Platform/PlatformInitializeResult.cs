namespace Pico.Platform
{
	public enum PlatformInitializeResult
	{
		Unknown = -999,
		NetError = -6,
		MissingImpl = -5,
		LoadImplFailed = -4,
		InternalError = -3,
		InvalidParams = -2,
		AlreadyInitialized = -1,
		Success = 0
	}
}
