using System.Runtime.InteropServices;

namespace Unity.XR.MockHMD
{
	public static class MockHMD
	{
		private const string LibraryName = "UnityMockHMD";

		[DllImport("UnityMockHMD", EntryPoint = "NativeConfig_SetRenderMode")]
		public static extern bool SetRenderMode(MockHMDBuildSettings.RenderMode renderMode);

		[DllImport("UnityMockHMD", EntryPoint = "NativeConfig_SetEyeResolution")]
		public static extern bool SetEyeResolution(int width, int height);

		[DllImport("UnityMockHMD", EntryPoint = "NativeConfig_SetMirrorViewCrop")]
		public static extern bool SetMirrorViewCrop(float crop);

		[DllImport("UnityMockHMD", EntryPoint = "NativeConfig_SetFoveationMode")]
		public static extern bool SetFoveationMode(bool enable, uint gazeSimulatorMode);
	}
}
