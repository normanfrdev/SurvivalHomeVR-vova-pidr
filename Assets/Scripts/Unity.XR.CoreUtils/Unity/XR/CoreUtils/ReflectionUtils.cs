using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.XR.CoreUtils
{
	public static class ReflectionUtils
	{
		private static Assembly[] s_Assemblies;

		private static List<Type[]> s_TypesPerAssembly;

		private static List<Dictionary<string, Type>> s_AssemblyTypeMaps;

		private static Assembly[] GetCachedAssemblies()
		{
			return null;
		}

		private static List<Type[]> GetCachedTypesPerAssembly()
		{
			return null;
		}

		private static List<Dictionary<string, Type>> GetCachedAssemblyTypeMaps()
		{
			return null;
		}

		public static void PreWarmTypeCache()
		{
		}

		public static void ForEachAssembly(Action<Assembly> callback)
		{
		}

		public static void ForEachType(Action<Type> callback)
		{
		}

		public static Type FindType(Func<Type, bool> predicate)
		{
			return null;
		}

		public static Type FindTypeByFullName(string fullName)
		{
			return null;
		}

		public static void FindTypesBatch(List<Func<Type, bool>> predicates, List<Type> resultList)
		{
		}

		public static void FindTypesByFullNameBatch(List<string> typeNames, List<Type> resultList)
		{
		}

		public static Type FindTypeInAssemblyByFullName(string assemblyName, string typeName)
		{
			return null;
		}

		public static string NicifyVariableName(string name)
		{
			return null;
		}
	}
}
