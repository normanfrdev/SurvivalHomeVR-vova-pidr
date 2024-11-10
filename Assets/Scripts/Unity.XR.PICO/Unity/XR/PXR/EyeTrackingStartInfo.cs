namespace Unity.XR.PXR
{
	public struct EyeTrackingStartInfo
	{
		private int apiVersion;

		public byte needCalibration;

		public EyeTrackingMode mode;

		public void SetVersion(int version)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
