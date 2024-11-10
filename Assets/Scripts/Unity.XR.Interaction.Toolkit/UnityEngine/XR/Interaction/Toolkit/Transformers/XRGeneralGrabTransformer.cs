using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Transformers
{
	[AddComponentMenu("XR/Transformers/XR General Grab Transformer", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.html")]
	[BurstCompile]
	public class XRGeneralGrabTransformer : XRBaseGrabTransformer
	{
		[Flags]
		public enum ManipulationAxes
		{
			X = 1,
			Y = 2,
			Z = 4,
			All = 7
		}

		public enum ConstrainedAxisDisplacementMode
		{
			ObjectRelative = 0,
			ObjectRelativeWithLockedWorldUp = 1,
			WorldAxisRelative = 2
		}

		public enum TwoHandedRotationMode
		{
			FirstHandOnly = 0,
			FirstHandDirectedTowardsSecondHand = 1,
			TwoHandedAverage = 2
		}

		public delegate void ComputeNewObjectPosition_00000828_0024PostfixBurstDelegate(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition);

		internal static class ComputeNewObjectPosition_00000828_0024BurstDirectCall
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

			public static void Invoke(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition)
			{
				newPosition = default(Vector3);
			}
		}

		public delegate void AdjustPositionForPermittedAxesBurst_0000082C_0024PostfixBurstDelegate(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition);

		internal static class AdjustPositionForPermittedAxesBurst_0000082C_0024BurstDirectCall
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

			public static void Invoke(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition)
			{
				adjustedTargetPosition = default(Vector3);
			}
		}

		public delegate void ComputeNewOneHandedScale_0000082E_0024PostfixBurstDelegate(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleInput, float deltaTime, float scaleSpeed, out Vector3 newScale);

		internal static class ComputeNewOneHandedScale_0000082E_0024BurstDirectCall
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

			public static void Invoke(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleInput, float deltaTime, float scaleSpeed, out Vector3 newScale)
			{
				newScale = default(Vector3);
			}
		}

		public delegate void ComputeNewTwoHandedScale_0000082F_0024PostfixBurstDelegate(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale);

		internal static class ComputeNewTwoHandedScale_0000082F_0024BurstDirectCall
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

			public static void Invoke(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale)
			{
				newScale = default(Vector3);
			}
		}

		[Header("Translation Constraints")]
		[SerializeField]
		[Tooltip("Permitted axes for translation displacement relative to the object's initial rotation.")]
		private ManipulationAxes m_PermittedDisplacementAxes;

		[SerializeField]
		[Tooltip("Determines how the constrained axis displacement mode is computed.")]
		private ConstrainedAxisDisplacementMode m_ConstrainedAxisDisplacementMode;

		[Header("Rotation Constraints")]
		[SerializeField]
		[Tooltip("Determines how rotation is calculated when using two hands for the grab interaction.")]
		private TwoHandedRotationMode m_TwoHandedRotationMode;

		[Header("Scaling Constraints")]
		[SerializeField]
		[Tooltip("Allow one handed scaling using the scale value provider if available.")]
		private bool m_AllowOneHandedScaling;

		[SerializeField]
		[Tooltip("Allow scaling when using multi-grab interaction.")]
		private bool m_AllowTwoHandedScaling;

		[SerializeField]
		[Tooltip("Scaling speed over time for one handed scaling based on the scale value provider.")]
		[Range(0f, 32f)]
		private float m_OneHandedScaleSpeed;

		[SerializeField]
		[Tooltip("(Two Handed Scaling) Percentage as a measure of 0 to 1 of scaled relative hand displacement required to trigger scale operation.\nIf this value is 0f, scaling happens the moment both grab interactors move closer or further away from each other.\nOtherwise, this percentage is used as a threshold before any scaling happens.")]
		[Range(0f, 1f)]
		private float m_ThresholdMoveRatioForScale;

		[Space]
		[SerializeField]
		[Tooltip("If enabled, scaling will abide by ratio ranges defined below.")]
		private bool m_ClampScaling;

		[SerializeField]
		[Tooltip("Minimum scale multiplier applied to the initial scale captured on start.")]
		[Range(0.01f, 1f)]
		private float m_MinimumScaleRatio;

		[SerializeField]
		[Tooltip("Maximum scale multiplier applied to the initial scale captured on start.")]
		[Range(1f, 10f)]
		private float m_MaximumScaleRatio;

		[Space]
		[SerializeField]
		[Range(0.1f, 5f)]
		[Tooltip("Scales the distance of displacement between interactors needed to modify the scale interactable.")]
		private float m_ScaleMultiplier;

		private Pose m_OriginalObjectPose;

		private Pose m_OffsetPose;

		private Pose m_OriginalInteractorPose;

		private Vector3 m_InteractorLocalGrabPoint;

		private Vector3 m_ObjectLocalGrabPoint;

		private IXRInteractor m_OriginalInteractor;

		private int m_LastGrabCount;

		private Vector3 m_StartHandleBar;

		private Vector3 m_StartHandleBarNormalized;

		private Quaternion m_StartHandleBarLookRotation;

		private Quaternion m_InverseStartHandleBarLookRotation;

		private Quaternion m_LastHandleBarLocalRotation;

		private Vector3 m_ScaleAtGrabStart;

		private bool m_FirstFrameSinceTwoHandedGrab;

		private Vector3 m_LastTwoHandedUp;

		private Vector3 m_InitialScale;

		private Vector3 m_InitialScaleProportions;

		private Vector3 m_MinimumScale;

		private Vector3 m_MaximumScale;

		private ConstrainedAxisDisplacementMode m_ConstrainedAxisDisplacementModeOnGrab;

		private ManipulationAxes m_PermittedDisplacementAxesOnGrab;

		private IXRScaleValueProvider m_ScaleValueProvider;

		private bool m_HasScaleValueProvider;

		public ManipulationAxes permittedDisplacementAxes
		{
			get
			{
				return default(ManipulationAxes);
			}
			set
			{
			}
		}

		public ConstrainedAxisDisplacementMode constrainedAxisDisplacementMode
		{
			get
			{
				return default(ConstrainedAxisDisplacementMode);
			}
			set
			{
			}
		}

		public TwoHandedRotationMode allowTwoHandedRotation
		{
			get
			{
				return default(TwoHandedRotationMode);
			}
			set
			{
			}
		}

		public bool allowOneHandedScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowTwoHandedScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float oneHandedScaleSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float thresholdMoveRatioForScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool clampScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float minimumScaleRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maximumScaleRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scaleMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override RegistrationMode registrationMode => default(RegistrationMode);

		protected void Awake()
		{
		}

		public override void Process(XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale)
		{
		}

		public override void OnGrab(XRGrabInteractable grabInteractable)
		{
		}

		public override void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale)
		{
		}

		private void ComputeAdjustedInteractorPose(XRGrabInteractable grabInteractable, out Vector3 newHandleBar, out Vector3 adjustedInteractorPosition, out Quaternion adjustedInteractorRotation)
		{
			newHandleBar = default(Vector3);
			adjustedInteractorPosition = default(Vector3);
			adjustedInteractorRotation = default(Quaternion);
		}

		private void TranslateSetup(Pose interactorCentroidPose, Vector3 grabCentroid, Pose objectPose, Vector3 objectScale)
		{
		}

		[BurstCompile]
		private static void ComputeNewObjectPosition(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition)
		{
			newPosition = default(Vector3);
		}

		private static float3 Scale(float3 a, float3 b)
		{
			return default(float3);
		}

		private Quaternion ComputeNewObjectRotation(in Quaternion interactorRotation, bool trackRotation)
		{
			return default(Quaternion);
		}

		private static Vector3 AdjustPositionForPermittedAxes(in Vector3 targetPosition, in Pose originalObjectPose, ManipulationAxes permittedAxes, ConstrainedAxisDisplacementMode axisDisplacementMode)
		{
			return default(Vector3);
		}

		[BurstCompile]
		private static void AdjustPositionForPermittedAxesBurst(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition)
		{
			adjustedTargetPosition = default(Vector3);
		}

		private Vector3 ComputeNewScale(in XRGrabInteractable grabInteractable, in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool trackScale)
		{
			return default(Vector3);
		}

		[BurstCompile]
		private static void ComputeNewOneHandedScale(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleInput, float deltaTime, float scaleSpeed, out Vector3 newScale)
		{
			newScale = default(Vector3);
		}

		[BurstCompile]
		private static void ComputeNewTwoHandedScale(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale)
		{
			newScale = default(Vector3);
		}

		private void UpdateTarget(XRGrabInteractable grabInteractable, ref Pose targetPose, ref Vector3 localScale)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ComputeNewObjectPosition_0024BurstManaged(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition)
		{
			newPosition = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void AdjustPositionForPermittedAxesBurst_0024BurstManaged(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition)
		{
			adjustedTargetPosition = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ComputeNewOneHandedScale_0024BurstManaged(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleInput, float deltaTime, float scaleSpeed, out Vector3 newScale)
		{
			newScale = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ComputeNewTwoHandedScale_0024BurstManaged(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale)
		{
			newScale = default(Vector3);
		}
	}
}
