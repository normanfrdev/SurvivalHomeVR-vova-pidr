using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class ExpectedTypeAttribute : Attribute
	{
		public Type type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ExpectedTypeAttribute(Type type)
		{
		}
	}
}
