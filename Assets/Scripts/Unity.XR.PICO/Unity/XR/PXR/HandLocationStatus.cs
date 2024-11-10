namespace Unity.XR.PXR
{
	public enum HandLocationStatus : ulong
	{
		OrientationValid = 1uL,
		PositionValid = 2uL,
		OrientationTracked = 4uL,
		PositionTracked = 8uL
	}
}
