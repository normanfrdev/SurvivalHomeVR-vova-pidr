using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class AttributeUtility
	{
		private class AttributeCache
		{
			[CompilerGenerated]
			private sealed class _003CGetAttributes_003Ed__12 : IEnumerable<Attribute>, IEnumerable, IEnumerator<Attribute>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private Attribute _003C_003E2__current;

				private int _003C_003El__initialThreadId;

				private List<Attribute> cache;

				public List<Attribute> _003C_003E3__cache;

				private Type attributeType;

				public Type _003C_003E3__attributeType;

				private int _003Ci_003E5__2;

				Attribute IEnumerator<Attribute>.Current
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
				public _003CGetAttributes_003Ed__12(int _003C_003E1__state)
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
				IEnumerator<Attribute> IEnumerable<Attribute>.GetEnumerator()
				{
					return null;
				}

				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			public List<Attribute> inheritedAttributes
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public List<Attribute> definedAttributes
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public AttributeCache(MemberInfo element)
			{
			}

			public AttributeCache(ParameterInfo element)
			{
			}

			public AttributeCache(IAttributeProvider element)
			{
			}

			private void Cache(Attribute[] attributeObjects, List<Attribute> cache)
			{
			}

			private bool HasAttribute(Type attributeType, List<Attribute> cache)
			{
				return false;
			}

			private Attribute GetAttribute(Type attributeType, List<Attribute> cache)
			{
				return null;
			}

			[IteratorStateMachine(typeof(_003CGetAttributes_003Ed__12))]
			private IEnumerable<Attribute> GetAttributes(Type attributeType, List<Attribute> cache)
			{
				return null;
			}

			public bool HasAttribute(Type attributeType, bool inherit = true)
			{
				return false;
			}

			public Attribute GetAttribute(Type attributeType, bool inherit = true)
			{
				return null;
			}

			public IEnumerable<Attribute> GetAttributes(Type attributeType, bool inherit = true)
			{
				return null;
			}

			public bool HasAttribute<TAttribute>(bool inherit = true) where TAttribute : Attribute
			{
				return false;
			}

			public TAttribute GetAttribute<TAttribute>(bool inherit = true) where TAttribute : Attribute
			{
				return null;
			}

			public IEnumerable<TAttribute> GetAttributes<TAttribute>(bool inherit = true) where TAttribute : Attribute
			{
				return null;
			}
		}

		private static readonly Dictionary<object, AttributeCache> optimizedCaches;

		private static AttributeCache GetAttributeCache(MemberInfo element)
		{
			return null;
		}

		private static AttributeCache GetAttributeCache(ParameterInfo element)
		{
			return null;
		}

		private static AttributeCache GetAttributeCache(IAttributeProvider element)
		{
			return null;
		}

		public static void CacheAttributes(MemberInfo element)
		{
		}

		internal static IEnumerable<T> GetAttributeOfEnumMember<T>(this Enum enumVal) where T : Attribute
		{
			return null;
		}

		public static bool HasAttribute(this MemberInfo element, Type attributeType, bool inherit = true)
		{
			return false;
		}

		public static Attribute GetAttribute(this MemberInfo element, Type attributeType, bool inherit = true)
		{
			return null;
		}

		public static IEnumerable<Attribute> GetAttributes(this MemberInfo element, Type attributeType, bool inherit = true)
		{
			return null;
		}

		public static bool HasAttribute<TAttribute>(this MemberInfo element, bool inherit = true) where TAttribute : Attribute
		{
			return false;
		}

		public static TAttribute GetAttribute<TAttribute>(this MemberInfo element, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this MemberInfo element, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static void CacheAttributes(ParameterInfo element)
		{
		}

		public static bool HasAttribute(this ParameterInfo element, Type attributeType, bool inherit = true)
		{
			return false;
		}

		public static Attribute GetAttribute(this ParameterInfo element, Type attributeType, bool inherit = true)
		{
			return null;
		}

		public static IEnumerable<Attribute> GetAttributes(this ParameterInfo element, Type attributeType, bool inherit = true)
		{
			return null;
		}

		public static bool HasAttribute<TAttribute>(this ParameterInfo element, bool inherit = true) where TAttribute : Attribute
		{
			return false;
		}

		public static TAttribute GetAttribute<TAttribute>(this ParameterInfo element, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this ParameterInfo element, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static void CacheAttributes(IAttributeProvider element)
		{
		}

		public static bool HasAttribute(this IAttributeProvider element, Type attributeType, bool inherit = true)
		{
			return false;
		}

		public static Attribute GetAttribute(this IAttributeProvider element, Type attributeType, bool inherit = true)
		{
			return null;
		}

		public static IEnumerable<Attribute> GetAttributes(this IAttributeProvider element, Type attributeType, bool inherit = true)
		{
			return null;
		}

		public static bool HasAttribute<TAttribute>(this IAttributeProvider element, bool inherit = true) where TAttribute : Attribute
		{
			return false;
		}

		public static TAttribute GetAttribute<TAttribute>(this IAttributeProvider element, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this IAttributeProvider element, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static bool CheckCondition(Type type, object target, string conditionMemberName, bool fallback)
		{
			return false;
		}

		public static bool CheckCondition<T>(T target, string conditionMemberName, bool fallback)
		{
			return false;
		}
	}
}
