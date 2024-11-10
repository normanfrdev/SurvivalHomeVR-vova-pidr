using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Management
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class XRConfigurationDataAttribute : Attribute
	{
		public string displayName
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

		public string buildSettingsKey
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

		private XRConfigurationDataAttribute()
		{
		}

		public XRConfigurationDataAttribute(string displayName, string buildSettingsKey)
		{
		}
	}
}
