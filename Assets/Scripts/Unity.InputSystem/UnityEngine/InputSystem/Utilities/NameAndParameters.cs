using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Utilities
{
	public struct NameAndParameters
	{
		public string name
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ReadOnlyArray<NamedValue> parameters
		{
			[CompilerGenerated]
			readonly get
			{
				return default(ReadOnlyArray<NamedValue>);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public static IEnumerable<NameAndParameters> ParseMultiple(string text)
		{
			return null;
		}

		internal static bool ParseMultiple(string text, ref List<NameAndParameters> list)
		{
			return false;
		}

		internal static string ParseName(string text)
		{
			return null;
		}

		public static NameAndParameters Parse(string text)
		{
			return default(NameAndParameters);
		}

		private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false)
		{
			return default(NameAndParameters);
		}
	}
}
