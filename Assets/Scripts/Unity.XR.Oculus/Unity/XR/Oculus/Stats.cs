using System;
using UnityEngine;

namespace Unity.XR.Oculus
{
	public class Stats
	{
		public static class AdaptivePerformance
		{
			public static float GPUAppTime => 0f;

			public static float GPUCompositorTime => 0f;

			public static float MotionToPhoton => 0f;

			[Obsolete("RefreshRate is deprecated. Use Performance.TryGetDisplayRefreshRate instead.", false)]
			public static float RefreshRate => 0f;

			public static float BatteryTemp => 0f;

			public static float BatteryLevel => 0f;

			public static bool PowerSavingMode => false;

			public static float AdaptivePerformanceScale => 0f;

			public static int CPULevel => 0;

			public static int GPULevel => 0;
		}

		public static class PerfMetrics
		{
			public static float AppCPUTime => 0f;

			public static float AppGPUTime => 0f;

			public static float CompositorCPUTime => 0f;

			public static float CompositorGPUTime => 0f;

			public static float GPUUtilization => 0f;

			public static float CPUUtilizationAverage => 0f;

			public static float CPUUtilizationWorst => 0f;

			public static float CPUClockFrequency => 0f;

			public static float GPUClockFrequency => 0f;

			public static void EnablePerfMetrics(bool enable)
			{
			}
		}

		public static class AppMetrics
		{
			public static float AppQueueAheadTime => 0f;

			public static float AppCPUElapsedTime => 0f;

			public static float CompositorDroppedFrames => 0f;

			public static float CompositorLatency => 0f;

			public static float CompositorCPUTime => 0f;

			public static float CPUStartToGPUEnd => 0f;

			public static float GPUEndToVsync => 0f;

			public static void EnableAppMetrics(bool enable)
			{
			}
		}

		private static IntegratedSubsystem m_Display;

		private static string m_PluginVersion;

		public static string PluginVersion => null;

		private static IntegratedSubsystem GetOculusDisplaySubsystem()
		{
			return null;
		}
	}
}
