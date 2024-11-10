using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class WarnBeforeEditingAttribute : Attribute
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

		public object[] emptyValues
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public WarnBeforeEditingAttribute(string warningTitle, string warningMessage)
		{
		}

		public WarnBeforeEditingAttribute(string warningTitle, string warningMessage, params object[] emptyValues)
		{
		}
	}
}
