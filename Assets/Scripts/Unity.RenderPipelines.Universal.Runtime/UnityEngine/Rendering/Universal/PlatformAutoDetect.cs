using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	internal static class PlatformAutoDetect
	{
		internal static bool isRunningOnPowerVRGPU;

		internal static bool isXRMobile
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

		internal static bool isShaderAPIMobileDefined
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

		internal static bool isSwitch
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

		internal static void Initialize()
		{
		}

		internal static ShEvalMode ShAutoDetect(ShEvalMode mode)
		{
			return default(ShEvalMode);
		}
	}
}
