namespace Unity.XR.PICO.TOBSupport
{
	public enum PoseErrorType
	{
		BRIGHT_LIGHT_ERROR = 1,
		LOW_LIGHT_ERROR = 2,
		LOW_FEATURE_COUNT_ERROR = 4,
		CAMERA_CALIBRATION_ERROR = 8,
		RELOCATION_IN_PROGRESS = 0x10,
		INITILIZATION_IN_PROGRESS = 0x20,
		NO_CAMERA_ERROR = 0x40,
		NO_IMU_ERROR = 0x80,
		IMU_JITTER_ERROR = 0x100,
		UNKNOWN_ERROR = 0x200
	}
}