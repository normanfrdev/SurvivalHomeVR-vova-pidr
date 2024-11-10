using UnityEngine;

namespace Unity.VisualScripting
{
	[Singleton(Name = "VisualScripting SavedVariablesSerializer", Automatic = true, Persistent = true)]
	[AddComponentMenu("")]
	[DisableAnnotation]
	[IncludeInSettings(false)]
	public class VariablesSaver : MonoBehaviour, ISingleton
	{
		public static VariablesSaver instance => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnApplicationPause(bool isPaused)
		{
		}

		public static void Instantiate()
		{
		}
	}
}
