using UnityEngine;

namespace Unity.VisualScripting
{
	[Singleton(Name = "VisualScripting GlobalEventListener", Automatic = true, Persistent = true)]
	[DisableAnnotation]
	[AddComponentMenu("")]
	[IncludeInSettings(false)]
	[TypeIcon(typeof(MessageListener))]
	public sealed class GlobalMessageListener : MonoBehaviour, ISingleton
	{
		private void OnGUI()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnApplicationQuit()
		{
		}

		public static void Require()
		{
		}
	}
}
