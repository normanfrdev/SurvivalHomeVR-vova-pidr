using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.XR.CoreUtils;
using Unity.XR.CoreUtils.Bindings;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[AddComponentMenu("XR/Visual/XR Interactor Line Visual", 11)]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(LineRenderer))]
	[DefaultExecutionOrder(100)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual.html")]
	[BurstCompile]
	public class XRInteractorLineVisual : MonoBehaviour, IXRCustomReticleProvider
	{
		public delegate void CalculateLineCurveRenderPoints_00000C7F_0024PostfixBurstDelegate(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3> targetPoints);

		internal static class CalculateLineCurveRenderPoints_00000C7F_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static void Invoke(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3> targetPoints)
			{
			}
		}

		public delegate int ComputeNewRenderPoints_00000C80_0024PostfixBurstDelegate(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3> targetPoints, ref NativeArray<float3> previousRenderPoints, ref NativeArray<float3> renderPoints);

		internal static class ComputeNewRenderPoints_00000C80_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static int Invoke(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3> targetPoints, ref NativeArray<float3> previousRenderPoints, ref NativeArray<float3> renderPoints)
			{
				return 0;
			}
		}

		public delegate bool EvaluateLineEndPoint_00000C81_0024PostfixBurstDelegate(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength);

		internal static class EvaluateLineEndPoint_00000C81_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static bool Invoke(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength)
			{
				return false;
			}
		}

		private const float k_MinLineWidth = 0.0001f;

		private const float k_MaxLineWidth = 0.05f;

		private const float k_MinLineBendRatio = 0.01f;

		private const float k_MaxLineBendRatio = 1f;

		[SerializeField]
		[Range(0.0001f, 0.05f)]
		private float m_LineWidth;

		[SerializeField]
		private bool m_OverrideInteractorLineLength;

		[SerializeField]
		private float m_LineLength;

		[SerializeField]
		private bool m_AutoAdjustLineLength;

		[SerializeField]
		private float m_MinLineLength;

		[SerializeField]
		private bool m_UseDistanceToHitAsMaxLineLength;

		[SerializeField]
		private float m_LineRetractionDelay;

		[SerializeField]
		private float m_LineLengthChangeSpeed;

		[SerializeField]
		private AnimationCurve m_WidthCurve;

		[SerializeField]
		private bool m_SetLineColorGradient;

		[SerializeField]
		private Gradient m_ValidColorGradient;

		[SerializeField]
		private Gradient m_InvalidColorGradient;

		[SerializeField]
		private Gradient m_BlockedColorGradient;

		[SerializeField]
		private bool m_TreatSelectionAsValidState;

		[SerializeField]
		private bool m_SmoothMovement;

		[SerializeField]
		private float m_FollowTightness;

		[SerializeField]
		private float m_SnapThresholdDistance;

		[SerializeField]
		private GameObject m_Reticle;

		[SerializeField]
		private GameObject m_BlockedReticle;

		[SerializeField]
		private bool m_StopLineAtFirstRaycastHit;

		[SerializeField]
		private bool m_StopLineAtSelection;

		[SerializeField]
		private bool m_SnapEndpointIfAvailable;

		[SerializeField]
		[Range(0.01f, 1f)]
		private float m_LineBendRatio;

		[SerializeField]
		private bool m_OverrideInteractorLineOrigin;

		[SerializeField]
		private Transform m_LineOriginTransform;

		[SerializeField]
		private float m_LineOriginOffset;

		private float m_SquareSnapThresholdDistance;

		private Vector3 m_ReticlePos;

		private Vector3 m_ReticleNormal;

		private int m_EndPositionInLine;

		private bool m_SnapCurve;

		private bool m_PerformSetup;

		private GameObject m_ReticleToUse;

		private LineRenderer m_LineRenderer;

		private ILineRenderable m_LineRenderable;

		private IAdvancedLineRenderable m_AdvancedLineRenderable;

		private bool m_HasAdvancedLineRenderable;

		private IXRSelectInteractor m_LineRenderableAsSelectInteractor;

		private IXRHoverInteractor m_LineRenderableAsHoverInteractor;

		private XRBaseInteractor m_LineRenderableAsBaseInteractor;

		private XRRayInteractor m_LineRenderableAsRayInteractor;

		private NativeArray<Vector3> m_TargetPoints;

		private int m_NumTargetPoints;

		private Vector3[] m_TargetPointsFallback;

		private NativeArray<Vector3> m_RenderPoints;

		private int m_NumRenderPoints;

		private NativeArray<Vector3> m_PreviousRenderPoints;

		private int m_NumPreviousRenderPoints;

		private readonly Vector3[] m_ClearArray;

		private GameObject m_CustomReticle;

		private bool m_CustomReticleAttached;

		private XRInteractableSnapVolume m_XRInteractableSnapVolume;

		private const int k_NumberOfSegmentsForBendableLine = 20;

		private bool m_PreviousShouldBendLine;

		private Vector3 m_PreviousLineDirection;

		private Vector3 m_CurrentHitPoint;

		private bool m_HasHitInfo;

		private bool m_ValidHit;

		private float m_LastValidHitTime;

		private float m_LastValidLineLength;

		private Collider m_PreviousCollider;

		private XROrigin m_XROrigin;

		private bool m_HasRayInteractor;

		private bool m_HasBaseInteractor;

		private bool m_HasHoverInteractor;

		private bool m_HasSelectInteractor;

		private readonly BindableVariable<float> m_UserScaleVar;

		private readonly FloatTweenableVariable m_LineLengthOverrideTweenableVariable;

		private readonly BindingsGroup m_BindingsGroup;

		public float lineWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool overrideInteractorLineLength
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float lineLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool autoAdjustLineLength
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float minLineLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useDistanceToHitAsMaxLineLength
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float lineRetractionDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lineLengthChangeSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve widthCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool setLineColorGradient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Gradient validColorGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Gradient invalidColorGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Gradient blockedColorGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool treatSelectionAsValidState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool smoothMovement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float followTightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float snapThresholdDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GameObject reticle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject blockedReticle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool stopLineAtFirstRaycastHit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stopLineAtSelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool snapEndpointIfAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float lineBendRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool overrideInteractorLineOrigin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform lineOriginTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float lineOriginOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected void Reset()
		{
		}

		protected void OnValidate()
		{
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void LateUpdate()
		{
		}

		[BeforeRenderOrder(101)]
		private void OnBeforeRenderLineVisual()
		{
		}

		internal void UpdateLineVisual()
		{
		}

		private bool GetLinePoints(ref NativeArray<Vector3> linePoints, out int numPoints)
		{
			numPoints = default(int);
			return false;
		}

		private void AdjustLineAndReticle(bool hasSelection, bool bendLine, in Vector3 lineOrigin, in Vector3 targetEndPoint)
		{
		}

		private void FindClosestInteractableAttachPoint(in Vector3 lineOrigin, out Vector3 closestPoint)
		{
			closestPoint = default(Vector3);
		}

		private static bool EnsureSize(ref NativeArray<Vector3> array, int targetSize)
		{
			return false;
		}

		private void GetLineOriginAndDirection(ref NativeArray<Vector3> targetPoints, int numTargetPoints, bool isLineStraight, out Vector3 lineOrigin, out Vector3 lineDirection)
		{
			lineOrigin = default(Vector3);
			lineDirection = default(Vector3);
		}

		private bool ExtractHitInformation(ref NativeArray<Vector3> targetPoints, int numTargetPoints, out Vector3 targetEndPoint, out bool hitSnapVolume)
		{
			targetEndPoint = default(Vector3);
			hitSnapVolume = default(bool);
			return false;
		}

		[BurstCompile]
		private static void CalculateLineCurveRenderPoints(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3> targetPoints)
		{
		}

		[BurstCompile]
		private static int ComputeNewRenderPoints(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3> targetPoints, ref NativeArray<float3> previousRenderPoints, ref NativeArray<float3> renderPoints)
		{
			return 0;
		}

		[BurstCompile]
		private static bool EvaluateLineEndPoint(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength)
		{
			return false;
		}

		private float UpdateTargetLineLength(in Vector3 lineOrigin, in Vector3 hitPoint, float minimumLineLength, float maximumLineLength, float lineRetractionDelaySeconds, float lineRetractionScalar, bool hasHit, bool deriveMaxLineLength)
		{
			return 0f;
		}

		private void AssignReticle(bool useBlockedVisuals)
		{
		}

		private void ClearReticle()
		{
		}

		private void SetColorGradient(Gradient colorGradient)
		{
		}

		private void UpdateSettings()
		{
		}

		private bool TryFindLineRenderer()
		{
			return false;
		}

		private void ClearLineRenderer()
		{
		}

		private void FindXROrigin()
		{
		}

		private void SetupReticle()
		{
		}

		private void SetupBlockedReticle()
		{
		}

		public bool AttachCustomReticle(GameObject reticleInstance)
		{
			return false;
		}

		public bool RemoveCustomReticle()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void CalculateLineCurveRenderPoints_0024BurstManaged(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3> targetPoints)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static int ComputeNewRenderPoints_0024BurstManaged(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3> targetPoints, ref NativeArray<float3> previousRenderPoints, ref NativeArray<float3> renderPoints)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool EvaluateLineEndPoint_0024BurstManaged(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength)
		{
			return false;
		}
	}
}
