using UnityEngine;

namespace Unity.VisualScripting
{
	[Singleton(Name = "VisualScripting CoroutineRunner", Automatic = true, Persistent = true)]
	[AddComponentMenu("")]
	[DisableAnnotation]
	[IncludeInSettings(false)]
	public sealed class CoroutineRunner : MonoBehaviour, ISingleton
	{
		public static CoroutineRunner instance => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
