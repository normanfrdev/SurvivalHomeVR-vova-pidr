namespace Unity.XR.PXR
{
	public struct PxrLayerEac2
	{
		public PxrLayerHeader2 header;

		public PxrPosef poseLeft;

		public PxrPosef poseRight;

		public PxrVector3f offsetPosLeft;

		public PxrVector3f offsetPosRight;

		public PxrVector4f offsetRotLeft;

		public PxrVector4f offsetRotRight;

		public uint degreeType;

		public float overlapFactor;

		public ulong timestamp;
	}
}
