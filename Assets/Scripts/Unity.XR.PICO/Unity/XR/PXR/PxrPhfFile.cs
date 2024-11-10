namespace Unity.XR.PXR
{
	public struct PxrPhfFile
	{
		public string phfVersion;

		public int frameDuration;

		public PxrPhfParams[] patternData_L;

		public PxrPhfParams[] patternData_R;
	}
}
