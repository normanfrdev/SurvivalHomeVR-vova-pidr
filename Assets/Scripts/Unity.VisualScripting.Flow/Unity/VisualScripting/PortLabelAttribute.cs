using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class PortLabelAttribute : Attribute
	{
		public string label
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

		public bool hidden
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PortLabelAttribute(string label)
		{
		}
	}
}
