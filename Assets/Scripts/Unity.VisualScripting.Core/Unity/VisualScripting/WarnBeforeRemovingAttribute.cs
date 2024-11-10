using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class WarnBeforeRemovingAttribute : Attribute
	{
		public string warningTitle
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string warningMessage
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public WarnBeforeRemovingAttribute(string warningTitle, string warningMessage)
		{
		}
	}
}
