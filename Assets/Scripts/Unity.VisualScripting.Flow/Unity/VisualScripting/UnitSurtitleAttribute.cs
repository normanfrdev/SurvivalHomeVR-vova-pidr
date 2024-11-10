using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class UnitSurtitleAttribute : Attribute
	{
		public string surtitle
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

		public UnitSurtitleAttribute(string surtitle)
		{
		}
	}
}
