using Unity.XR.CoreUtils;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
	[ScriptableSettingsPath("Assets/XRI/Settings")]
	internal class XRDeviceSimulatorSettings : ScriptableSettings<XRDeviceSimulatorSettings>
	{
		[SerializeField]
		private bool m_AutomaticallyInstantiateSimulatorPrefab;

		[SerializeField]
		private bool m_AutomaticallyInstantiateInEditorOnly;

		[SerializeField]
		private GameObject m_SimulatorPrefab;

		internal bool automaticallyInstantiateSimulatorPrefab
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool automaticallyInstantiateInEditorOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal GameObject simulatorPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRDeviceSimulatorSettings()
		{
			((ScriptableSettings<T>)(object)this)._002Ector();
		}
	}
}
