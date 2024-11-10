namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal static class ComponentLocatorUtility<T> where T : Component
	{
		private static T s_ComponentCache;

		internal static T componentCache => null;

		public static T FindOrCreateComponent()
		{
			return null;
		}

		public static T FindComponent()
		{
			return null;
		}

		public static bool TryFindComponent(out T component)
		{
			component = null;
			return false;
		}

		private static T Find()
		{
			return null;
		}
	}
}
