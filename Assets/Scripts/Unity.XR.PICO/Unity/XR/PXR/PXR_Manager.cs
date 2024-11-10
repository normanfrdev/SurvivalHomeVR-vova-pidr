using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

namespace Unity.XR.PXR
{
	public class PXR_Manager : MonoBehaviour
	{
		private struct LayerTexture
		{
			public Texture[] swapChain;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass118_0
		{
			public Task<(PxrResult result, List<PxrSpatialMeshInfo> meshInfos)> task;

			internal bool _003CQuerySpatialMeshAnchor_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CQuerySpatialMeshAnchor_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private _003C_003Ec__DisplayClass118_0 _003C_003E8__1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CQuerySpatialMeshAnchor_003Ed__118(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetFoveationLevel_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PXR_Manager _003C_003E4__this;

			private int _003Cnum_003E5__2;

			private bool _003Cresult_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSetFoveationLevel_003Ed__107(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CStartXR_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStartXR_003Ed__110(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string TAG = "[PXR_Manager]";

		private static PXR_Manager instance;

		private Camera[] eyeCamera;

		private bool appSpaceWarp;

		private Transform m_AppSpaceTransform;

		private DepthTextureMode m_CachedDepthTextureMode;

		[HideInInspector]
		public bool screenFade;

		[HideInInspector]
		public bool eyeTracking;

		[HideInInspector]
		public FaceTrackingMode trackingMode;

		[HideInInspector]
		public SharpeningMode sharpeningMode;

		[HideInInspector]
		public SharpeningEnhance sharpeningEnhance;

		[HideInInspector]
		public bool faceTracking;

		[HideInInspector]
		public bool lipsyncTracking;

		[HideInInspector]
		public bool lateLatching;

		[HideInInspector]
		public bool latelatchingDebug;

		[HideInInspector]
		public bool bodyTracking;

		[HideInInspector]
		public FoveationLevel foveationLevel;

		[HideInInspector]
		public bool adaptiveResolution;

		[HideInInspector]
		public FoveationLevel eyeFoveationLevel;

		[HideInInspector]
		public FoveatedRenderingMode foveatedRenderingMode;

		[HideInInspector]
		public bool openMRC;

		[HideInInspector]
		public LayerMask foregroundLayerMask;

		[HideInInspector]
		public LayerMask backgroundLayerMask;

		private static bool mrcXmlCamData;

		private static bool initMRCSucceed;

		private Texture[] swapChain;

		private LayerTexture[] layerTexturesInfo;

		private bool createMRCOverlaySucceed;

		private int imageIndex;

		private uint imageCounts;

		private static ExternalCameraInfo cameraInfo;

		private bool mrcCamObjActived;

		private float[] cameraAttribute;

		private PxrLayerParam layerParam;

		[HideInInspector]
		public GameObject backgroundCamObj;

		[HideInInspector]
		public GameObject foregroundCamObj;

		[HideInInspector]
		public RenderTexture mrcBackgroundRT;

		[HideInInspector]
		public RenderTexture mrcForegroundRT;

		private Color foregroundColor;

		private static float height;

		[SerializeField]
		[HideInInspector]
		public AdaptiveResolutionPowerSetting adaptiveResolutionPowerSetting;

		[SerializeField]
		[HideInInspector]
		public float minEyeTextureScale;

		[SerializeField]
		[HideInInspector]
		public float maxEyeTextureScale;

		private IntPtr layerSubmitPtr;

		private bool isNeedResume;

		[HideInInspector]
		public bool enableSuperResolution;

		[HideInInspector]
		public bool useRecommendedAntiAliasingLevel;

		private List<PxrEventDataBuffer> eventList;

		private static bool _enableVideoSeeThrough;

		private const string TAG_MRC = "PXR MRC ";

		private const int LAYER_MRC = 99999;

		private GameObject mrcCube;

		public static PXR_Manager Instance => null;

		[HideInInspector]
		public static bool EnableVideoSeeThrough
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static event Action<PxrEventAnchorEntityCreated> AnchorEntityCreated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static event Action<PxrEventSpatialTrackingStateUpdate> SpatialTrackingStateUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static event Action<PxrEventAnchorEntityPersisted> AnchorEntityPersisted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static event Action<PxrEventAnchorEntityUnPersisted> AnchorEntityUnPersisted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static event Action<PxrEventAnchorEntityCleared> AnchorEntityCleared
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static event Action<PxrEventAnchorEntityLoaded> AnchorEntityLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static event Action<PxrEventSpatialSceneCaptured> SpatialSceneCaptured
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<PxrSpatialMapSizeLimitedReason> SpatialMapSizeLimited
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<PxrEventAutoRoomCaptureUpdated> AutoRoomCaptureUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<PxrEventSenseDataProviderStateChanged> SenseDataProviderStateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<PxrVstStatus> VstDisplayStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ulong> SenseDataUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action SpatialAnchorDataUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<List<PxrSpatialMeshInfo>> SpatialMeshDataUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action SceneAnchorDataUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action SemiAutoCaptureDataUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<bool> EnableVideoSeeThroughAction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CSetFoveationLevel_003Ed__107))]
		private IEnumerator SetFoveationLevel()
		{
			return null;
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void OnApplicationQuit()
		{
		}

		[IteratorStateMachine(typeof(_003CStartXR_003Ed__110))]
		public IEnumerator StartXR()
		{
			return null;
		}

		private void StopXR()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateAdaptiveResolution()
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		private void PollEvent()
		{
		}

		[IteratorStateMachine(typeof(_003CQuerySpatialMeshAnchor_003Ed__118))]
		private IEnumerator QuerySpatialMeshAnchor()
		{
			return null;
		}

		public void SetSpaceWarp(bool enabled)
		{
		}

		private void OnDisable()
		{
		}

		public Camera[] GetEyeCamera()
		{
			return null;
		}

		private void EndRendering(ScriptableRenderContext arg1, Camera[] arg2)
		{
		}

		public void OnPostRenderCallBack(Camera cam)
		{
		}

		private void CreateMRCOverlay()
		{
		}

		public void CopyAndSubmitMRCLayer()
		{
		}

		private void UpdateMRCCam()
		{
		}

		public void CreateMRCCam()
		{
		}

		private void SeethroughStateChangedMethod(int status)
		{
		}

		private void InitMRCCam(Camera camera, bool isForeground)
		{
		}

		public void CalibrationMRCCam()
		{
		}
	}
}
