using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorActionDirectionAttribute : Attribute
	{
		public ActionDirection direction
		{
			[CompilerGenerated]
			get
			{
				return default(ActionDirection);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InspectorActionDirectionAttribute(ActionDirection direction)
		{
		}
	}
}
