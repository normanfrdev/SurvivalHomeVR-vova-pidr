using System;

namespace Unity.XR.PXR
{
	public struct PxrLayerParam
	{
		public int layerId;

		public PXR_OverLay.OverlayShape layerShape;

		public PXR_OverLay.OverlayType layerType;

		public PXR_OverLay.LayerLayout layerLayout;

		public ulong format;

		public uint width;

		public uint height;

		public uint sampleCount;

		public uint faceCount;

		public uint arraySize;

		public uint mipmapCount;

		public uint layerFlags;

		public uint externalImageCount;

		public IntPtr leftExternalImages;

		public IntPtr rightExternalImages;
	}
}
