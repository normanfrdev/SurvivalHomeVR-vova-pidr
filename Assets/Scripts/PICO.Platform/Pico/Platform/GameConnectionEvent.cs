namespace Pico.Platform
{
	public enum GameConnectionEvent
	{
		Connected = 0,
		Closed = 1,
		Lost = 2,
		Resumed = 3,
		KickedByRelogin = 4,
		KickedByGameServer = 5,
		GameLogicError = 6,
		Unknown = 7
	}
}
