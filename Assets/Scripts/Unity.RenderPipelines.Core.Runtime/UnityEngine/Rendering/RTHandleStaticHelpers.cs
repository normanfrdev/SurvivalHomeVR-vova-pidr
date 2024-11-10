using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct RTHandleStaticHelpers
	{
		public static RTHandle s_RTHandleWrapper;

		public static void SetRTHandleStaticWrapper(RenderTargetIdentifier rtId)
		{
		}

		public static void SetRTHandleUserManagedWrapper(ref RTHandle rtWrapper, RenderTargetIdentifier rtId)
		{
		}
	}
}
