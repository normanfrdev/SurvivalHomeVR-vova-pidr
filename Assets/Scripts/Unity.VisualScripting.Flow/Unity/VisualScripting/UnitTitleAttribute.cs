using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitTitleAttribute : Attribute
	{
		public string title
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

		public UnitTitleAttribute(string title)
		{
		}
	}
}
