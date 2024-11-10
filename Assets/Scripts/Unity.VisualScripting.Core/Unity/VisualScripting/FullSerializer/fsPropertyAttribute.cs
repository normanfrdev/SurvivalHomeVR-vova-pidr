using System;

namespace Unity.VisualScripting.FullSerializer
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class fsPropertyAttribute : Attribute
	{
		public string Name;

		public Type Converter;

		public fsPropertyAttribute()
		{
		}

		public fsPropertyAttribute(string name)
		{
		}
	}
}
