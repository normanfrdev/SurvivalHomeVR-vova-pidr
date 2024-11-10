using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
	[Preserve]
	public static class SimulatedInputLayoutLoader
	{
		[Preserve]
		static SimulatedInputLayoutLoader()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		[Preserve]
		public static void Initialize()
		{
		}

		private static void RegisterInputLayouts()
		{
		}
	}
}
