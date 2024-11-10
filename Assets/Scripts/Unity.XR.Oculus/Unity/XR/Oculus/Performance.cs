namespace Unity.XR.Oculus
{
	public static class Performance
	{
		private static float[] cachedDisplayAvailableFrequencies;

		public static bool TrySetCPULevel(int level)
		{
			return false;
		}

		public static bool TrySetGPULevel(int level)
		{
			return false;
		}

		public static bool TryGetAvailableDisplayRefreshRates(out float[] refreshRates)
		{
			refreshRates = null;
			return false;
		}

		public static bool TrySetDisplayRefreshRate(float refreshRate)
		{
			return false;
		}

		public static bool TryGetDisplayRefreshRate(out float refreshRate)
		{
			refreshRate = default(float);
			return false;
		}
	}
}
