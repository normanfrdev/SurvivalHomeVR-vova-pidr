namespace Unity.XR.PXR
{
	public enum HandAimStatus : ulong
	{
		AimComputed = 1uL,
		AimRayValid = 2uL,
		AimIndexPinching = 4uL,
		AimMiddlePinching = 8uL,
		AimRingPinching = 0x10uL,
		AimLittlePinching = 0x20uL,
		AimRayTouched = 0x200uL
	}
}
