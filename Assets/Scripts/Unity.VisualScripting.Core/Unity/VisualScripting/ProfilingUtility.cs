using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class ProfilingUtility
	{
		private static readonly object @lock;

		public static ProfiledSegment rootSegment
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static ProfiledSegment currentSegment
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		static ProfilingUtility()
		{
		}

		[Conditional("ENABLE_PROFILER")]
		public static void Clear()
		{
		}

		public static ProfilingScope SampleBlock(string name)
		{
			return default(ProfilingScope);
		}

		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name)
		{
		}

		[Conditional("ENABLE_PROFILER")]
		public static void EndSample()
		{
		}
	}
}
