namespace Unity.XR.PXR
{
	public class PXR_FoveationRendering
	{
		private static PXR_FoveationRendering instance;

		public static PXR_FoveationRendering Instance => null;

		public static bool SetFoveationLevel(FoveationLevel level, bool isETFR)
		{
			return false;
		}

		public static FoveationLevel GetFoveationLevel()
		{
			return default(FoveationLevel);
		}

		public static void SetFoveationParameters(float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum)
		{
		}
	}
}
