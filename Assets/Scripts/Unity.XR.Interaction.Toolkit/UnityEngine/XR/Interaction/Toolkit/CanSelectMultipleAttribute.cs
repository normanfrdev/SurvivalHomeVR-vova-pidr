using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class CanSelectMultipleAttribute : Attribute
	{
		public bool allowMultiple
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public CanSelectMultipleAttribute(bool allowMultiple = true)
		{
		}
	}
}
