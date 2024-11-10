namespace Unity.XR.PXR
{
	public struct PxrLayerEquirect2
	{
		public PxrLayerHeader2 header;

		public PxrPosef poseLeft;

		public PxrPosef poseRight;

		public float radiusLeft;

		public float radiusRight;

		public float centralHorizontalAngleLeft;

		public float centralHorizontalAngleRight;

		public float upperVerticalAngleLeft;

		public float upperVerticalAngleRight;

		public float lowerVerticalAngleLeft;

		public float lowerVerticalAngleRight;
	}
}
