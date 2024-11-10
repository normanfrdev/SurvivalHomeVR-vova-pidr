using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[Obsolete("Set VariableKind via VariableDeclarations.Kind")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class VariableKindAttribute : Attribute
	{
		public VariableKind kind
		{
			[CompilerGenerated]
			get
			{
				return default(VariableKind);
			}
		}

		public VariableKindAttribute(VariableKind kind)
		{
		}
	}
}
