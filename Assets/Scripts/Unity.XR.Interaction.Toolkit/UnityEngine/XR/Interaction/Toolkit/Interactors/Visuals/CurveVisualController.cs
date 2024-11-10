using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Visual/Curve Visual Controller", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController.html")]
	[BurstCompile]
	public class CurveVisualController : MonoBehaviour
	{
		public delegate void GetAdjustedEndPointForMaxDistance_00000C29_0024PostfixBurstDelegate(in float3 origin, in float3 endPoint, float maxDistance, out float3 newEndPoint);

		internal static class GetAdjustedEndPointForMaxDistance_00000C29_0024BurstDirectCall
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

			public static void Invoke(in float3 origin, in float3 endPoint, float maxDistance, out float3 newEndPoint)
			{
				newEndPoint = default(float3);
			}
		}

		public delegate void GetClosestPointOnLine_00000C2A_0024PostfixBurstDelegate(in float3 origin, in float3 direction, in float3 point, out float3 newPoint);

		internal static class GetClosestPointOnLine_00000C2A_0024BurstDirectCall
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

			public static void Invoke(in float3 origin, in float3 direction, in float3 point, out float3 newPoint)
			{
				newPoint = default(float3);
			}
		}

		public delegate void AdjustCastHitEndPoint_00000C2B_0024PostfixBurstDelegate(in float3 worldOrigin, in float3 worldDirection, in float3 hitEndPoint, in float3 sampleEndPoint, out float validHitDistance, out float3 endPoint);

		internal static class AdjustCastHitEndPoint_00000C2B_0024BurstDirectCall
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

			public static void Invoke(in float3 worldOrigin, in float3 worldDirection, in float3 hitEndPoint, in float3 sampleEndPoint, out float validHitDistance, out float3 endPoint)
			{
				validHitDistance = default(float);
				endPoint = default(float3);
			}
		}

		public delegate bool ComputeFallBackLine_00000C2C_0024PostfixBurstDelegate(in float3 curveOrigin, in float3 endPoint, float startOffset, float endOffset, ref NativeArray<float3> fallBackTargetPoints);

		internal static class ComputeFallBackLine_00000C2C_0024BurstDirectCall
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

			public static bool Invoke(in float3 curveOrigin, in float3 endPoint, float startOffset, float endOffset, ref NativeArray<float3> fallBackTargetPoints)
			{
				return false;
			}
		}

		[SerializeField]
		private LineRenderer m_LineRenderer;

		[SerializeField]
		[RequireInterface(typeof(ICurveInteractionDataProvider))]
		private Object m_CurveVisualObject;

		private readonly UnityObjectReferenceCache<ICurveInteractionDataProvider, Object> m_CurveDataProviderObjectRef;

		[SerializeField]
		private bool m_OverrideLineOrigin;

		[SerializeField]
		private Transform m_LineOriginTransform;

		[SerializeField]
		private int m_VisualPointCount;

		[SerializeField]
		private float m_MaxVisualCurveDistance;

		[SerializeField]
		private float m_RestingVisualLineLength;

		[SerializeField]
		private LineDynamicsMode m_LineDynamicsMode;

		[SerializeField]
		private float m_RetractDelay;

		[SerializeField]
		private float m_RetractDuration;

		[SerializeField]
		private bool m_ExtendLineToEmptyHit;

		[SerializeField]
		[Range(0f, 30f)]
		private float m_ExtensionRate;

		[SerializeField]
		private float m_EndPointExpansionRate;

		[SerializeField]
		private bool m_ComputeMidPointWithComplexCurves;

		[SerializeField]
		private bool m_SnapToSelectedAttachIfAvailable;

		[SerializeField]
		private bool m_SnapToSnapVolumeIfAvailable;

		[SerializeField]
		private float m_CurveStartOffset;

		[SerializeField]
		private float m_CurveEndOffset;

		[SerializeField]
		private bool m_CustomizeLinePropertiesForState;

		[SerializeField]
		private float m_LinePropertyAnimationSpeed;

		[SerializeField]
		private LineProperties m_NoValidHitProperties;

		[SerializeField]
		private LineProperties m_UIHitProperties;

		[SerializeField]
		private LineProperties m_UIPressHitProperties;

		[SerializeField]
		private LineProperties m_SelectHitProperties;

		[SerializeField]
		private LineProperties m_HoverHitProperties;

		[SerializeField]
		private bool m_RenderLineInWorldSpace;

		[SerializeField]
		private bool m_SwapMaterials;

		[SerializeField]
		private Material m_BaseLineMaterial;

		[SerializeField]
		private Material m_EmptyHitMaterial;

		private const float k_CurveFallbackLength = 0.06f;

		private const int k_FallBackLinePointCount = 3;

		private NativeArray<Vector3> m_InternalSamplePoints;

		private NativeArray<Vector3> m_FallBackSamplePoints;

		private Transform m_ParentTransform;

		private float m_LastHitTime;

		private float m_LengthToLastHit;

		private float m_LineLength;

		private int m_LastPosCount;

		private float m_RenderLengthMultiplier;

		private bool m_CanSwapMaterials;

		private float m_LastLineStartWidth;

		private float m_LastLineEndWidth;

		private float m_EndPointTypeChangeTime;

		private float m_LastBendRatio;

		private bool m_UseCustomOrigin;

		private EndPointType m_LastEndPointType;

		private bool m_LastValidSelectState;

		private Gradient m_LerpGradient;

		public LineRenderer lineRenderer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICurveInteractionDataProvider curveInteractionDataProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool overrideLineOrigin
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

		public int visualPointCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float maxVisualCurveDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float restingVisualLineLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public LineDynamicsMode lineDynamicsMode
		{
			get
			{
				return default(LineDynamicsMode);
			}
			set
			{
			}
		}

		public float retractDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float retractDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool extendLineToEmptyHit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float extensionRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endPointExpansionRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool computeMidPointWithComplexCurves
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool snapToSelectedAttachIfAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool snapToSnapVolumeIfAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float curveStartOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curveEndOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool customizeLinePropertiesForState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float linePropertyAnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public LineProperties noValidHitProperties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LineProperties uiHitProperties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LineProperties uiPressHitProperties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LineProperties selectHitProperties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LineProperties hoverHitProperties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool renderLineInWorldSpace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool swapMaterials
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Material baseLineMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material emptyHitMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void LateUpdate()
		{
		}

		private bool CheckIfVisualStateChanged(EndPointType newPointType, bool hasValidSelect)
		{
			return false;
		}

		private void GetLineOriginAndDirection(out Vector3 worldOrigin, out Vector3 worldDirection)
		{
			worldOrigin = default(Vector3);
			worldDirection = default(Vector3);
		}

		private EndPointType GetEndpointInformation(Vector3 worldOrigin, Vector3 worldDirection, ref float validHitDistance, out Vector3 endPoint)
		{
			endPoint = default(Vector3);
			return default(EndPointType);
		}

		private void UpdateLinePoints(EndPointType endPointType, Vector3 worldOrigin, Vector3 worldEndPoint, Vector3 worldDirection, float startOffset = 0f, float endOffset = 0f, bool forceStraightLineFallback = false)
		{
		}

		private static bool TryGetMidPointFromCurveSamples(in ICurveInteractionDataProvider curveInteractionDataProvider, out Vector3 midPoint)
		{
			midPoint = default(Vector3);
			return false;
		}

		private bool TryGetLineProperties(EndPointType endPointType, out LineProperties properties)
		{
			properties = null;
			return false;
		}

		private float GetLineBendRatio(EndPointType endPointType)
		{
			return 0f;
		}

		private void DetermineOffsets(EndPointType endPointType, float lineDistance, out float startOffset, out float endOffset)
		{
			startOffset = default(float);
			endOffset = default(float);
		}

		private void UpdateLineWidth(EndPointType endPointType, float targetDistance)
		{
		}

		private void UpdateGradient(EndPointType endPointType)
		{
		}

		private void SetLinePositions(NativeArray<Vector3> targetPoints, int numPoints)
		{
		}

		private float UpdateTargetDistance(EndPointType endPointType, float validHitDistance, float minLength, float maxLength, bool retractOnHitLoss, float retractionDelay, float retractionDuration, float curveExtensionRate)
		{
			return 0f;
		}

		private void SwapMaterials(EndPointType endPointType)
		{
		}

		private void ValidatePointCount()
		{
		}

		[BurstCompile]
		private static void GetAdjustedEndPointForMaxDistance(in float3 origin, in float3 endPoint, float maxDistance, out float3 newEndPoint)
		{
			newEndPoint = default(float3);
		}

		[BurstCompile]
		private static void GetClosestPointOnLine(in float3 origin, in float3 direction, in float3 point, out float3 newPoint)
		{
			newPoint = default(float3);
		}

		[BurstCompile]
		private static void AdjustCastHitEndPoint(in float3 worldOrigin, in float3 worldDirection, in float3 hitEndPoint, in float3 sampleEndPoint, out float validHitDistance, out float3 endPoint)
		{
			validHitDistance = default(float);
			endPoint = default(float3);
		}

		[BurstCompile]
		private static bool ComputeFallBackLine(in float3 curveOrigin, in float3 endPoint, float startOffset, float endOffset, ref NativeArray<float3> fallBackTargetPoints)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void GetAdjustedEndPointForMaxDistance_0024BurstManaged(in float3 origin, in float3 endPoint, float maxDistance, out float3 newEndPoint)
		{
			newEndPoint = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void GetClosestPointOnLine_0024BurstManaged(in float3 origin, in float3 direction, in float3 point, out float3 newPoint)
		{
			newPoint = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void AdjustCastHitEndPoint_0024BurstManaged(in float3 worldOrigin, in float3 worldDirection, in float3 hitEndPoint, in float3 sampleEndPoint, out float validHitDistance, out float3 endPoint)
		{
			validHitDistance = default(float);
			endPoint = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool ComputeFallBackLine_0024BurstManaged(in float3 curveOrigin, in float3 endPoint, float startOffset, float endOffset, ref NativeArray<float3> fallBackTargetPoints)
		{
			return false;
		}
	}
}
