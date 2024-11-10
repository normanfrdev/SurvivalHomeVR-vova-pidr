namespace Pico.Platform
{
	public enum RtcStreamRemoveReason
	{
		Unpublish = 0,
		PublishFailed = 1,
		KeepLiveFailed = 2,
		ClientDisconnected = 3,
		Republish = 4,
		Other = 5
	}
}
