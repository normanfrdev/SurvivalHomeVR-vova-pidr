using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class RenamedFromAttribute : Attribute
	{
		public string previousName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public RenamedFromAttribute(string previousName)
		{
		}
	}
}
