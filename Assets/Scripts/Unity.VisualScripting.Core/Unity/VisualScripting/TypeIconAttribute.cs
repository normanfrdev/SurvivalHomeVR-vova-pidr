using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public sealed class TypeIconAttribute : Attribute
	{
		public Type type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public TypeIconAttribute(Type type)
		{
		}
	}
}
