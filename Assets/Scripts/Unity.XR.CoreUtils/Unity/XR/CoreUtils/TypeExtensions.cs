using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.XR.CoreUtils
{
	public static class TypeExtensions
	{
		private static readonly List<FieldInfo> k_Fields;

		private static readonly List<string> k_TypeNames;

		public static void GetAssignableTypes(this Type type, List<Type> list, Func<Type, bool> predicate = null)
		{
		}

		public static void GetImplementationsOfInterface(this Type type, List<Type> list)
		{
		}

		public static void GetExtensionsOfClass(this Type type, List<Type> list)
		{
		}

		public static void GetGenericInterfaces(this Type type, Type genericInterface, List<Type> interfaces)
		{
		}

		public static PropertyInfo GetPropertyRecursively(this Type type, string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public static FieldInfo GetFieldRecursively(this Type type, string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public static void GetFieldsRecursively(this Type type, List<FieldInfo> fields, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
		{
		}

		public static void GetPropertiesRecursively(this Type type, List<PropertyInfo> fields, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
		{
		}

		public static void GetInterfaceFieldsFromClasses(this IEnumerable<Type> classes, List<FieldInfo> fields, List<Type> interfaceTypes, BindingFlags bindingAttr)
		{
		}

		public static TAttribute GetAttribute<TAttribute>(this Type type, bool inherit = false) where TAttribute : Attribute
		{
			return null;
		}

		public static void IsDefinedGetInheritedTypes<TAttribute>(this Type type, List<Type> types) where TAttribute : Attribute
		{
		}

		public static FieldInfo GetFieldInTypeOrBaseType(this Type type, string fieldName)
		{
			return null;
		}

		public static string GetNameWithGenericArguments(this Type type)
		{
			return null;
		}

		public static string GetNameWithFullGenericArguments(this Type type)
		{
			return null;
		}

		public static string GetFullNameWithGenericArguments(this Type type)
		{
			return null;
		}

		private static string GetFullNameWithGenericArgumentsInternal(this Type type)
		{
			return null;
		}

		public static bool IsAssignableFromOrSubclassOf(this Type checkType, Type baseType)
		{
			return false;
		}

		public static MethodInfo GetMethodRecursively(this Type type, string name, BindingFlags bindingAttr)
		{
			return null;
		}
	}
}
