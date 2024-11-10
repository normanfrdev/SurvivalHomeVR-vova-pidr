using UnityEngine;
using UnityEngine.XR.Management;

namespace Unity.XR.MockHMD
{
	[XRConfigurationData("MockHMD", "xr.sdk.mock-hmd.settings")]
	public class MockHMDBuildSettings : ScriptableObject
	{
		public enum RenderMode
		{
			MultiPass = 0,
			SinglePassInstanced = 1
		}

		public enum FoveationGazeSimulationMode
		{
			Disabled = 0,
			StaticCenter = 1,
			MovementLeftRight = 2,
			MovementEyeIndependent = 3
		}

		public const string BuildSettingsKey = "xr.sdk.mock-hmd.settings";

		public RenderMode renderMode;

		[Header("Foveated Rendering")]
		public bool foveationEnabled;

		[Tooltip("Select how the gaze directions should be generated.  \nNote: Some GPUs/API don't support having different data for both eyes when rendering using SinglePass, having different patterns in both eyes won't work for them.")]
		public FoveationGazeSimulationMode gazeSimulationMode;

		public static MockHMDBuildSettings s_RuntimeInstance;

		public static MockHMDBuildSettings Instance => null;

		private void OnEnable()
		{
		}
	}
}
