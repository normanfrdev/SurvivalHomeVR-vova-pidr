using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.HID
{
	public static class HIDSupport
	{
		public struct HIDPageUsage
		{
			public HID.UsagePage page;

			public int usage;

			public HIDPageUsage(HID.UsagePage page, int usage)
			{
			}

			public HIDPageUsage(HID.GenericDesktop usage)
			{
			}
		}

		private static HIDPageUsage[] s_SupportedHIDUsages;

		public static ReadOnlyArray<HIDPageUsage> supportedHIDUsages
		{
			get
			{
				return default(ReadOnlyArray<HIDPageUsage>);
			}
			set
			{
			}
		}

		internal static void Initialize()
		{
		}
	}
}
