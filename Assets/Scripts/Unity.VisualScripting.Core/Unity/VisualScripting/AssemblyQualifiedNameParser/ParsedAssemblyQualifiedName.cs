using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.AssemblyQualifiedNameParser
{
	public class ParsedAssemblyQualifiedName
	{
		private class Block
		{
			internal int startIndex;

			internal int endIndex;

			internal int level;

			internal Block parentBlock;

			internal readonly List<Block> innerBlocks;

			internal ParsedAssemblyQualifiedName parsedAssemblyQualifiedName;
		}

		public string AssemblyDescriptionString
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string TypeName
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

		public string ShortAssemblyName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Version
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Culture
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string PublicKeyToken
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public List<ParsedAssemblyQualifiedName> GenericParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int GenericParameterCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public ParsedAssemblyQualifiedName(string AssemblyQualifiedName)
		{
		}

		private static string LookForPairThenRemove(List<string> strings, string Name)
		{
			return null;
		}

		public void Replace(string oldTypeName, string newTypeName)
		{
		}

		private string ToString(bool includeAssemblyDescription)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
