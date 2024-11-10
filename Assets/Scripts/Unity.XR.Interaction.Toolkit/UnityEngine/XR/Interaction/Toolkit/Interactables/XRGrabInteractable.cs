using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Profiling;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Attachment;
using UnityEngine.XR.Interaction.Toolkit.Gaze;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.Interactables
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[SelectionBase]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Rigidbody))]
	[AddComponentMenu("XR/XR Grab Interactable", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable.html")]
	[BurstCompile]
	public class XRGrabInteractable : XRBaseInteractable, IFarAttachProvider
	{
		[Obsolete("AttachPointCompatibilityMode has been deprecated and will be removed in a future version of XRI.", true)]
		public enum AttachPointCompatibilityMode
		{
			[Obsolete("Default has been deprecated and will be removed in a future version of XRI. It is the only mode now.", true)]
			Default = 0,
			[Obsolete("Legacy has been deprecated and will be removed in a future version of XRI.", true)]
			Legacy = 1
		}

		public delegate void EaseAttachBurst_00000E80_0024PostfixBurstDelegate(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime);

		internal static class EaseAttachBurst_00000E80_0024BurstDirectCall
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

			public static void Invoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime)
			{
			}
		}

		public delegate void StepSmoothingBurst_00000E81_0024PostfixBurstDelegate(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale);

		internal static class StepSmoothingBurst_00000E81_0024BurstDirectCall
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

			public static void Invoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale)
			{
			}
		}

		private const float k_DefaultTighteningAmount = 0.1f;

		private const float k_DefaultSmoothingAmount = 8f;

		private const float k_LinearVelocityDamping = 1f;

		private const float k_LinearVelocityScale = 1f;

		private const float k_AngularVelocityDamping = 1f;

		private const float k_AngularVelocityScale = 1f;

		private const int k_ThrowSmoothingFrameCount = 20;

		private const float k_DefaultAttachEaseInTime = 0.15f;

		private const float k_DefaultThrowSmoothingDuration = 0.25f;

		private const float k_DefaultThrowLinearVelocityScale = 1.5f;

		private const float k_DefaultThrowAngularVelocityScale = 1f;

		private const float k_DeltaTimeThreshold = 0.001f;

		[SerializeField]
		private Transform m_AttachTransform;

		[SerializeField]
		private Transform m_SecondaryAttachTransform;

		[SerializeField]
		private bool m_UseDynamicAttach;

		[SerializeField]
		private bool m_MatchAttachPosition;

		[SerializeField]
		private bool m_MatchAttachRotation;

		[SerializeField]
		private bool m_SnapToColliderVolume;

		[SerializeField]
		private bool m_ReinitializeDynamicAttachEverySingleGrab;

		[SerializeField]
		private float m_AttachEaseInTime;

		[SerializeField]
		private MovementType m_MovementType;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_VelocityDamping;

		[SerializeField]
		private float m_VelocityScale;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_AngularVelocityDamping;

		[SerializeField]
		private float m_AngularVelocityScale;

		[SerializeField]
		private bool m_TrackPosition;

		[SerializeField]
		private bool m_SmoothPosition;

		[SerializeField]
		[Range(0f, 20f)]
		private float m_SmoothPositionAmount;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_TightenPosition;

		[SerializeField]
		private bool m_TrackRotation;

		[SerializeField]
		private bool m_SmoothRotation;

		[SerializeField]
		[Range(0f, 20f)]
		private float m_SmoothRotationAmount;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_TightenRotation;

		[SerializeField]
		private bool m_TrackScale;

		[SerializeField]
		private bool m_SmoothScale;

		[SerializeField]
		[Range(0f, 20f)]
		private float m_SmoothScaleAmount;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_TightenScale;

		[SerializeField]
		private bool m_ThrowOnDetach;

		[SerializeField]
		private float m_ThrowSmoothingDuration;

		[SerializeField]
		private AnimationCurve m_ThrowSmoothingCurve;

		[SerializeField]
		private float m_ThrowVelocityScale;

		[SerializeField]
		private float m_ThrowAngularVelocityScale;

		[SerializeField]
		[FormerlySerializedAs("m_GravityOnDetach")]
		private bool m_ForceGravityOnDetach;

		[SerializeField]
		private bool m_RetainTransformParent;

		[SerializeField]
		private List<XRBaseGrabTransformer> m_StartingSingleGrabTransformers;

		[SerializeField]
		private List<XRBaseGrabTransformer> m_StartingMultipleGrabTransformers;

		[SerializeField]
		private bool m_AddDefaultGrabTransformers;

		[SerializeField]
		private InteractableFarAttachMode m_FarAttachMode;

		private readonly SmallRegistrationList<IXRGrabTransformer> m_SingleGrabTransformers;

		private readonly SmallRegistrationList<IXRGrabTransformer> m_MultipleGrabTransformers;

		private List<IXRGrabTransformer> m_GrabTransformersAddedWhenGrabbed;

		private bool m_GrabCountChanged;

		private (int, int) m_GrabCountBeforeAndAfterChange;

		private bool m_IsProcessingGrabTransformers;

		private int m_DropTransformersCount;

		private static readonly LinkedPool<DropEventArgs> s_DropEventArgs;

		private Pose m_TargetPose;

		private Vector3 m_TargetLocalScale;

		private bool m_IsTargetPoseDirty;

		private bool m_IsTargetLocalScaleDirty;

		private float m_CurrentAttachEaseTime;

		private MovementType m_CurrentMovementType;

		private bool m_DetachInLateUpdate;

		private Vector3 m_DetachLinearVelocity;

		private Vector3 m_DetachAngularVelocity;

		private int m_ThrowSmoothingCurrentFrame;

		private readonly float[] m_ThrowSmoothingFrameTimes;

		private readonly Vector3[] m_ThrowSmoothingLinearVelocityFrames;

		private readonly Vector3[] m_ThrowSmoothingAngularVelocityFrames;

		private bool m_ThrowSmoothingFirstUpdate;

		private Pose m_LastThrowReferencePose;

		private IXRAimAssist m_ThrowAssist;

		private Rigidbody m_Rigidbody;

		private bool m_WasKinematic;

		private bool m_UsedGravity;

		private float m_OldLinearDamping;

		private float m_OldAngularDamping;

		private bool m_IgnoringCharacterCollision;

		private bool m_StopIgnoringCollisionInLateUpdate;

		private CharacterController m_SelectingCharacterController;

		private readonly HashSet<IXRSelectInteractor> m_SelectingCharacterInteractors;

		private readonly List<Collider> m_RigidbodyColliders;

		private readonly HashSet<Collider> m_CollidersThatAllowedCharacterCollision;

		private Transform m_OriginalSceneParent;

		private TeleportationMonitor m_TeleportationMonitor;

		private readonly Dictionary<IXRSelectInteractor, Transform> m_DynamicAttachTransforms;

		private static readonly LinkedPool<Transform> s_DynamicAttachTransformPool;

		private static readonly ProfilerMarker s_ProcessGrabTransformersMarker;

		private const string k_AttachPointCompatibilityModeDeprecated = "attachPointCompatibilityMode has been deprecated and will be removed in a future version of XRI.";

		private const string k_GravityOnDetachDeprecated = "gravityOnDetach has been deprecated. Use forceGravityOnDetach instead. (UnityUpgradable) -> forceGravityOnDetach";

		public Transform attachTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform secondaryAttachTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useDynamicAttach
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool matchAttachPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool matchAttachRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool snapToColliderVolume
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool reinitializeDynamicAttachEverySingleGrab
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float attachEaseInTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MovementType movementType
		{
			get
			{
				return default(MovementType);
			}
			set
			{
			}
		}

		public float velocityDamping
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float velocityScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angularVelocityDamping
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angularVelocityScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool trackPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool smoothPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float smoothPositionAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float tightenPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool trackRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool smoothRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float smoothRotationAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float tightenRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool trackScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool smoothScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float smoothScaleAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float tightenScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool throwOnDetach
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float throwSmoothingDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve throwSmoothingCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float throwVelocityScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float throwAngularVelocityScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool forceGravityOnDetach
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool retainTransformParent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<XRBaseGrabTransformer> startingSingleGrabTransformers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<XRBaseGrabTransformer> startingMultipleGrabTransformers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool addDefaultGrabTransformers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InteractableFarAttachMode farAttachMode
		{
			get
			{
				return default(InteractableFarAttachMode);
			}
			set
			{
			}
		}

		public int singleGrabTransformersCount => 0;

		public int multipleGrabTransformersCount => 0;

		private bool isTransformDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("attachPointCompatibilityMode has been deprecated and will be removed in a future version of XRI.", true)]
		public AttachPointCompatibilityMode attachPointCompatibilityMode
		{
			get
			{
				return default(AttachPointCompatibilityMode);
			}
			set
			{
			}
		}

		[Obsolete("gravityOnDetach has been deprecated. Use forceGravityOnDetach instead. (UnityUpgradable) -> forceGravityOnDetach", true)]
		public bool gravityOnDetach
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public override Transform GetAttachTransform(IXRInteractor interactor)
		{
			return null;
		}

		public void AddSingleGrabTransformer(IXRGrabTransformer transformer)
		{
		}

		public void AddMultipleGrabTransformer(IXRGrabTransformer transformer)
		{
		}

		public bool RemoveSingleGrabTransformer(IXRGrabTransformer transformer)
		{
			return false;
		}

		public bool RemoveMultipleGrabTransformer(IXRGrabTransformer transformer)
		{
			return false;
		}

		public void ClearSingleGrabTransformers()
		{
		}

		public void ClearMultipleGrabTransformers()
		{
		}

		public void GetSingleGrabTransformers(List<IXRGrabTransformer> results)
		{
		}

		public void GetMultipleGrabTransformers(List<IXRGrabTransformer> results)
		{
		}

		public IXRGrabTransformer GetSingleGrabTransformerAt(int index)
		{
			return null;
		}

		public IXRGrabTransformer GetMultipleGrabTransformerAt(int index)
		{
			return null;
		}

		public void MoveSingleGrabTransformerTo(IXRGrabTransformer transformer, int newIndex)
		{
		}

		public void MoveMultipleGrabTransformerTo(IXRGrabTransformer transformer, int newIndex)
		{
		}

		public Pose GetTargetPose()
		{
			return default(Pose);
		}

		public void SetTargetPose(Pose pose)
		{
		}

		public Vector3 GetTargetLocalScale()
		{
			return default(Vector3);
		}

		public void SetTargetLocalScale(Vector3 localScale)
		{
		}

		private void InitializeTargetPoseAndScale(Transform thisTransform)
		{
		}

		private void AddGrabTransformer(IXRGrabTransformer transformer, BaseRegistrationList<IXRGrabTransformer> grabTransformers)
		{
		}

		private bool RemoveGrabTransformer(IXRGrabTransformer transformer, BaseRegistrationList<IXRGrabTransformer> grabTransformers)
		{
			return false;
		}

		private void ClearGrabTransformers(BaseRegistrationList<IXRGrabTransformer> grabTransformers)
		{
		}

		private static void GetGrabTransformers(BaseRegistrationList<IXRGrabTransformer> grabTransformers, List<IXRGrabTransformer> results)
		{
		}

		private void MoveGrabTransformerTo(IXRGrabTransformer transformer, int newIndex, BaseRegistrationList<IXRGrabTransformer> grabTransformers)
		{
		}

		private void FlushRegistration()
		{
		}

		private void InvokeGrabTransformersOnGrab()
		{
		}

		private void InvokeGrabTransformersOnDrop(DropEventArgs args)
		{
		}

		private void InvokeGrabTransformersProcess(XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale)
		{
		}

		private bool CanProcessAnySingleGrabTransformer()
		{
			return false;
		}

		private void OnAddedGrabTransformer(IXRGrabTransformer transformer)
		{
		}

		private void OnRemovedGrabTransformer(IXRGrabTransformer transformer)
		{
		}

		private void AddDefaultGrabTransformers()
		{
		}

		protected virtual void AddDefaultSingleGrabTransformer()
		{
		}

		protected virtual void AddDefaultMultipleGrabTransformer()
		{
		}

		private IXRGrabTransformer GetOrAddDefaultGrabTransformer()
		{
			return null;
		}

		private T GetOrAddComponent<T>() where T : Component
		{
			return null;
		}

		private void UpdateTarget(XRInteractionUpdateOrder.UpdatePhase updatePhase, float deltaTime)
		{
		}

		private void StepSmoothing(in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime)
		{
		}

		[BurstCompile]
		private static void EaseAttachBurst(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime)
		{
		}

		[BurstCompile]
		private static void StepSmoothingBurst(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale)
		{
		}

		private void PerformInstantaneousUpdate(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		private void PerformKinematicUpdate(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		private void PerformVelocityTrackingUpdate(XRInteractionUpdateOrder.UpdatePhase updatePhase, float deltaTime)
		{
		}

		private void ApplyTargetScale()
		{
		}

		private void UpdateCurrentMovementType()
		{
		}

		protected override void OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectExiting(SelectExitEventArgs args)
		{
		}

		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		private Transform CreateDynamicAttachTransform(IXRSelectInteractor interactor)
		{
			return null;
		}

		private void InitializeDynamicAttachPoseInternal(IXRSelectInteractor interactor, Transform dynamicAttachTransform)
		{
		}

		private void InitializeDynamicAttachPoseWithStatic(IXRSelectInteractor interactor, Transform dynamicAttachTransform)
		{
		}

		private void ReleaseDynamicAttachTransform(IXRSelectInteractor interactor)
		{
		}

		protected virtual bool ShouldMatchAttachPosition(IXRSelectInteractor interactor)
		{
			return false;
		}

		protected virtual bool ShouldMatchAttachRotation(IXRSelectInteractor interactor)
		{
			return false;
		}

		protected virtual bool ShouldSnapToColliderVolume(IXRSelectInteractor interactor)
		{
			return false;
		}

		protected virtual void InitializeDynamicAttachPose(IXRSelectInteractor interactor, Transform dynamicAttachTransform)
		{
		}

		protected virtual void Grab()
		{
		}

		protected virtual void Drop()
		{
		}

		protected virtual void Detach()
		{
		}

		protected virtual void SetupRigidbodyGrab(Rigidbody rigidbody)
		{
		}

		protected virtual void SetupRigidbodyDrop(Rigidbody rigidbody)
		{
		}

		private void ResetThrowSmoothing()
		{
		}

		private void EndThrowSmoothing()
		{
		}

		private void StepThrowSmoothing(Pose targetPose, float deltaTime)
		{
		}

		private Vector3 GetSmoothedVelocityValue(Vector3[] velocityFrames)
		{
			return default(Vector3);
		}

		private void SubscribeTeleportationProvider(IXRInteractor interactor)
		{
		}

		private void UnsubscribeTeleportationProvider(IXRInteractor interactor)
		{
		}

		private void OnTeleported(Pose offset)
		{
		}

		private void StartIgnoringCharacterCollision(Collider characterCollider)
		{
		}

		private bool IsOutsideCharacterCollider(Collider characterCollider)
		{
			return false;
		}

		private void StopIgnoringCharacterCollision(Collider characterCollider)
		{
		}

		private static Transform OnCreatePooledItem()
		{
			return null;
		}

		private static void OnGetPooledItem(Transform item)
		{
		}

		private static void OnReleasePooledItem(Transform item)
		{
		}

		private static void OnDestroyPooledItem(Transform item)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void EaseAttachBurst_0024BurstManaged(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void StepSmoothingBurst_0024BurstManaged(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale)
		{
		}
	}
}
