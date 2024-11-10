namespace UnityEngine.Rendering
{
	internal struct FrameTimeSample
	{
		internal float FramesPerSecond;

		internal float FullFrameTime;

		internal float MainThreadCPUFrameTime;

		internal float MainThreadCPUPresentWaitTime;

		internal float RenderThreadCPUFrameTime;

		internal float GPUFrameTime;

		internal FrameTimeSample(float initValue)
		{
		}
	}
}
