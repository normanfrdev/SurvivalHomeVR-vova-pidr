namespace Pico.Platform
{
	public class SpeechService
	{
		public static AsrEngineInitResult InitAsrEngine()
		{
			return default(AsrEngineInitResult);
		}

		public static int StartAsr(bool autoStop, bool showPunctual, int vadMaxDurationInSeconds)
		{
			return 0;
		}

		public static void StopAsr()
		{
		}

		public static void SetOnAsrResultCallback(Message<Pico.Platform.Models.AsrResult>.Handler handler)
		{
		}

		public static void SetOnSpeechErrorCallback(Message<Pico.Platform.Models.SpeechError>.Handler handler)
		{
		}
	}
}
