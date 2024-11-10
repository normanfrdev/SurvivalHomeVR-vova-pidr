using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorWideAttribute : Attribute
	{
		public bool toEdge
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InspectorWideAttribute()
		{
		}

		public InspectorWideAttribute(bool toEdge)
		{
		}
	}
}
