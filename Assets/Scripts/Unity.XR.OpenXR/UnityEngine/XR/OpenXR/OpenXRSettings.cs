using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Serialization;
using UnityEngine.XR.OpenXR.Features;

namespace UnityEngine.XR.OpenXR
{
	[Serializable]
	public class OpenXRSettings : ScriptableObject
	{
		public enum ColorSubmissionModeGroup
		{
			[InspectorName("8 bits per channel (LDR, default)")]
			kRenderTextureFormatGroup8888 = 0,
			[InspectorName("10 bits floating-point per color channel, 2 bit alpha (HDR)")]
			kRenderTextureFormatGroup1010102_Float = 1,
			[InspectorName("16 bits floating-point per channel (HDR)")]
			kRenderTextureFormatGroup16161616_Float = 2,
			[InspectorName("5,6,5 bit packed (LDR, mobile)")]
			kRenderTextureFormatGroup565 = 3,
			[InspectorName("11,11,10 bit packed floating-point (HDR)")]
			kRenderTextureFormatGroup111110_Float = 4
		}

		[Serializable]
		public class ColorSubmissionModeList
		{
			public ColorSubmissionModeGroup[] m_List;
		}

		public enum RenderMode
		{
			MultiPass = 0,
			SinglePassInstanced = 1
		}

		public enum DepthSubmissionMode
		{
			None = 0,
			Depth16Bit = 1,
			Depth24Bit = 2
		}

		public enum BackendFovationApi : byte
		{
			Legacy = 0,
			SRPFoveation = 1
		}

		[FormerlySerializedAs("extensions")]
		[HideInInspector]
		[SerializeField]
		internal OpenXRFeature[] features;

		public static readonly ColorSubmissionModeGroup kDefaultColorMode;

		[SerializeField]
		private RenderMode m_renderMode;

		[SerializeField]
		private bool m_autoColorSubmissionMode;

		[SerializeField]
		private ColorSubmissionModeList m_colorSubmissionModes;

		[SerializeField]
		private DepthSubmissionMode m_depthSubmissionMode;

		[SerializeField]
		private bool m_optimizeBufferDiscards;

		[SerializeField]
		private bool m_symmetricProjection;

		private const string LibraryName = "UnityOpenXR";

		private static OpenXRSettings s_RuntimeInstance;

		public int featureCount => 0;

		public RenderMode renderMode
		{
			get
			{
				return default(RenderMode);
			}
			set
			{
			}
		}

		public bool autoColorSubmissionMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ColorSubmissionModeGroup[] colorSubmissionModes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DepthSubmissionMode depthSubmissionMode
		{
			get
			{
				return default(DepthSubmissionMode);
			}
			set
			{
			}
		}

		public bool optimizeBufferDiscards
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool symmetricProjection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BackendFovationApi foveatedRenderingApi => default(BackendFovationApi);

		public static OpenXRSettings ActiveBuildTargetInstance => null;

		public static OpenXRSettings Instance => null;

		public static bool AllowRecentering => false;

		public static float FloorOffset => 0f;

		public TFeature GetFeature<TFeature>() where TFeature : OpenXRFeature
		{
			return null;
		}

		public OpenXRFeature GetFeature(Type featureType)
		{
			return null;
		}

		public OpenXRFeature[] GetFeatures<TFeature>()
		{
			return null;
		}

		public OpenXRFeature[] GetFeatures(Type featureType)
		{
			return null;
		}

		public int GetFeatures<TFeature>(List<TFeature> featuresOut) where TFeature : OpenXRFeature
		{
			return 0;
		}

		public int GetFeatures(Type featureType, List<OpenXRFeature> featuresOut)
		{
			return 0;
		}

		public OpenXRFeature[] GetFeatures()
		{
			return null;
		}

		public int GetFeatures(List<OpenXRFeature> featuresOut)
		{
			return 0;
		}

		private void ApplyRenderSettings()
		{
		}

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetRenderMode")]
		private static extern void Internal_SetRenderMode(RenderMode renderMode);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetRenderMode")]
		private static extern RenderMode Internal_GetRenderMode();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetDepthSubmissionMode")]
		private static extern void Internal_SetDepthSubmissionMode(DepthSubmissionMode depthSubmissionMode);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetDepthSubmissionMode")]
		private static extern DepthSubmissionMode Internal_GetDepthSubmissionMode();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetSymmetricProjection")]
		private static extern void Internal_SetSymmetricProjection([MarshalAs(UnmanagedType.I1)] bool enabled);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetOptimizeBufferDiscards")]
		private static extern void Internal_SetOptimizeBufferDiscards([MarshalAs(UnmanagedType.I1)] bool enabled);

		[DllImport("UnityOpenXR", EntryPoint = "OculusFoveation_SetUsedApi")]
		private static extern void Internal_SetUsedFoveatedRenderingApi(BackendFovationApi api);

		[DllImport("UnityOpenXR", EntryPoint = "OculusFoveation_GetUsedApi")]
		internal static extern BackendFovationApi Internal_GetUsedFoveatedRenderingApi();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetColorSubmissionMode")]
		private static extern void Internal_SetColorSubmissionMode(ColorSubmissionModeGroup[] colorSubmissionMode);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetColorSubmissionModes")]
		private static extern void Internal_SetColorSubmissionModes(int[] colorSubmissionMode, int arraySize);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetColorSubmissionModes")]
		private static extern int Internal_GetColorSubmissionModes([Out] int[] colorSubmissionMode, int arraySize);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetIsUsingLegacyXRDisplay")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetIsUsingLegacyXRDisplay();

		private void Awake()
		{
		}

		internal void ApplySettings()
		{
		}

		private static OpenXRSettings GetInstance(bool useActiveBuildTarget)
		{
			return null;
		}

		public static void SetAllowRecentering(bool allowRecentering, float floorOffset = 1.5f)
		{
		}

		public static void RefreshRecenterSpace()
		{
		}

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetAllowRecentering")]
		private static extern void Internal_SetAllowRecentering([MarshalAs(UnmanagedType.U1)] bool active, float height);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_RegenerateTrackingOrigin")]
		private static extern void Internal_RegenerateTrackingOrigin();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetAllowRecentering")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetAllowRecentering();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetFloorOffsetHeight")]
		private static extern float Internal_GetFloorOffset();
	}
}
