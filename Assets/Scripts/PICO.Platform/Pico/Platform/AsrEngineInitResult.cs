namespace Pico.Platform
{
	public enum AsrEngineInitResult
	{
		Unknown = -999,
		Arch32BitNotSupported = -3,
		InvalidConfig = -2,
		AlreadyInitialized = -1,
		Success = 0
	}
}
