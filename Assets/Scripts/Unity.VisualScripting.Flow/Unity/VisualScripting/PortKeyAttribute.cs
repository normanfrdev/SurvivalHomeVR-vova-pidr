using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class PortKeyAttribute : Attribute
	{
		public string key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public PortKeyAttribute(string key)
		{
		}
	}
}
