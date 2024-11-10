using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	public class UniversalRenderPipelineDebugDisplaySettings : DebugDisplaySettings<UniversalRenderPipelineDebugDisplaySettings>
	{
		private DebugDisplaySettingsCommon commonSettings
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

		public DebugDisplaySettingsMaterial materialSettings
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

		public DebugDisplaySettingsRendering renderingSettings
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

		public DebugDisplaySettingsLighting lightingSettings
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

		public DebugDisplaySettingsVolume volumeSettings
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

		internal DebugDisplayStats displayStats
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

		public override bool IsPostProcessingAllowed => false;

		public UniversalRenderPipelineDebugDisplaySettings()
		{
			((DebugDisplaySettings<T>)(object)this)._002Ector();
		}

		public override void Reset()
		{
		}

		internal void UpdateFrameTiming()
		{
		}
	}
}
