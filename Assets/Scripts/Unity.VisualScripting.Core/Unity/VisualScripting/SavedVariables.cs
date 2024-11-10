using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class SavedVariables
	{
		public const string assetPath = "SavedVariables";

		public const string playerPrefsKey = "LudiqSavedVariables";

		private static VariablesAsset _asset;

		public static VariablesAsset asset => null;

		public static VariableDeclarations initial => null;

		public static VariableDeclarations saved
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

		public static VariableDeclarations merged
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

		public static void SaveDeclarations(VariableDeclarations declarations)
		{
		}

		public static void FetchSavedDeclarations()
		{
		}

		private static void MergeInitialAndSavedDeclarations()
		{
		}

		private static void DestroyMergedDeclarations()
		{
		}

		private static void WarnAndNullifyUnityObjectReferences(VariableDeclarations declarations)
		{
		}
	}
}
