using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class RuntimeCodebase
	{
		[CompilerGenerated]
		private sealed class _003CGetAssemblyAttributes_003Ed__15 : IEnumerable<Attribute>, IEnumerable, IEnumerator<Attribute>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Attribute _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Type attributeType;

			public Type _003C_003E3__attributeType;

			private IEnumerable<Assembly> assemblies;

			public IEnumerable<Assembly> _003C_003E3__assemblies;

			private IEnumerator<Assembly> _003C_003E7__wrap1;

			private IEnumerator<Attribute> _003C_003E7__wrap2;

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
			public _003CGetAssemblyAttributes_003Ed__15(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
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

		private static readonly object @lock;

		private static readonly List<Type> _types;

		private static readonly List<Assembly> _assemblies;

		public static HashSet<string> disallowedAssemblies;

		private static readonly Dictionary<string, Type> typeSerializations;

		private static Dictionary<string, Type> _renamedTypes;

		private static Dictionary<string, string> _renamedNamespaces;

		private static Dictionary<string, string> _renamedAssemblies;

		private static readonly Dictionary<Type, Dictionary<string, string>> _renamedMembers;

		public static IEnumerable<Type> types => null;

		public static IEnumerable<Assembly> assemblies => null;

		public static Dictionary<string, string> renamedNamespaces => null;

		public static Dictionary<string, string> renamedAssemblies => null;

		public static Dictionary<string, Type> renamedTypes => null;

		static RuntimeCodebase()
		{
		}

		public static IEnumerable<Attribute> GetAssemblyAttributes(Type attributeType)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetAssemblyAttributes_003Ed__15))]
		public static IEnumerable<Attribute> GetAssemblyAttributes(Type attributeType, IEnumerable<Assembly> assemblies)
		{
			return null;
		}

		public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>(IEnumerable<Assembly> assemblies) where TAttribute : Attribute
		{
			return null;
		}

		public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>() where TAttribute : Attribute
		{
			return null;
		}

		public static void PrewarmTypeDeserialization(Type type)
		{
		}

		public static string SerializeType(Type type)
		{
			return null;
		}

		public static bool TryDeserializeType(string typeName, out Type type)
		{
			type = null;
			return false;
		}

		public static Type DeserializeType(string typeName)
		{
			return null;
		}

		public static void ClearCachedTypes()
		{
		}

		private static bool TryCachedTypeLookup(string typeName, out Type type)
		{
			type = null;
			return false;
		}

		private static bool TrySystemTypeLookup(string typeName, out Type type)
		{
			type = null;
			return false;
		}

		private static bool TrySystemTypeLookup(TypeName typeName, out Type type)
		{
			type = null;
			return false;
		}

		private static bool TryRenamedTypeLookup(string previousTypeName, out Type type)
		{
			type = null;
			return false;
		}

		public static Dictionary<string, string> RenamedMembers(Type type)
		{
			return null;
		}

		private static Dictionary<string, string> FetchRenamedMembers(Type type)
		{
			return null;
		}

		private static Dictionary<string, string> FetchRenamedNamespaces()
		{
			return null;
		}

		private static Dictionary<string, string> FetchRenamedAssemblies()
		{
			return null;
		}

		private static Dictionary<string, Type> FetchRenamedTypes()
		{
			return null;
		}
	}
}
