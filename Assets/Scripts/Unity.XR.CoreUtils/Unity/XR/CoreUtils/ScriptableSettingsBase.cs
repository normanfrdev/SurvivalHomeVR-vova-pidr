using System;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public abstract class ScriptableSettingsBase : ScriptableObject
	{
		private const string k_AbsolutePathMessage = "Path cannot be absolute";

		protected const string PathExceptionMessage = "Exception caught trying to create path.";

		internal const string NullPathMessage = "Path cannot be null";

		internal const string PathWithPeriodMessage = "Path cannot contain the character '.' before or after a directory separator";

		internal const string PathWithInvalidCharacterMessage = "Paths on Windows cannot contain the following characters: ':', '*', '?', '\"', '<', '>', '|'";

		private static readonly char[] k_PathTrimChars;

		private static readonly char[] k_InvalidCharacters;

		private static readonly string[] k_InvalidStrings;

		public static ScriptableSettingsBase GetInstanceByType(Type settingsType)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		protected virtual void OnLoaded()
		{
		}

		internal static bool ValidatePath(string path, out string cleanedPath)
		{
			cleanedPath = null;
			return false;
		}
	}
	public abstract class ScriptableSettingsBase<T> : ScriptableSettingsBase where T : ScriptableObject
	{
		protected static readonly bool HasCustomPath;

		protected static T BaseInstance;

		protected static void Save(string savePathFormat)
		{
		}

		protected static string GetFilePath()
		{
			return null;
		}
	}
}
