using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class MemberUtility
	{
		[CompilerGenerated]
		private sealed class _003CGetInheritedExtensionMethods_003Ed__8 : IEnumerable<MethodInfo>, IEnumerable, IEnumerator<MethodInfo>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private MethodInfo _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Type thisArgumentType;

			public Type _003C_003E3__thisArgumentType;

			private MethodInfo[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			MethodInfo IEnumerator<MethodInfo>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetInheritedExtensionMethods_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<MethodInfo> IEnumerable<MethodInfo>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly Lazy<ExtensionMethodCache> ExtensionMethodsCache;

		private static readonly Lazy<Dictionary<Type, MethodInfo[]>> InheritedExtensionMethodsCache;

		private static readonly Lazy<HashSet<MethodInfo>> GenericExtensionMethods;

		static MemberUtility()
		{
		}

		public static bool IsOperator(this MethodInfo method)
		{
			return false;
		}

		public static bool IsUserDefinedConversion(this MethodInfo method)
		{
			return false;
		}

		public static MethodInfo MakeGenericMethodVia(this MethodInfo openConstructedMethod, params Type[] closedConstructedParameterTypes)
		{
			return null;
		}

		public static bool IsGenericExtension(this MethodInfo methodInfo)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGetInheritedExtensionMethods_003Ed__8))]
		private static IEnumerable<MethodInfo> GetInheritedExtensionMethods(Type thisArgumentType)
		{
			return null;
		}

		public static IEnumerable<MethodInfo> GetExtensionMethods(this Type thisArgumentType, bool inherited = true)
		{
			return null;
		}

		public static bool IsExtension(this MethodInfo methodInfo)
		{
			return false;
		}

		public static bool IsExtensionMethod(this MemberInfo memberInfo)
		{
			return false;
		}

		public static Delegate CreateDelegate(this MethodInfo methodInfo, Type delegateType)
		{
			return null;
		}

		public static bool IsAccessor(this MemberInfo memberInfo)
		{
			return false;
		}

		public static Type GetAccessorType(this MemberInfo memberInfo)
		{
			return null;
		}

		public static bool IsPubliclyGettable(this MemberInfo memberInfo)
		{
			return false;
		}

		private static Type ExtendedDeclaringType(this MemberInfo memberInfo)
		{
			return null;
		}

		public static Type ExtendedDeclaringType(this MemberInfo memberInfo, bool invokeAsExtension)
		{
			return null;
		}

		public static bool IsStatic(this PropertyInfo propertyInfo)
		{
			return false;
		}

		public static bool IsStatic(this MemberInfo memberInfo)
		{
			return false;
		}

		private static IEnumerable<ParameterInfo> GetParametersWithoutThis(this MethodBase methodBase)
		{
			return null;
		}

		public static bool IsInvokedAsExtension(this MethodBase methodBase, Type targetType)
		{
			return false;
		}

		public static IEnumerable<ParameterInfo> GetInvocationParameters(this MethodBase methodBase, bool invokeAsExtension)
		{
			return null;
		}

		public static IEnumerable<ParameterInfo> GetInvocationParameters(this MethodBase methodBase, Type targetType)
		{
			return null;
		}

		public static Type UnderlyingParameterType(this ParameterInfo parameterInfo)
		{
			return null;
		}

		public static bool HasDefaultValue(this ParameterInfo parameterInfo)
		{
			return false;
		}

		public static object DefaultValue(this ParameterInfo parameterInfo)
		{
			return null;
		}

		public static object PseudoDefaultValue(this ParameterInfo parameterInfo)
		{
			return null;
		}

		public static bool AllowsNull(this ParameterInfo parameterInfo)
		{
			return false;
		}

		public static bool HasOutModifier(this ParameterInfo parameterInfo)
		{
			return false;
		}

		public static bool CanWrite(this FieldInfo fieldInfo)
		{
			return false;
		}

		public static Member ToManipulator(this MemberInfo memberInfo)
		{
			return null;
		}

		public static Member ToManipulator(this MemberInfo memberInfo, Type targetType)
		{
			return null;
		}

		public static Member ToManipulator(this FieldInfo fieldInfo, Type targetType)
		{
			return null;
		}

		public static Member ToManipulator(this PropertyInfo propertyInfo, Type targetType)
		{
			return null;
		}

		public static Member ToManipulator(this MethodInfo methodInfo, Type targetType)
		{
			return null;
		}

		public static Member ToManipulator(this ConstructorInfo constructorInfo, Type targetType)
		{
			return null;
		}

		public static ConstructorInfo GetConstructorAccepting(this Type type, Type[] paramTypes, bool nonPublic)
		{
			return null;
		}

		public static ConstructorInfo GetConstructorAccepting(this Type type, params Type[] paramTypes)
		{
			return null;
		}

		public static ConstructorInfo GetPublicConstructorAccepting(this Type type, params Type[] paramTypes)
		{
			return null;
		}

		public static ConstructorInfo GetDefaultConstructor(this Type type)
		{
			return null;
		}

		public static ConstructorInfo GetPublicDefaultConstructor(this Type type)
		{
			return null;
		}

		public static MemberInfo[] GetExtendedMember(this Type type, string name, MemberTypes types, BindingFlags flags)
		{
			return null;
		}

		public static MemberInfo[] GetExtendedMembers(this Type type, BindingFlags flags)
		{
			return null;
		}

		private static bool NameMatches(this MemberInfo member, string name)
		{
			return false;
		}

		private static bool ParametersMatch(this MethodBase methodBase, IEnumerable<Type> parameterTypes, bool invokeAsExtension)
		{
			return false;
		}

		private static bool GenericArgumentsMatch(this MethodInfo method, IEnumerable<Type> genericArgumentTypes)
		{
			return false;
		}

		public static bool SignatureMatches(this FieldInfo field, string name)
		{
			return false;
		}

		public static bool SignatureMatches(this PropertyInfo property, string name)
		{
			return false;
		}

		public static bool SignatureMatches(this ConstructorInfo constructor, string name, IEnumerable<Type> parameterTypes)
		{
			return false;
		}

		public static bool SignatureMatches(this MethodInfo method, string name, IEnumerable<Type> parameterTypes, bool invokeAsExtension)
		{
			return false;
		}

		public static bool SignatureMatches(this MethodInfo method, string name, IEnumerable<Type> parameterTypes, IEnumerable<Type> genericArgumentTypes, bool invokeAsExtension)
		{
			return false;
		}

		public static FieldInfo GetFieldUnambiguous(this Type type, string name, BindingFlags flags)
		{
			return null;
		}

		public static PropertyInfo GetPropertyUnambiguous(this Type type, string name, BindingFlags flags)
		{
			return null;
		}

		public static MethodInfo GetMethodUnambiguous(this Type type, string name, BindingFlags flags)
		{
			return null;
		}

		private static TMemberInfo DisambiguateHierarchy<TMemberInfo>(this IEnumerable<TMemberInfo> members, Type type) where TMemberInfo : MemberInfo
		{
			return null;
		}

		public static FieldInfo Disambiguate(this IEnumerable<FieldInfo> fields, Type type)
		{
			return null;
		}

		public static PropertyInfo Disambiguate(this IEnumerable<PropertyInfo> properties, Type type)
		{
			return null;
		}

		public static ConstructorInfo Disambiguate(this IEnumerable<ConstructorInfo> constructors, Type type, IEnumerable<Type> parameterTypes)
		{
			return null;
		}

		public static MethodInfo Disambiguate(this IEnumerable<MethodInfo> methods, Type type, IEnumerable<Type> parameterTypes)
		{
			return null;
		}

		public static MethodInfo Disambiguate(this IEnumerable<MethodInfo> methods, Type type, IEnumerable<Type> parameterTypes, IEnumerable<Type> genericArgumentTypes)
		{
			return null;
		}
	}
}
