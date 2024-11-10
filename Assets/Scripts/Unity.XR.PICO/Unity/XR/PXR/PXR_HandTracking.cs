namespace Unity.XR.PXR
{
	public static class PXR_HandTracking
	{
		public static bool GetSettingState()
		{
			return false;
		}

		public static ActiveInputDevice GetActiveInputDevice()
		{
			return default(ActiveInputDevice);
		}

		public static bool GetAimState(HandType hand, ref HandAimState aimState)
		{
			return false;
		}

		public static bool GetJointLocations(HandType hand, ref HandJointLocations jointLocations)
		{
			return false;
		}

		public static bool GetHandScale(HandType hand, ref float scale)
		{
			return false;
		}
	}
}
