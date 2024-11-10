using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Interactors/XR Ray Interactor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.html")]
	public class XRRayInteractor : XRBaseInputInteractor, IAdvancedLineRenderable, ILineRenderable, IUIHoverInteractor, IUIInteractor, IXRRayProvider, IXRScaleValueProvider
	{
		protected sealed class RaycastHitComparer : IComparer<RaycastHit>
		{
			public int Compare(RaycastHit a, RaycastHit b)
			{
				return 0;
			}
		}

		public enum LineType
		{
			StraightLine = 0,
			ProjectileCurve = 1,
			BezierCurve = 2
		}

		public enum QuerySnapVolumeInteraction
		{
			Ignore = 0,
			Collide = 1
		}

		public enum HitDetectionType
		{
			Raycast = 0,
			SphereCast = 1,
			ConeCast = 2
		}

		public enum RotateMode
		{
			RotateOverTime = 0,
			MatchDirection = 1
		}

		private struct SamplePoint
		{
			public float3 position
			{
				[CompilerGenerated]
				readonly get
				{
					return default(float3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float parameter
			{
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Obsolete("AnchorRotationMode has been deprecated in version 3.0.0. Use RotateMode instead.")]
		public enum AnchorRotationMode
		{
			RotateOverTime = 0,
			MatchDirection = 1
		}

		private const int k_MaxRaycastHits = 10;

		private const int k_MaxSpherecastHits = 10;

		private const int k_MinSampleFrequency = 2;

		private const int k_MaxSampleFrequency = 100;

		private static readonly List<IXRInteractable> s_Results;

		private static readonly RaycastHit[] s_SpherecastScratch;

		private static readonly HashSet<Collider> s_OptimalHits;

		[SerializeField]
		private LineType m_LineType;

		[SerializeField]
		private bool m_BlendVisualLinePoints;

		[SerializeField]
		private float m_MaxRaycastDistance;

		[SerializeField]
		private Transform m_RayOriginTransform;

		[SerializeField]
		private Transform m_ReferenceFrame;

		[SerializeField]
		private float m_Velocity;

		[SerializeField]
		private float m_Acceleration;

		[SerializeField]
		private float m_AdditionalGroundHeight;

		[SerializeField]
		private float m_AdditionalFlightTime;

		[SerializeField]
		private float m_EndPointDistance;

		[SerializeField]
		private float m_EndPointHeight;

		[SerializeField]
		private float m_ControlPointDistance;

		[SerializeField]
		private float m_ControlPointHeight;

		[SerializeField]
		[Range(2f, 100f)]
		private int m_SampleFrequency;

		[SerializeField]
		private HitDetectionType m_HitDetectionType;

		[SerializeField]
		[Range(0.01f, 0.25f)]
		private float m_SphereCastRadius;

		[SerializeField]
		[Range(0f, 180f)]
		private float m_ConeCastAngle;

		[SerializeField]
		private LayerMask m_RaycastMask;

		[SerializeField]
		private QueryTriggerInteraction m_RaycastTriggerInteraction;

		[SerializeField]
		private QuerySnapVolumeInteraction m_RaycastSnapVolumeInteraction;

		[SerializeField]
		private bool m_HitClosestOnly;

		[SerializeField]
		private bool m_HoverToSelect;

		[SerializeField]
		private float m_HoverTimeToSelect;

		[SerializeField]
		private bool m_AutoDeselect;

		[SerializeField]
		private float m_TimeToAutoDeselect;

		[SerializeField]
		private bool m_EnableUIInteraction;

		[SerializeField]
		private bool m_BlockUIOnInteractableSelection;

		[FormerlySerializedAs("m_AllowAnchorControl")]
		[SerializeField]
		private bool m_ManipulateAttachTransform;

		[SerializeField]
		private bool m_UseForceGrab;

		[SerializeField]
		private float m_RotateSpeed;

		[SerializeField]
		private float m_TranslateSpeed;

		[FormerlySerializedAs("m_AnchorRotateReferenceFrame")]
		[SerializeField]
		private Transform m_RotateReferenceFrame;

		[FormerlySerializedAs("m_AnchorRotationMode")]
		[SerializeField]
		private RotateMode m_RotateMode;

		[SerializeField]
		private UIHoverEnterEvent m_UIHoverEntered;

		[SerializeField]
		private UIHoverExitEvent m_UIHoverExited;

		[SerializeField]
		private bool m_EnableARRaycasting;

		[SerializeField]
		private bool m_OccludeARHitsWith3DObjects;

		[SerializeField]
		private bool m_OccludeARHitsWith2DObjects;

		[SerializeField]
		private ScaleMode m_ScaleMode;

		[SerializeField]
		private XRInputButtonReader m_UIPressInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_UIScrollInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_TranslateManipulationInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_RotateManipulationInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_DirectionalManipulationInput;

		[SerializeField]
		private XRInputButtonReader m_ScaleToggleInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_ScaleOverTimeInput;

		[SerializeField]
		private XRInputValueReader<float> m_ScaleDistanceDeltaInput;

		private bool m_HasRayOriginTransform;

		private bool m_HasReferenceFrame;

		private bool m_ScaleInputActive;

		private readonly List<IXRInteractable> m_ValidTargets;

		private float m_LastTimeHoveredObjectChanged;

		private bool m_PassedHoverTimeToSelect;

		private float m_LastTimeAutoSelected;

		private bool m_PassedTimeToAutoDeselect;

		private GameObject m_LastUIObject;

		private float m_LastTimeHoveredUIChanged;

		private bool m_HoverUISelectActive;

		private bool m_BlockUIAutoDeselect;

		private readonly RaycastHit[] m_RaycastHits;

		private int m_RaycastHitsCount;

		private readonly RaycastHitComparer m_RaycastHitComparer;

		private List<SamplePoint> m_SamplePoints;

		private int m_SamplePointsFrameUpdated;

		private int m_RaycastHitEndpointIndex;

		private int m_UIRaycastHitEndpointIndex;

		private readonly float3[] m_ControlPoints;

		private readonly float3[] m_HitChordControlPoints;

		private static List<SamplePoint> s_ScratchSamplePoints;

		private static readonly float3[] s_ScratchControlPoints;

		private PhysicsScene m_LocalPhysicsScene;

		private RegisteredUIInteractorCache m_RegisteredUIInteractorCache;

		private bool m_RaycastHitOccurred;

		private RaycastHit m_RaycastHit;

		private RaycastResult m_UIRaycastHit;

		private bool m_IsUIHitClosest;

		private IXRInteractable m_RaycastInteractable;

		[Obsolete("m_ActionBasedController has been deprecated in version 3.0.0.")]
		private ActionBasedController m_ActionBasedController;

		[Obsolete("m_DeviceBasedController has been deprecated in version 3.0.0.")]
		private XRController m_DeviceBasedController;

		[Obsolete("m_ScreenSpaceController has been deprecated in version 3.0.0.")]
		private XRScreenSpaceController m_ScreenSpaceController;

		[Obsolete("m_IsActionBasedController has been deprecated in version 3.0.0.")]
		private bool m_IsActionBasedController;

		[Obsolete("m_IsDeviceBasedController has been deprecated in version 3.0.0.")]
		private bool m_IsDeviceBasedController;

		[Obsolete("m_IsScreenSpaceController has been deprecated in version 3.0.0.")]
		private bool m_IsScreenSpaceController;

		public LineType lineType
		{
			get
			{
				return default(LineType);
			}
			set
			{
			}
		}

		public bool blendVisualLinePoints
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float maxRaycastDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Transform rayOriginTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform referenceFrame
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float velocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float acceleration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float additionalGroundHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float additionalFlightTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endPointDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endPointHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float controlPointDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float controlPointHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int sampleFrequency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public HitDetectionType hitDetectionType
		{
			get
			{
				return default(HitDetectionType);
			}
			set
			{
			}
		}

		public float sphereCastRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float coneCastAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public LayerMask raycastMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public QueryTriggerInteraction raycastTriggerInteraction
		{
			get
			{
				return default(QueryTriggerInteraction);
			}
			set
			{
			}
		}

		public QuerySnapVolumeInteraction raycastSnapVolumeInteraction
		{
			get
			{
				return default(QuerySnapVolumeInteraction);
			}
			set
			{
			}
		}

		public bool hitClosestOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool hoverToSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float hoverTimeToSelect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool autoDeselect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float timeToAutoDeselect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableUIInteraction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool blockUIOnInteractableSelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool manipulateAttachTransform
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useForceGrab
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float rotateSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float translateSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Transform rotateReferenceFrame
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RotateMode rotateMode
		{
			get
			{
				return default(RotateMode);
			}
			set
			{
			}
		}

		public UIHoverEnterEvent uiHoverEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UIHoverExitEvent uiHoverExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enableARRaycasting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool occludeARHitsWith3DObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool occludeARHitsWith2DObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ScaleMode scaleMode
		{
			get
			{
				return default(ScaleMode);
			}
			set
			{
			}
		}

		public XRInputButtonReader uiPressInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> uiScrollInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> translateManipulationInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> rotateManipulationInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> directionalManipulationInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputButtonReader scaleToggleInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> scaleOverTimeInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<float> scaleDistanceDeltaInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float angle => 0f;

		protected IXRInteractable currentNearestValidTarget
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

		public Vector3 rayEndPoint
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform rayEndTransform
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

		public float scaleValue
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		private Transform effectiveRayOrigin => null;

		private Vector3 referenceUp => default(Vector3);

		private Vector3 referencePosition => default(Vector3);

		private int closestAnyHitIndex => 0;

		public override bool isSelectActive => false;

		[Obsolete("Velocity has been deprecated. Use velocity instead. (UnityUpgradable) -> velocity", true)]
		public float Velocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Acceleration has been deprecated. Use acceleration instead. (UnityUpgradable) -> acceleration", true)]
		public float Acceleration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("AdditionalFlightTime has been deprecated. Use additionalFlightTime instead. (UnityUpgradable) -> additionalFlightTime", true)]
		public float AdditionalFlightTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Angle has been deprecated. Use angle instead. (UnityUpgradable) -> angle", true)]
		public float Angle => 0f;

		[Obsolete("originalAttachTransform has been deprecated. Use rayOriginTransform instead. (UnityUpgradable) -> rayOriginTransform", true)]
		protected Transform originalAttachTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("allowAnchorControl has been renamed in version 3.0.0. Use manipulateAttachTransform instead. (UnityUpgradable) -> manipulateAttachTransform")]
		public bool allowAnchorControl
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("anchorRotateReferenceFrame has been renamed in version 3.0.0. Use rotateReferenceFrame instead. (UnityUpgradable) -> rotateReferenceFrame")]
		public Transform anchorRotateReferenceFrame
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("anchorRotationMode has been deprecated in version 3.0.0. Use rotateMode instead.")]
		public AnchorRotationMode anchorRotationMode
		{
			get
			{
				return default(AnchorRotationMode);
			}
			set
			{
			}
		}

		[Obsolete("isUISelectActive has been deprecated in version 3.0.0. Use a serialized XRInputButtonProvider to read button input instead.")]
		protected override bool isUISelectActive => false;

		protected void OnValidate()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void OnDrawGizmosSelected()
		{
		}

		private static void DrawQuadraticBezierGizmo(Vector3 p0, Vector3 p1, Vector3 p2)
		{
		}

		private void FindReferenceFrame()
		{
		}

		private void CreateRayOrigin()
		{
		}

		Transform IXRRayProvider.GetOrCreateRayOrigin()
		{
			return null;
		}

		Transform IXRRayProvider.GetOrCreateAttachTransform()
		{
			return null;
		}

		void IXRRayProvider.SetRayOrigin(Transform newOrigin)
		{
		}

		void IXRRayProvider.SetAttachTransform(Transform newAttach)
		{
		}

		public bool IsOverUIGameObject()
		{
			return false;
		}

		public bool GetLinePoints(ref NativeArray<Vector3> linePoints, out int numPoints, Ray? rayOriginOverride = null)
		{
			numPoints = default(int);
			return false;
		}

		public bool GetLinePoints(ref Vector3[] linePoints, out int numPoints)
		{
			numPoints = default(int);
			return false;
		}

		public void GetLineOriginAndDirection(out Vector3 origin, out Vector3 direction)
		{
			origin = default(Vector3);
			direction = default(Vector3);
		}

		private void GetLineOriginAndDirection(Ray? rayOriginOverride, out Vector3 origin, out Vector3 direction)
		{
			origin = default(Vector3);
			direction = default(Vector3);
		}

		private static void GetLineOriginAndDirection(Transform rayOrigin, out Vector3 origin, out Vector3 direction)
		{
			origin = default(Vector3);
			direction = default(Vector3);
		}

		private static void EnsureCapacity(ref NativeArray<Vector3> linePoints, int numPoints)
		{
		}

		public bool TryGetHitInfo(out Vector3 position, out Vector3 normal, out int positionInLine, out bool isValidTarget)
		{
			position = default(Vector3);
			normal = default(Vector3);
			positionInLine = default(int);
			isValidTarget = default(bool);
			return false;
		}

		public virtual void UpdateUIModel(ref TrackedDeviceModel model)
		{
		}

		public bool TryGetUIModel(out TrackedDeviceModel model)
		{
			model = default(TrackedDeviceModel);
			return false;
		}

		public bool TryGetCurrent3DRaycastHit(out RaycastHit raycastHit)
		{
			raycastHit = default(RaycastHit);
			return false;
		}

		public bool TryGetCurrent3DRaycastHit(out RaycastHit raycastHit, out int raycastEndpointIndex)
		{
			raycastHit = default(RaycastHit);
			raycastEndpointIndex = default(int);
			return false;
		}

		public bool TryGetCurrentUIRaycastResult(out RaycastResult raycastResult)
		{
			raycastResult = default(RaycastResult);
			return false;
		}

		public bool TryGetCurrentUIRaycastResult(out RaycastResult raycastResult, out int raycastEndpointIndex)
		{
			raycastResult = default(RaycastResult);
			raycastEndpointIndex = default(int);
			return false;
		}

		public bool TryGetCurrentRaycast(out RaycastHit? raycastHit, out int raycastHitIndex, out RaycastResult? uiRaycastHit, out int uiRaycastHitIndex, out bool isUIHitClosest)
		{
			raycastHit = null;
			raycastHitIndex = default(int);
			uiRaycastHit = null;
			uiRaycastHitIndex = default(int);
			isUIHitClosest = default(bool);
			return false;
		}

		private void CacheRaycastHit()
		{
		}

		private void UpdateUIHover()
		{
		}

		private void UpdateBezierControlPoints(in float3 lineOrigin, in float3 lineDirection, in float3 curveReferenceUp)
		{
		}

		private float GetProjectileAngle(Vector3 lineDirection)
		{
			return 0f;
		}

		[BurstCompile]
		private void CalculateProjectileParameters(in float3 lineOrigin, in float3 lineDirection, out float3 initialVelocity, out float3 constantAcceleration, out float flightTime)
		{
			initialVelocity = default(float3);
			constantAcceleration = default(float3);
			flightTime = default(float);
		}

		protected virtual void RotateAttachTransform(Transform attach, float directionAmount)
		{
		}

		protected virtual void RotateAttachTransform(Transform attach, Vector2 direction, Quaternion referenceRotation)
		{
		}

		protected virtual void TranslateAttachTransform(Transform rayOrigin, Transform attach, float directionAmount)
		{
		}

		public override void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public override void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		private void ProcessManipulationInput()
		{
		}

		public override void GetValidTargets(List<IXRInteractable> targets)
		{
		}

		private void CreateSamplePointsListsIfNecessary()
		{
		}

		private void UpdateSamplePointsIfNecessary()
		{
		}

		private void UpdateSamplePoints(int count, List<SamplePoint> samplePoints, Ray? rayOriginOverride = null)
		{
		}

		private void UpdateRaycastHits()
		{
		}

		private void CheckCollidersBetweenPoints(Vector3 from, Vector3 to, Vector3 origin)
		{
		}

		private int FilteredConecast(in Vector3 from, float coneCastAngleDegrees, in Vector3 direction, in Vector3 origin, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		private static int FilterTriggerColliders(XRInteractionManager interactionManager, RaycastHit[] raycastHits, int count, Func<XRInteractableSnapVolume, bool> removeRule)
		{
			return 0;
		}

		private static void RemoveAt<T>(T[] array, int index, int count) where T : struct
		{
		}

		private void CreateBezierCurve(List<SamplePoint> samplePoints, int endSamplePointIndex, float3[] quadraticControlPoints, Ray? rayOriginOverride = null)
		{
		}

		public override bool CanHover(IXRHoverInteractable interactable)
		{
			return false;
		}

		public override bool CanSelect(IXRSelectInteractable interactable)
		{
			return false;
		}

		protected virtual float GetHoverTimeToSelect(IXRInteractable interactable)
		{
			return 0f;
		}

		protected virtual float GetTimeToAutoDeselect(IXRInteractable interactable)
		{
			return 0f;
		}

		protected override void OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectExiting(SelectExitEventArgs args)
		{
		}

		void IUIHoverInteractor.OnUIHoverEntered(UIHoverEventArgs args)
		{
		}

		void IUIHoverInteractor.OnUIHoverExited(UIHoverEventArgs args)
		{
		}

		protected virtual void OnUIHoverEntered(UIHoverEventArgs args)
		{
		}

		protected virtual void OnUIHoverExited(UIHoverEventArgs args)
		{
		}

		private void RestoreAttachTransform()
		{
		}

		private static int SanitizeSampleFrequency(int value)
		{
			return 0;
		}

		[Obsolete("GetLinePoints with ref int parameter has been deprecated. Use signature with out int parameter instead.", true)]
		public bool GetLinePoints(ref Vector3[] linePoints, ref int numPoints, int _ = 0)
		{
			return false;
		}

		[Obsolete("TryGetHitInfo with ref parameters has been deprecated. Use signature with out parameters instead.", true)]
		public bool TryGetHitInfo(ref Vector3 position, ref Vector3 normal, ref int positionInLine, ref bool isValidTarget, int _ = 0)
		{
			return false;
		}

		[Obsolete("GetCurrentRaycastHit has been deprecated. Use TryGetCurrent3DRaycastHit instead. (UnityUpgradable) -> TryGetCurrent3DRaycastHit(*)", true)]
		public bool GetCurrentRaycastHit(out RaycastHit raycastHit)
		{
			raycastHit = default(RaycastHit);
			return false;
		}

		[Obsolete("ProcessManipulationInputDeviceBasedController has been deprecated in version 3.0.0.")]
		private void ProcessManipulationInputDeviceBasedController()
		{
		}

		[Obsolete("ProcessManipulationInputActionBasedController has been deprecated in version 3.0.0.")]
		private void ProcessManipulationInputActionBasedController()
		{
		}

		[Obsolete("ProcessManipulationInputScreenSpaceController has been deprecated in version 3.0.0.")]
		private void ProcessManipulationInputScreenSpaceController()
		{
		}

		[Obsolete("RotateAnchor has been renamed in version 3.0.0. Use RotateAttachTransform instead.")]
		protected virtual void RotateAnchor(Transform anchor, float directionAmount)
		{
		}

		[Obsolete("RotateAnchor has been renamed in version 3.0.0. Use RotateAttachTransform instead.")]
		protected virtual void RotateAnchor(Transform anchor, Vector2 direction, Quaternion referenceRotation)
		{
		}

		[Obsolete("TranslateAnchor has been renamed in version 3.0.0. Use TranslateAttachTransform instead.")]
		protected virtual void TranslateAnchor(Transform rayOrigin, Transform anchor, float directionAmount)
		{
		}

		[Obsolete("TryRead2DAxis has been deprecated in version 3.0.0.")]
		private static bool TryRead2DAxis(InputAction action, out Vector2 output)
		{
			output = default(Vector2);
			return false;
		}

		[Obsolete("TryReadButton has been deprecated in version 3.0.0.")]
		private static bool TryReadButton(InputAction action)
		{
			return false;
		}

		private protected override void OnXRControllerChanged()
		{
		}
	}
}
