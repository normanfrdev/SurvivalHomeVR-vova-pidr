namespace Unity.XR.PXR
{
	public struct MotionTrackerLocation
	{
		public Posef pose;

		public unsafe fixed float angularVelocity[3];

		public unsafe fixed float linearVelocity[3];

		public unsafe fixed float angularAcceleration[3];

		public unsafe fixed float linearAcceleration[3];

		public override string ToString()
		{
			return null;
		}
	}
}
