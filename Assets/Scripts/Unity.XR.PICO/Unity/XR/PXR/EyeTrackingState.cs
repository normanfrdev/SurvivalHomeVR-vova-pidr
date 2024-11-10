namespace Unity.XR.PXR
{
	public struct EyeTrackingState
	{
		private int apiVersion;

		public EyeTrackingMode currentTrackingMode;

		public TrackingStateCode code;

		public void SetVersion(int version)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
