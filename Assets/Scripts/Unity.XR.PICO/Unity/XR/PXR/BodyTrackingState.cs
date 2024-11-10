namespace Unity.XR.PXR
{
	public struct BodyTrackingState
	{
		private int apiVersion;

		private int currentTrackingMode;

		public TrackingStateCode code;

		public BodyTrackingStatusCode stateCode;

		public BodyTrackingErrorCode errorCode;

		public byte connectedBandCount;

		public unsafe fixed byte motionTracker[12];

		public override string ToString()
		{
			return null;
		}
	}
}
