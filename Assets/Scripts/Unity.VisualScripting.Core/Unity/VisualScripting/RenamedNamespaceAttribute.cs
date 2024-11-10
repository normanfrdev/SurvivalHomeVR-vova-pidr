using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedNamespaceAttribute : Attribute
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

		public RenamedNamespaceAttribute(string previousName, string newName)
		{
		}
	}
}
