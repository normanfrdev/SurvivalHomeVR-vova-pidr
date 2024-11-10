namespace Unity.XR.PXR
{
	public struct EyePupilInfo
	{
		public float leftEyePupilDiameter;

		public float rightEyePupilDiameter;

		public unsafe fixed float leftEyePupilPosition[2];

		public unsafe fixed float rightEyePupilPosition[2];

		public override string ToString()
		{
			return null;
		}
	}
}
