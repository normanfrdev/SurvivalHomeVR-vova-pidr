using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class InspectableIfAttribute : Attribute, IInspectableAttribute
	{
		public int order
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string conditionMember
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public InspectableIfAttribute(string conditionMember)
		{
		}
	}
}
