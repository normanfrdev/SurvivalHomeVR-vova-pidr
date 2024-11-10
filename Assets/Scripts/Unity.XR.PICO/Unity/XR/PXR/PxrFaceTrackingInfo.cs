namespace Unity.XR.PXR
{
	public struct PxrFaceTrackingInfo
	{
		public long timestamp;

		public unsafe fixed float blendShapeWeight[72];

		public unsafe fixed float videoInputValid[10];

		public float laughingProb;

		public unsafe fixed float emotionProb[10];

		public unsafe fixed float reserved[128];
	}
}
