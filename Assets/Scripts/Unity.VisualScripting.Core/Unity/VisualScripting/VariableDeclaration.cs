using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public sealed class VariableDeclaration
	{
		[Serialize]
		public string name
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

		[Serialize]
		[Value]
		public object value
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Serialize]
		public SerializableType typeHandle
		{
			[CompilerGenerated]
			get
			{
				return default(SerializableType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
		public VariableDeclaration()
		{
		}

		public VariableDeclaration(string name, object value)
		{
		}
	}
}
