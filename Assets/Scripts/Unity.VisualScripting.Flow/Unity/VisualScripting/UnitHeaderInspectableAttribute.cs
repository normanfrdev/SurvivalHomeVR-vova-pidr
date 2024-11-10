using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class UnitHeaderInspectableAttribute : Attribute
	{
		public string label
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public UnitHeaderInspectableAttribute()
		{
		}

		public UnitHeaderInspectableAttribute(string label)
		{
		}
	}
}
