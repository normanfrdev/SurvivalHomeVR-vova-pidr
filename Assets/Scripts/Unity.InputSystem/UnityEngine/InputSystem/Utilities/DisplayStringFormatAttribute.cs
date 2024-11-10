using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Utilities
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public class DisplayStringFormatAttribute : Attribute
	{
		public string formatString
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DisplayStringFormatAttribute(string formatString)
		{
		}
	}
}
