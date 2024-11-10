using System;
using System.Collections.Generic;

namespace Unity.VisualScripting.FullSerializer
{
	public class fsAotCompilationManager
	{
		private struct AotCompilation
		{
			public Type Type;

			public fsMetaProperty[] Members;

			public bool IsConstructorPublic;
		}

		private static Dictionary<Type, string> _computedAotCompilations;

		private static List<AotCompilation> _uncomputedAotCompilations;

		public static Dictionary<Type, string> AvailableAotCompilations => null;

		public static bool TryToPerformAotCompilation(fsConfig config, Type type, out string aotCompiledClassInCSharp)
		{
			aotCompiledClassInCSharp = null;
			return false;
		}

		public static void AddAotCompilation(Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
		}

		private static string GetConverterString(fsMetaProperty member)
		{
			return null;
		}

		private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
			return null;
		}
	}
}
