using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public abstract class ScriptableSettings<T> : ScriptableSettingsBase<T> where T : ScriptableObject
	{
		private const string k_CustomSavePathFormat = "{0}Resources/{1}.asset";

		private const string k_SavePathFormat = "{0}Resources/ScriptableSettings/{1}.asset";

		private const string k_LoadPathFormat = "ScriptableSettings/{0}";

		public static T Instance => null;

		internal static T CreateAndLoad()
		{
			return null;
		}

		protected ScriptableSettings()
		{
			((ScriptableSettingsBase<>)(object)this)._002Ector();
		}
	}
}
