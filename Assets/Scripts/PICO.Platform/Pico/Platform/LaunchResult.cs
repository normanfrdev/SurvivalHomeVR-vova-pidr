namespace Pico.Platform
{
	public enum LaunchResult
	{
		Unknown = 0,
		Success = 1,
		FailedRoomFull = 2,
		FailedGameAlreadyStarted = 3,
		FailedRoomNotFound = 4,
		FailedUserDeclined = 5,
		FailedOtherReason = 6
	}
}
