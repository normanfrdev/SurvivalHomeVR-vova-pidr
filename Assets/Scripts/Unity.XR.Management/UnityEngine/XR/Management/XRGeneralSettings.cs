namespace UnityEngine.XR.Management
{
	public class XRGeneralSettings : ScriptableObject
	{
		public static string k_SettingsKey;

		internal static XRGeneralSettings s_RuntimeSettingsInstance;

		[SerializeField]
		internal XRManagerSettings m_LoaderManagerInstance;

		[SerializeField]
		[Tooltip("Toggling this on/off will enable/disable the automatic startup of XR at run time.")]
		internal bool m_InitManagerOnStart;

		private XRManagerSettings m_XRManager;

		private bool m_ProviderIntialized;

		private bool m_ProviderStarted;

		public XRManagerSettings Manager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static XRGeneralSettings Instance => null;

		public XRManagerSettings AssignedSettings => null;

		public bool InitManagerOnStart => false;

		private void Awake()
		{
		}

		private static void Quit()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		internal static void AttemptInitializeXRSDKOnLoad()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		internal static void AttemptStartXRSDKOnBeforeSplashScreen()
		{
		}

		private void InitXRSDK()
		{
		}

		private void StartXRSDK()
		{
		}

		private void StopXRSDK()
		{
		}

		private void DeInitXRSDK()
		{
		}
	}
}
