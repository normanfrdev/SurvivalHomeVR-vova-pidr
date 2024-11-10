using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedAssemblyAttribute : Attribute
	{
		public string previousName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string newName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public RenamedAssemblyAttribute(string previousName, string newName)
		{
		}
	}
}
