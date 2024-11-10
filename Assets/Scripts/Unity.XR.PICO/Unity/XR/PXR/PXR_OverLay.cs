using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.PXR
{
	public class PXR_OverLay : MonoBehaviour, IComparable<PXR_OverLay>
	{
		public delegate void ExternalAndroidSurfaceObjectCreated();

		private struct NativeTexture
		{
			public Texture[] textures;
		}

		public enum HDRFlags
		{
			None = 0,
			HdrPQ = 1,
			HdrHLG = 2
		}

		public enum OverlayShape
		{
			Quad = 1,
			Cylinder = 2,
			Equirect = 3,
			Cubemap = 5,
			Eac = 6,
			Fisheye = 7,
			BlurredQuad = 9
		}

		public enum OverlayType
		{
			Overlay = 0,
			Underlay = 1
		}

		public enum TextureType
		{
			ExternalSurface = 0,
			DynamicTexture = 1,
			StaticTexture = 2
		}

		public enum LayerLayout
		{
			Stereo = 0,
			DoubleWide = 1,
			Array = 2,
			Mono = 3
		}

		public enum Surface3DType
		{
			Single = 0,
			LeftRight = 1,
			TopBottom = 2
		}

		public enum TextureRect
		{
			MonoScopic = 0,
			StereoScopic = 1,
			Custom = 2
		}

		public enum DestinationRect
		{
			Default = 0,
			Custom = 1
		}

		public enum EACModelType
		{
			Eac360 = 0,
			Eac360ViewPort = 1,
			Eac180 = 4,
			Eac180ViewPort = 5
		}

		public enum ColorForamt
		{
			VK_FORMAT_R8G8B8A8_UNORM = 37,
			VK_FORMAT_R8G8B8A8_SRGB = 43,
			GL_SRGB8_ALPHA8 = 35907,
			GL_RGBA8 = 32856
		}

		public enum APIExecutionStatus
		{
			None = 0,
			True = 1,
			False = 2
		}

		public enum BlurredQuadMode
		{
			SmallWindow = 0,
			Immersion = 1
		}

		private const string TAG = "[PXR_CompositeLayers]";

		public static List<PXR_OverLay> Instances;

		private static int overlayID;

		[NonSerialized]
		public int overlayIndex;

		public int layerDepth;

		public int imageIndex;

		public OverlayType overlayType;

		public OverlayShape overlayShape;

		public TextureType textureType;

		public Transform overlayTransform;

		public Camera xrRig;

		public Texture[] layerTextures;

		public bool isPremultipliedAlpha;

		public bool isDynamic;

		public int[] overlayTextureIds;

		public Matrix4x4[] mvMatrixs;

		public Vector3[] modelScales;

		public Quaternion[] modelRotations;

		public Vector3[] modelTranslations;

		public Quaternion[] cameraRotations;

		public Vector3[] cameraTranslations;

		public Camera[] overlayEyeCamera;

		public bool overrideColorScaleAndOffset;

		public Vector4 colorScale;

		public Vector4 colorOffset;

		public Vector3 offsetPosLeft;

		public Vector3 offsetPosRight;

		public Vector4 offsetRotLeft;

		public Vector4 offsetRotRight;

		public EACModelType eacModelType;

		public float overlapFactor;

		public ulong timestamp;

		private Vector4 overlayLayerColorScaleDefault;

		private Vector4 overlayLayerColorOffsetDefault;

		public bool isExternalAndroidSurface;

		public bool isExternalAndroidSurfaceDRM;

		public Surface3DType externalAndroidSurface3DType;

		public BlurredQuadMode blurredQuadMode;

		public float blurredQuadScale;

		public float blurredQuadShift;

		public float blurredQuadFOV;

		public float blurredQuadIPD;

		public IntPtr externalAndroidSurfaceObject;

		public ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated;

		public float radius;

		public bool useImageRect;

		public TextureRect textureRect;

		public DestinationRect destinationRect;

		public Rect srcRectLeft;

		public Rect srcRectRight;

		public Rect dstRectLeft;

		public Rect dstRectRight;

		public PxrRecti imageRectLeft;

		public PxrRecti imageRectRight;

		public bool useLayerBlend;

		public PxrBlendFactor srcColor;

		public PxrBlendFactor dstColor;

		public PxrBlendFactor srcAlpha;

		public PxrBlendFactor dstAlpha;

		public float[] colorMatrix;

		public bool isClones;

		public bool isClonesToNew;

		public bool enableSubmitLayer;

		public PXR_OverLay originalOverLay;

		public IntPtr layerSubmitPtr;

		public APIExecutionStatus Quad2Status;

		public APIExecutionStatus Cylinder2Status;

		public APIExecutionStatus Equirect2Status;

		private bool toCreateSwapChain;

		private bool toCopyRT;

		private bool copiedRT;

		private int eyeCount;

		private uint imageCounts;

		private PxrLayerParam overlayParam;

		private NativeTexture[] nativeTextures;

		private static Material cubeM;

		private IntPtr leftPtr;

		private IntPtr rightPtr;

		private static Material textureM;

		public HDRFlags hdr;

		public int CompareTo(PXR_OverLay other)
		{
			return 0;
		}

		protected void Awake()
		{
		}

		private void Start()
		{
		}

		public void RefreshCamera(Camera leftCamera, Camera rightCamera)
		{
		}

		private void InitializeBuffer()
		{
		}

		public void CreateExternalSurface(PXR_OverLay overlayInstance)
		{
		}

		public void UpdateCoords()
		{
		}

		public bool CreateTexture()
		{
			return false;
		}

		public bool CopyRT()
		{
			return false;
		}

		public void SetTexture(Texture texture, bool dynamic)
		{
		}

		private void FreePtr()
		{
		}

		public void OnDestroy()
		{
		}

		public void DestroyLayer()
		{
		}

		private void ClearTexture()
		{
		}

		public void SetLayerColorScaleAndOffset(Vector4 scale, Vector4 offset)
		{
		}

		public void SetEACOffsetPosAndRot(Vector3 leftPos, Vector3 rightPos, Vector4 leftRot, Vector4 rightRot)
		{
		}

		public void SetEACFactor(float factor)
		{
		}

		public Vector4 GetLayerColorScale()
		{
			return default(Vector4);
		}

		public Vector4 GetLayerColorOffset()
		{
			return default(Vector4);
		}

		public PxrRecti getPxrRectiLeft(bool left)
		{
			return default(PxrRecti);
		}

		public uint getHDRFlags()
		{
			return 0u;
		}
	}
}
