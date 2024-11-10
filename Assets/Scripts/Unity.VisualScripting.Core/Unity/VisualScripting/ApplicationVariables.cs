using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class ApplicationVariables
	{
		public const string assetPath = "ApplicationVariables";

		private static VariablesAsset _asset;

		public static VariablesAsset asset => null;

		public static VariableDeclarations runtime
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static VariableDeclarations initial => null;

		public static VariableDeclarations current => null;

		public static void Load()
		{
		}

		public static void OnEnterEditMode()
		{
		}

		public static void OnExitEditMode()
		{
		}

		internal static void OnEnterPlayMode()
		{
		}

		internal static void OnExitPlayMode()
		{
		}

		private static void CreateRuntimeDeclarations()
		{
		}

		private static void DestroyRuntimeDeclarations()
		{
		}
	}
}
