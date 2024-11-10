using Pico.Platform.Models;

namespace Pico.Platform
{
	public class HighlightService
	{
		public static Task<string> StartSession()
		{
			return null;
		}

		public static Task<CaptureInfo> CaptureScreen()
		{
			return null;
		}

		public static Task StartRecord()
		{
			return null;
		}

		public static Task<RecordInfo> StopRecord()
		{
			return null;
		}

		public static Task<SessionMedia> ListMedia(string sessionId)
		{
			return null;
		}

		public static Task SaveMedia(string jobId, string sessionId)
		{
			return null;
		}

		public static Task ShareMedia(string jobId, string sessionId)
		{
			return null;
		}

		public static void SetOnRecordStopHandler(Message<RecordInfo>.Handler handler)
		{
		}
	}
}
