namespace Unity.XR.PICO.TOBSupport
{
	public class WifiDisplayModel
	{
		public static int STATUS_NOT_CONNECT;

		public static int STATUS_NONE;

		public static int STATUS_SCANNING;

		public static int STATUS_CONNECTING;

		public static int STATUS_AVAILABLE;

		public static int STATUS_NOT_AVAILABLE;

		public static int STATUS_IN_USE;

		public static int STATUS_CONNECTED;

		public string deviceAddress;

		public string deviceName;

		public bool isAvailable;

		public bool canConnect;

		public bool isRemembered;

		public int statusCode;

		public string status;

		public string description;
	}
}
