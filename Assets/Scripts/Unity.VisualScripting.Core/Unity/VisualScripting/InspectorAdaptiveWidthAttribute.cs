using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorAdaptiveWidthAttribute : Attribute
	{
		public float width
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InspectorAdaptiveWidthAttribute(float width)
		{
		}
	}
}
