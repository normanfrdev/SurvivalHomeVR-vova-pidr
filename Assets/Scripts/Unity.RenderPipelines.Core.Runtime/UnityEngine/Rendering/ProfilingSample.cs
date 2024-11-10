using System;
using Unity.Profiling;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering
{
	[Obsolete("Please use ProfilingScope")]
	[IgnoredByDeepProfiler]
	public struct ProfilingSample : IDisposable
	{
		private readonly CommandBuffer m_Cmd;

		private readonly string m_Name;

		private bool m_Disposed;

		private CustomSampler m_Sampler;

		public ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null)
		{
		}

		public ProfilingSample(CommandBuffer cmd, string format, object arg)
		{
		}

		public ProfilingSample(CommandBuffer cmd, string format, params object[] args)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
