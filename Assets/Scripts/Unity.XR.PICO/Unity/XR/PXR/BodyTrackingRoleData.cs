namespace Unity.XR.PXR
{
	public struct BodyTrackingRoleData
	{
		private int apiVersion;

		public BodyTrackerRole role;

		public BodyActionList bodyAction;

		public BodyTrackerTransPose localPose;

		public BodyTrackerTransPose globalPose;

		public unsafe fixed double velo[3];

		public unsafe fixed double acce[3];

		public unsafe fixed double wvelo[3];

		public unsafe fixed double wacce[3];

		public override string ToString()
		{
			return null;
		}
	}
}
