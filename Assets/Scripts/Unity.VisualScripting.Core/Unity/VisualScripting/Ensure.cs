using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class Ensure
	{
		private static readonly EnsureThat instance;

		public static bool IsActive
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static void Off()
		{
		}

		public static void On()
		{
		}

		public static EnsureThat That(string paramName)
		{
			return null;
		}

		internal static void OnRuntimeMethodLoad()
		{
		}
	}
}
