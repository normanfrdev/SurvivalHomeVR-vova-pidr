namespace Unity.XR.PXR
{
	public struct PerEyeData
	{
		private int apiVersion;

		public PxrPose pose;

		public byte isPoseValid;

		public float openness;

		public byte isOpennessValid;

		public void SetVersion(int version)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
