namespace Unity.XR.PXR
{
	public struct FaceTrackingData
	{
		private int apiVersion;

		public unsafe float* blendShapeWeight;

		public long timestamp;

		public float laughingProb;

		public byte eyeValid;

		public byte faceValid;

		public void SetVersion(int version)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
