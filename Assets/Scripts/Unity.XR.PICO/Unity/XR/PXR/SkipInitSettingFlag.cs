namespace Unity.XR.PXR
{
	public enum SkipInitSettingFlag
	{
		SkipHandleConnectionTeaching = 1,
		SkipTriggerKeyTeaching = 2,
		SkipLanguage = 4,
		SkipCountry = 8,
		SkipWIFI = 0x10,
		SkipQuickSetting = 0x20
	}
}
