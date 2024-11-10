namespace Unity.XR.PXR
{
	public struct PxrLayerHeader
	{
		public int layerId;

		public uint layerFlags;

		public float colorScaleX;

		public float colorScaleY;

		public float colorScaleZ;

		public float colorScaleW;

		public float colorBiasX;

		public float colorBiasY;

		public float colorBiasZ;

		public float colorBiasW;

		public int compositionDepth;

		public int sensorFrameIndex;

		public int imageIndex;

		public PxrPosef headPose;
	}
}
