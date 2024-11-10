using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	[AttributeUsage(AttributeTargets.Class)]
	public class DisallowMultipleRendererFeature : Attribute
	{
		public string customTitle
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DisallowMultipleRendererFeature(string customTitle = null)
		{
		}
	}
}
