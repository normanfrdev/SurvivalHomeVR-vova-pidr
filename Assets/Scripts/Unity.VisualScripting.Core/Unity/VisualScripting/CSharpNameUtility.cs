using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.VisualScripting
{
	public static class CSharpNameUtility
	{
		private static readonly Dictionary<Type, string> primitives;

		public static readonly Dictionary<string, string> operators;

		private static readonly HashSet<char> illegalTypeFileNameCharacters;

		public static string CSharpName(this MemberInfo member, ActionDirection direction)
		{
			return null;
		}

		public static string CSharpName(this Type type, bool includeGenericParameters = true)
		{
			return null;
		}

		public static string CSharpFullName(this Type type, bool includeGenericParameters = true)
		{
			return null;
		}

		public static string CSharpUniqueName(this Type type, bool includeGenericParameters = true)
		{
			return null;
		}

		public static string CSharpFileName(this Type type, bool includeNamespace, bool includeGenericParameters = false)
		{
			return null;
		}

		private static string CSharpName(this Type type, TypeQualifier qualifier, bool includeGenericParameters = true)
		{
			return null;
		}
	}
}
