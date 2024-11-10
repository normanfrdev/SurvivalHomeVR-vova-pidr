using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class TypeIconPriorityAttribute : Attribute
	{
		public int priority
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public TypeIconPriorityAttribute(int priority)
		{
		}

		public TypeIconPriorityAttribute()
		{
		}
	}
}
