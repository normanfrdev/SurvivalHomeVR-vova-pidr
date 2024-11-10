using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitOrderAttribute : Attribute
	{
		public int order
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UnitOrderAttribute(int order)
		{
		}
	}
}
