namespace Unity.XR.PXR
{
	public struct FaceTrackingState
	{
		private int apiVersion;

		public FaceTrackingMode currentTrackingMode;

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
