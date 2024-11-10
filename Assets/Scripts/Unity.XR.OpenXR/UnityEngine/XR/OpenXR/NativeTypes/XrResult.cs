namespace UnityEngine.XR.OpenXR.NativeTypes
{
	public enum XrResult
	{
		Success = 0,
		TimeoutExpored = 1,
		LossPending = 3,
		EventUnavailable = 4,
		SpaceBoundsUnavailable = 7,
		SessionNotFocused = 8,
		FrameDiscarded = 9,
		ValidationFailure = -1,
		RuntimeFailure = -2,
		OutOfMemory = -3,
		ApiVersionUnsupported = -4,
		InitializationFailed = -6,
		FunctionUnsupported = -7,
		FeatureUnsupported = -8,
		ExtensionNotPresent = -9,
		LimitReached = -10,
		SizeInsufficient = -11,
		HandleInvalid = -12,
		InstanceLost = -13,
		SessionRunning = -14,
		SessionNotRunning = -16,
		SessionLost = -17,
		SystemInvalid = -18,
		PathInvalid = -19,
		PathCountExceeded = -20,
		PathFormatInvalid = -21,
		PathUnsupported = -22,
		LayerInvalid = -23,
		LayerLimitExceeded = -24,
		SwapchainRectInvalid = -25,
		SwapchainFormatUnsupported = -26,
		ActionTypeMismatch = -27,
		SessionNotReady = -28,
		SessionNotStopping = -29,
		TimeInvalid = -30,
		ReferenceSpaceUnsupported = -31,
		FileAccessError = -32,
		FileContentsInvalid = -33,
		FormFactorUnsupported = -34,
		FormFactorUnavailable = -35,
		ApiLayerNotPresent = -36,
		CallOrderInvalid = -37,
		GraphicsDeviceInvalid = -38,
		PoseInvalid = -39,
		IndexOutOfRange = -40,
		ViewConfigurationTypeUnsupported = -41,
		EnvironmentBlendModeUnsupported = -42,
		NameDuplicated = -44,
		NameInvalid = -45,
		ActionsetNotAttached = -46,
		ActionsetsAlreadyAttached = -47,
		LocalizedNameDuplicated = -48,
		LocalizedNameInvalid = -49,
		AndroidThreadSettingsIdInvalidKHR = -1000003000,
		AndroidThreadSettingsdFailureKHR = -1000003001,
		CreateSpatialAnchorFailedMSFT = -1000039001,
		SecondaryViewConfigurationTypeNotEnabledMSFT = -1000053000,
		MaxResult = int.MaxValue
	}
}
