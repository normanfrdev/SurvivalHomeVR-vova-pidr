using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public class DebugFrameTiming
	{
		private const string k_FpsFormatString = "{0:F1}";

		private const string k_MsFormatString = "{0:F2}ms";

		private const float k_RefreshRate = 0.2f;

		internal FrameTimeSampleHistory m_FrameHistory;

		internal BottleneckHistory m_BottleneckHistory;

		private FrameTiming[] m_Timing;

		private FrameTimeSample m_Sample;

		public int bottleneckHistorySize
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int sampleHistorySize
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void UpdateFrameTiming()
		{
		}

		public void RegisterDebugUI(List<DebugUI.Widget> list)
		{
		}

		internal void Reset()
		{
		}
	}
}
