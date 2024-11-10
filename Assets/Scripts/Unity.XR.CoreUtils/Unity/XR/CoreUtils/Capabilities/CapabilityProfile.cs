using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.XR.CoreUtils.Capabilities
{
	public abstract class CapabilityProfile : ScriptableObject
	{
		public static event Action<CapabilityProfile> CapabilityChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void ReportCapabilityChanged()
		{
		}
	}
}
