using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	internal class XRPassUniversal : XRPass
	{
		internal bool isLateLatchEnabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool canMarkLateLatch
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool hasMarkedLateLatch
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static XRPass Create(XRPassCreateInfo createInfo)
		{
			return null;
		}

		public override void Release()
		{
		}
	}
}
