using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Internal
{
	internal class RequireInterfaceAttribute : PropertyAttribute
	{
		public Type interfaceType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public RequireInterfaceAttribute(Type interfaceType)
		{
		}
	}
}
