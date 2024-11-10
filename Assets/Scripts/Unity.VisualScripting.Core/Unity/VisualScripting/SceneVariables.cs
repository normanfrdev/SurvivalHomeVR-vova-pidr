using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.VisualScripting
{
	[Singleton(Name = "VisualScripting SceneVariables", Automatic = true, Persistent = false)]
	[RequireComponent(typeof(Variables))]
	[DisableAnnotation]
	[AddComponentMenu("")]
	[IncludeInSettings(false)]
	public sealed class SceneVariables : MonoBehaviour, ISingleton
	{
		private Variables _variables;

		public Variables variables => null;

		public static SceneVariables Instance(Scene scene)
		{
			return null;
		}

		public static bool InstantiatedIn(Scene scene)
		{
			return false;
		}

		public static VariableDeclarations For(Scene? scene)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
