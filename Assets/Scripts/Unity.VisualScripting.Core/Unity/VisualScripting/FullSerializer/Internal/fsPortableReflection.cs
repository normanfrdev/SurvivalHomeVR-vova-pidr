using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.FullSerializer.Internal
{
	public static class fsPortableReflection
	{
		private struct AttributeQuery
		{
			public MemberInfo MemberInfo;

			public Type AttributeType;
		}

		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery>
		{
			public bool Equals(AttributeQuery x, AttributeQuery y)
			{
				return false;
			}

			public int GetHashCode(AttributeQuery obj)
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetFlattenedMethods_003Ed__18 : IEnumerable<MethodInfo>, IEnumerable, IEnumerator<MethodInfo>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private MethodInfo _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Type type;

			public Type _003C_003E3__type;

			private string methodName;

			public string _003C_003E3__methodName;

			private MethodInfo[] _003Cmethods_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CGetFlattenedMethods_003Ed__18(int _003C_003E1__state)
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

		public static Type[] EmptyTypes;

		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries;

		private static BindingFlags DeclaredFlags;

		public static bool HasAttribute<TAttribute>(MemberInfo element)
		{
			return false;
		}

		public static bool HasAttribute<TAttribute>(MemberInfo element, bool shouldCache)
		{
			return false;
		}

		public static bool HasAttribute(MemberInfo element, Type attributeType)
		{
			return false;
		}

		public static bool HasAttribute(MemberInfo element, Type attributeType, bool shouldCache)
		{
			return false;
		}

		public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache)
		{
			return null;
		}

		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute GetAttribute<TAttribute>(MemberInfo element) where TAttribute : Attribute
		{
			return null;
		}

		public static PropertyInfo GetDeclaredProperty(this Type type, string propertyName)
		{
			return null;
		}

		public static MethodInfo GetDeclaredMethod(this Type type, string methodName)
		{
			return null;
		}

		public static ConstructorInfo GetDeclaredConstructor(this Type type, Type[] parameters)
		{
			return null;
		}

		public static ConstructorInfo[] GetDeclaredConstructors(this Type type)
		{
			return null;
		}

		public static MemberInfo[] GetFlattenedMember(this Type type, string memberName)
		{
			return null;
		}

		public static MethodInfo GetFlattenedMethod(this Type type, string methodName)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetFlattenedMethods_003Ed__18))]
		public static IEnumerable<MethodInfo> GetFlattenedMethods(this Type type, string methodName)
		{
			return null;
		}

		public static PropertyInfo GetFlattenedProperty(this Type type, string propertyName)
		{
			return null;
		}

		public static MemberInfo GetDeclaredMember(this Type type, string memberName)
		{
			return null;
		}

		public static MethodInfo[] GetDeclaredMethods(this Type type)
		{
			return null;
		}

		public static PropertyInfo[] GetDeclaredProperties(this Type type)
		{
			return null;
		}

		public static FieldInfo[] GetDeclaredFields(this Type type)
		{
			return null;
		}

		public static MemberInfo[] GetDeclaredMembers(this Type type)
		{
			return null;
		}

		public static MemberInfo AsMemberInfo(Type type)
		{
			return null;
		}

		public static bool IsType(MemberInfo member)
		{
			return false;
		}

		public static Type AsType(MemberInfo member)
		{
			return null;
		}

		public static Type Resolve(this Type type)
		{
			return null;
		}
	}
}
