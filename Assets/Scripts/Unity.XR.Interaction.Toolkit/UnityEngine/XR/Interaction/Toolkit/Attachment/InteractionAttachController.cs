using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using Unity.XR.CoreUtils;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Attachment
{
	[BurstCompile]
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Interactors/Interaction Attach Controller", 22)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController.html")]
	public class InteractionAttachController : MonoBehaviour, IInteractionAttachController
	{
		public delegate void ComputeAmplifiedOffset_00001015_0024PostfixBurstDelegate(in float3 velocityLocal, in float3 normStartLocalOffset, float startOffsetLength, in float3 normTargetLocalOffset, in float3 currentLocalOffset, float minAdditionalVelocityScalar, float maxAdditionalVelocityScalar, float pushVelocityBias, float pullVelocityBias, float zVelocityRampThreshold, bool useMomentum, float momentumDecayScale, ref float momentum, ref float pivot, float deltaTime, out float3 newOffset);

		internal static class ComputeAmplifiedOffset_00001015_0024BurstDirectCall
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

			public static void Invoke(in float3 velocityLocal, in float3 normStartLocalOffset, float startOffsetLength, in float3 normTargetLocalOffset, in float3 currentLocalOffset, float minAdditionalVelocityScalar, float maxAdditionalVelocityScalar, float pushVelocityBias, float pullVelocityBias, float zVelocityRampThreshold, bool useMomentum, float momentumDecayScale, ref float momentum, ref float pivot, float deltaTime, out float3 newOffset)
			{
				newOffset = default(float3);
			}
		}

		[SerializeField]
		[Tooltip("The transform that this anchor should follow.")]
		private Transform m_TransformToFollow;

		[Header("Stabilization Parameters")]
		[SerializeField]
		[Tooltip("The stabilization mode for the motion of the anchor. Determines how the anchor's position and rotation are stabilized relative to the followed transform.")]
		private MotionStabilizationMode m_MotionStabilizationMode;

		[SerializeField]
		[Tooltip("Factor for stabilizing position. Larger values increase the range of stabilization, making the effect more pronounced over a greater distance.")]
		private float m_PositionStabilization;

		[SerializeField]
		[Tooltip("Factor for stabilizing angle. Larger values increase the range of stabilization, making the effect more pronounced over a greater angle.")]
		private float m_AngleStabilization;

		[Header("Smoothing Settings")]
		[SerializeField]
		[Tooltip("If true offset will be smoothed over time in XR Origin space.")]
		private bool m_SmoothOffset;

		[SerializeField]
		[Tooltip("Smoothing speed for the offset anchor child.")]
		[Range(1f, 30f)]
		private float m_SmoothingSpeed;

		[Header("Anchor Movement Parameters")]
		[SerializeField]
		[Tooltip("Whether to use distance-based velocity scaling for anchor movement.")]
		private bool m_UseDistanceBasedVelocityScaling;

		[Space]
		[SerializeField]
		[Tooltip("Whether momentum is used when distance scaling is in effect.")]
		private bool m_UseMomentum;

		[SerializeField]
		[Tooltip("Decay scalar for momentum. Higher values will cause momentum to decay faster.")]
		[Range(0f, 10f)]
		private float m_MomentumDecayScale;

		[Space]
		[SerializeField]
		[Range(0f, 5f)]
		[Tooltip("Scales anchor velocity from 0 to 1 based on z-velocity's deviation below a threshold. 0 means no scaling.")]
		private float m_ZVelocityRampThreshold;

		[SerializeField]
		[Tooltip("Adjusts the object's velocity calculation when moving towards the user. It modifies the distance-based calculation that determines the velocity scalar.")]
		[Range(0f, 2f)]
		private float m_PullVelocityBias;

		[SerializeField]
		[Tooltip("Adjusts the object's velocity calculation when moving away from the user. It modifies the distance-based calculation that determines the velocity scalar.")]
		[Range(0f, 2f)]
		private float m_PushVelocityBias;

		[SerializeField]
		[Tooltip("Minimum additional velocity scaling factor for movement, interpolated by a quad bezier curve.")]
		[Range(0f, 2f)]
		private float m_MinAdditionalVelocityScalar;

		[SerializeField]
		[Tooltip("Maximum additional velocity scaling factor for movement, interpolated by a quad bezier curve.")]
		[Range(0f, 5f)]
		private float m_MaxAdditionalVelocityScalar;

		private bool m_FirstMovementFrame;

		private bool m_HasOffset;

		private float m_StartOffsetLength;

		private Vector3 m_StartLocalOffset;

		private Vector3 m_NormStartOffset;

		private Vector3 m_NormTargetLocalOffset;

		private float m_Pivot;

		private float m_Momentum;

		private bool m_WasVelocityScalingBlocked;

		private bool m_HasSelectInteractor;

		private IXRSelectInteractor m_SelectInteractor;

		private bool m_HasXROrigin;

		private XROrigin m_XROrigin;

		private Transform m_AnchorParent;

		private Transform m_AnchorChild;

		private Vector3 m_LastLocalTargetPosition;

		private Vector3 m_LastChildOriginSpacePosition;

		private readonly AttachPointVelocityTracker m_VelocityTracker;

		public Transform transformToFollow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MotionStabilizationMode motionStabilizationMode
		{
			get
			{
				return default(MotionStabilizationMode);
			}
			set
			{
			}
		}

		public float positionStabilization
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angleStabilization
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool smoothOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float smoothingSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useDistanceBasedVelocityScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useMomentum
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float momentumDecayScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float zVelocityRampThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pullVelocityBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pushVelocityBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float minAdditionalVelocityScalar
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxAdditionalVelocityScalar
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hasOffset => false;

		public event Action attachUpdated
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

		private Transform GetXROriginTransform()
		{
			return null;
		}

		private bool InitializeXROrigin()
		{
			return false;
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void SyncAnchor()
		{
		}

		Transform IInteractionAttachController.GetOrCreateAnchorTransform(bool updateTransform)
		{
			return null;
		}

		void IInteractionAttachController.MoveTo(Vector3 targetWorldPosition)
		{
		}

		private void SyncOffset()
		{
		}

		private void MoveToPositionWorldPosition(Vector3 targetWorldPosition)
		{
		}

		void IInteractionAttachController.ApplyLocalPositionOffset(Vector3 offset)
		{
		}

		void IInteractionAttachController.ApplyLocalRotationOffset(Quaternion localRotation)
		{
		}

		public void ResetOffset()
		{
		}

		void IInteractionAttachController.DoUpdate(float deltaTime)
		{
		}

		private bool UpdateVelocityScalingBlock()
		{
			return false;
		}

		private void UpdatePosition(Vector3 lastOriginSpacePosition, Vector3 targetLocalPosition, float deltaTime)
		{
		}

		[BurstCompile]
		private static void ComputeAmplifiedOffset(in float3 velocityLocal, in float3 normStartLocalOffset, float startOffsetLength, in float3 normTargetLocalOffset, in float3 currentLocalOffset, float minAdditionalVelocityScalar, float maxAdditionalVelocityScalar, float pushVelocityBias, float pullVelocityBias, float zVelocityRampThreshold, bool useMomentum, float momentumDecayScale, ref float momentum, ref float pivot, float deltaTime, out float3 newOffset)
		{
			newOffset = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void ComputeAmplifiedOffset_0024BurstManaged(in float3 velocityLocal, in float3 normStartLocalOffset, float startOffsetLength, in float3 normTargetLocalOffset, in float3 currentLocalOffset, float minAdditionalVelocityScalar, float maxAdditionalVelocityScalar, float pushVelocityBias, float pullVelocityBias, float zVelocityRampThreshold, bool useMomentum, float momentumDecayScale, ref float momentum, ref float pivot, float deltaTime, out float3 newOffset)
		{
			newOffset = default(float3);
		}
	}
}
