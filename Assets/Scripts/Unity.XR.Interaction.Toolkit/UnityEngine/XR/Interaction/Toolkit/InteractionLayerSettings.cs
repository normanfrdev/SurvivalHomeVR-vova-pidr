using System.Collections.Generic;
using Unity.XR.CoreUtils;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[ScriptableSettingsPath("Assets/XRI/Settings")]
	internal class InteractionLayerSettings : ScriptableSettings<InteractionLayerSettings>, ISerializationCallbackReceiver
	{
		private const string k_DefaultLayerName = "Default";

		internal const int layerSize = 32;

		internal const int builtInLayerSize = 1;

		[SerializeField]
		private string[] m_LayerNames;

		internal bool IsLayerEmpty(int index)
		{
			return false;
		}

		internal void SetLayerNameAt(int index, string layerName)
		{
		}

		internal string GetLayerNameAt(int index)
		{
			return null;
		}

		internal int GetLayer(string layerName)
		{
			return 0;
		}

		internal void GetLayerNamesAndValues(List<string> names, List<int> values)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public InteractionLayerSettings()
		{
			((ScriptableSettings<T>)(object)this)._002Ector();
		}
	}
}
