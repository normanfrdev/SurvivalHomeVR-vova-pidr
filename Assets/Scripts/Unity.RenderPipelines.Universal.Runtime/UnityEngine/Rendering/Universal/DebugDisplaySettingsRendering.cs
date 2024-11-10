using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	public class DebugDisplaySettingsRendering : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		public enum TaaDebugMode
		{
			None = 0,
			ShowRawFrame = 1,
			ShowRawFrameNoJitter = 2,
			ShowClampedHistory = 3
		}

		private static class Strings
		{
			public const string RangeValidationSettingsContainerName = "Pixel Range Settings";

			public static readonly DebugUI.Widget.NameAndTooltip MapOverlays;

			public static readonly DebugUI.Widget.NameAndTooltip MapSize;

			public static readonly DebugUI.Widget.NameAndTooltip AdditionalWireframeModes;

			public static readonly DebugUI.Widget.NameAndTooltip WireframeNotSupportedWarning;

			public static readonly DebugUI.Widget.NameAndTooltip OverdrawMode;

			public static readonly DebugUI.Widget.NameAndTooltip MaxOverdrawCount;

			public static readonly DebugUI.Widget.NameAndTooltip PostProcessing;

			public static readonly DebugUI.Widget.NameAndTooltip MSAA;

			public static readonly DebugUI.Widget.NameAndTooltip HDR;

			public static readonly DebugUI.Widget.NameAndTooltip TaaDebugMode;

			public static readonly DebugUI.Widget.NameAndTooltip PixelValidationMode;

			public static readonly DebugUI.Widget.NameAndTooltip Channels;

			public static readonly DebugUI.Widget.NameAndTooltip ValueRangeMin;

			public static readonly DebugUI.Widget.NameAndTooltip ValueRangeMax;
		}

		internal static class WidgetFactory
		{
			internal static DebugUI.Widget CreateMapOverlays(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMapOverlaySize(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateAdditionalWireframeShaderViews(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateWireframeNotSupportedWarning(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateOverdrawMode(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMaxOverdrawCount(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePostProcessing(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMSAA(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateHDR(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreateTaaDebugMode(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValidationMode(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValidationChannels(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValueRangeMin(SettingsPanel panel)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValueRangeMax(SettingsPanel panel)
			{
				return null;
			}
		}

		[DisplayInfo(name = "Rendering", order = 1)]
		internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsRendering>
		{
			public SettingsPanel(DebugDisplaySettingsRendering data)
			{
				((DebugDisplaySettingsPanel<T>)(object)this)._002Ector((T)default(_00210));
			}
		}

		private DebugWireframeMode m_WireframeMode;

		private bool m_Overdraw;

		private DebugOverdrawMode m_OverdrawMode;

		public DebugWireframeMode wireframeMode
		{
			get
			{
				return default(DebugWireframeMode);
			}
			set
			{
			}
		}

		[Obsolete("overdraw has been deprecated. Use overdrawMode instead.", false)]
		public bool overdraw
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public DebugOverdrawMode overdrawMode
		{
			get
			{
				return default(DebugOverdrawMode);
			}
			set
			{
			}
		}

		public int maxOverdrawCount
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

		public DebugFullScreenMode fullScreenDebugMode
		{
			[CompilerGenerated]
			get
			{
				return default(DebugFullScreenMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int fullScreenDebugModeOutputSizeScreenPercent
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

		internal DebugSceneOverrideMode sceneOverrideMode
		{
			[CompilerGenerated]
			get
			{
				return default(DebugSceneOverrideMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal DebugMipInfoMode mipInfoMode
		{
			[CompilerGenerated]
			get
			{
				return default(DebugMipInfoMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DebugPostProcessingMode postProcessingDebugMode
		{
			[CompilerGenerated]
			get
			{
				return default(DebugPostProcessingMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool enableMsaa
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool enableHDR
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TaaDebugMode taaDebugMode
		{
			[CompilerGenerated]
			get
			{
				return default(TaaDebugMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DebugValidationMode validationMode
		{
			[CompilerGenerated]
			get
			{
				return default(DebugValidationMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PixelValidationChannels validationChannels
		{
			[CompilerGenerated]
			get
			{
				return default(PixelValidationChannels);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float validationRangeMin
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float validationRangeMax
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool AreAnySettingsActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool IsLightingActive => false;

		private void UpdateDebugSceneOverrideMode()
		{
		}

		public bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}

		IDebugDisplaySettingsPanelDisposable IDebugDisplaySettingsData.CreatePanel()
		{
			return null;
		}
	}
}
