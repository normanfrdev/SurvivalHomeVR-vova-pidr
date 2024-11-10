using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
	[Preserve]
	public static class XRDeviceSimulatorLoader
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		[Preserve]
		public static void Initialize()
		{
		}

		[Preserve]
		static XRDeviceSimulatorLoader()
		{
		}
	}
}
