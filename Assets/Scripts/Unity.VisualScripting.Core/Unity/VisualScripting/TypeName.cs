using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class TypeName
	{
		private enum ParseState
		{
			Name = 0,
			Array = 1,
			Generics = 2,
			Assembly = 3
		}

		private readonly List<string> names;

		private readonly List<int> genericarities;

		public string AssemblyDescription
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string AssemblyName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string AssemblyVersion
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string AssemblyCulture
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string AssemblyPublicKeyToken
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<TypeName> GenericParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsArray => false;

		public string LastName => null;

		public static TypeName Parse(string s)
		{
			return null;
		}

		private TypeName(string s, ref int index)
		{
		}

		private static string LookForPairThenRemove(List<string> strings, string Name)
		{
			return null;
		}

		public void ReplaceNamespace(string oldNamespace, string newNamespace)
		{
		}

		public void ReplaceAssembly(string oldAssembly, string newAssembly)
		{
		}

		public void ReplaceName(string oldTypeName, Type newType)
		{
		}

		public void ReplaceName(string oldTypeName, string newTypeName, AssemblyName newAssemblyName = null)
		{
		}

		private static string ToElementTypeName(string s)
		{
			return null;
		}

		private static string ToArrayOrType(string oldType, string newType)
		{
			return null;
		}

		public void SetAssemblyName(AssemblyName newAssemblyName)
		{
		}

		private void UpdateName()
		{
		}

		public string ToString(TypeNameDetail specification, TypeNameDetail genericsSpecification)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToLooseString()
		{
			return null;
		}

		public static string Simplify(string typeName)
		{
			return null;
		}

		public static string SimplifyFast(string typeName)
		{
			return null;
		}
	}
}
