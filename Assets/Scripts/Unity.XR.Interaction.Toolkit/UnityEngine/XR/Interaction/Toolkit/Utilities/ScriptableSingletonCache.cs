using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal static class ScriptableSingletonCache<T> where T : ScriptableObject
	{
		private static T s_Instance;

		private static readonly Dictionary<ScriptableObject, HashSet<object>> s_UsersPerInstance;

		public static T GetInstance(object user)
		{
			return null;
		}

		public static void ReleaseInstance(object user)
		{
		}
	}
}
