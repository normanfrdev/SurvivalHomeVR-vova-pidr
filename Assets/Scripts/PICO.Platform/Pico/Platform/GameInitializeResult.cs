namespace Pico.Platform
{
	public enum GameInitializeResult
	{
		Success = 0,
		Uninitialized = 1,
		NetworkError = 2,
		InvalidCredentials = 3,
		ServiceNotAvaliable = 4,
		Unknown = 5,
		InvalidServerAddr = 6,
		DupInitialize = 7
	}
}
