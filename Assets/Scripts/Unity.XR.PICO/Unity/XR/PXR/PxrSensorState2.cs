namespace Unity.XR.PXR
{
	public struct PxrSensorState2
	{
		public int status;

		public PxrPosef pose;

		public PxrPosef globalPose;

		public PxrVector3f angularVelocity;

		public PxrVector3f linearVelocity;

		public PxrVector3f angularAcceleration;

		public PxrVector3f linearAcceleration;

		public ulong poseTimeStampNs;
	}
}
