using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class TypeUtility
	{
		[CompilerGenerated]
		private sealed class _003CGetTypesSafely_003Ed__35 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Type _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Assembly assembly;

			public Assembly _003C_003E3__assembly;

			private Type[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			Type IEnumerator<Type>.Current
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
			public _003CGetTypesSafely_003Ed__35(int _003C_003E1__state)
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
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CHierarchy_003Ed__19 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Type _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Type type;

			public Type _003C_003E3__type;

			private Type _003CbaseType_003E5__2;

			private IEnumerator<Type> _003C_003E7__wrap2;

			Type IEnumerator<Type>.Current
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
			public _003CHierarchy_003Ed__19(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly HashSet<Type> _numericTypes;

		private static readonly HashSet<Type> _numericConstructTypes;

		private static readonly HashSet<Type> typesWithShortStrings;

		private static readonly Dictionary<Type, object> defaultPrimitives;

		public static bool IsBasic(this Type type)
		{
			return false;
		}

		public static bool IsNumeric(this Type type)
		{
			return false;
		}

		public static bool IsNumericConstruct(this Type type)
		{
			return false;
		}

		public static Namespace Namespace(this Type type)
		{
			return null;
		}

		public static Func<object> Instantiator(this Type type, bool nonPublic = true)
		{
			return null;
		}

		public static Func<object[], object> Instantiator(this Type type, bool nonPublic = true, params Type[] parameterTypes)
		{
			return null;
		}

		public static object TryInstantiate(this Type type, bool nonPublic = true, params object[] args)
		{
			return null;
		}

		public static object Instantiate(this Type type, bool nonPublic = true, params object[] args)
		{
			return null;
		}

		public static object Default(this Type type)
		{
			return null;
		}

		public static object PseudoDefault(this Type type)
		{
			return null;
		}

		public static bool IsStatic(this Type type)
		{
			return false;
		}

		public static bool IsAbstract(this Type type)
		{
			return false;
		}

		public static bool IsConcrete(this Type type)
		{
			return false;
		}

		public static IEnumerable<Type> GetInterfaces(this Type type, bool includeInherited)
		{
			return null;
		}

		public static IEnumerable<Type> BaseTypeAndInterfaces(this Type type, bool inheritedInterfaces = true)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHierarchy_003Ed__19))]
		public static IEnumerable<Type> Hierarchy(this Type type)
		{
			return null;
		}

		public static IEnumerable<Type> AndBaseTypeAndInterfaces(this Type type)
		{
			return null;
		}

		public static IEnumerable<Type> AndInterfaces(this Type type)
		{
			return null;
		}

		public static IEnumerable<Type> AndHierarchy(this Type type)
		{
			return null;
		}

		public static Type GetListElementType(Type listType, bool allowNonGeneric)
		{
			return null;
		}

		public static Type GetEnumerableElementType(Type enumerableType, bool allowNonGeneric)
		{
			return null;
		}

		public static Type GetDictionaryItemType(Type dictionaryType, bool allowNonGeneric, int genericArgumentIndex)
		{
			return null;
		}

		public static Type GetDictionaryKeyType(Type dictionaryType, bool allowNonGeneric)
		{
			return null;
		}

		public static Type GetDictionaryValueType(Type dictionaryType, bool allowNonGeneric)
		{
			return null;
		}

		public static bool IsNullable(this Type type)
		{
			return false;
		}

		public static bool IsReferenceType(this Type type)
		{
			return false;
		}

		public static bool IsStruct(this Type type)
		{
			return false;
		}

		public static bool IsAssignableFrom(this Type type, object value)
		{
			return false;
		}

		public static bool CanMakeGenericTypeVia(this Type openConstructedType, Type closedConstructedType)
		{
			return false;
		}

		public static Type MakeGenericTypeVia(this Type openConstructedType, Type closedConstructedType, Dictionary<Type, Type> resolvedGenericParameters, bool safe = true)
		{
			return null;
		}

		public static string ToShortString(this object o, int maxLength = 20)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetTypesSafely_003Ed__35))]
		public static IEnumerable<Type> GetTypesSafely(this Assembly assembly)
		{
			return null;
		}
	}
}
