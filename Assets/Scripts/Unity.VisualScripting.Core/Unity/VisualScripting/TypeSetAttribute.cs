using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class TypeSetAttribute : Attribute
	{
		public TypeSet typeSet
		{
			[CompilerGenerated]
			get
			{
				return default(TypeSet);
			}
		}

		public TypeSetAttribute(TypeSet typeSet)
		{
		}
	}
}
