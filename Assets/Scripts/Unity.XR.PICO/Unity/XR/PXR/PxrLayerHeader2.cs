namespace Unity.XR.PXR
{
	public struct PxrLayerHeader2
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

		public PXR_OverLay.OverlayShape layerShape;

		public uint useLayerBlend;

		public PxrLayerBlend layerBlend;

		public uint useImageRect;

		public PxrRecti imageRectLeft;

		public PxrRecti imageRectRight;

		public ulong reserved0;

		public ulong reserved1;

		public ulong reserved2;

		public ulong reserved3;
	}
}
