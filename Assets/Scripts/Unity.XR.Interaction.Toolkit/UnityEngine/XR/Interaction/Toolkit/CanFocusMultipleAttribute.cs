using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class CanFocusMultipleAttribute : Attribute
	{
		public bool allowMultiple
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public CanFocusMultipleAttribute(bool allowMultiple = true)
		{
		}
	}
}
