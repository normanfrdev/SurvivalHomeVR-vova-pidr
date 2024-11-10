using System.Collections.Generic;
using Unity.Collections;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit.Attachment;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Casters;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;
using UnityEngine.XR.Interaction.Toolkit.UI;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Interactors/Near-Far Interactor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor.html")]
	public class NearFarInteractor : XRBaseInputInteractor, IXRRayProvider, IUIHoverInteractor, IUIInteractor, ICurveInteractionDataProvider
	{
		public enum Region
		{
			None = 0,
			Near = 1,
			Far = 2
		}

		public enum NearCasterSortingStrategy
		{
			None = 0,
			SquareDistance = 1,
			InteractableBased = 2,
			ClosestPointOnCollider = 3
		}

		[SerializeField]
		[RequireInterface(typeof(IInteractionAttachController))]
		private Object m_InteractionAttachController;

		private readonly UnityObjectReferenceCache<IInteractionAttachController, Object> m_InteractionAttachControllerObjectRef;

		[SerializeField]
		private bool m_EnableNearCasting;

		[SerializeField]
		[RequireInterface(typeof(IInteractionCaster))]
		private Object m_NearInteractionCaster;

		private readonly UnityObjectReferenceCache<IInteractionCaster, Object> m_NearCasterObjectRef;

		[SerializeField]
		private NearCasterSortingStrategy m_NearCasterSortingStrategy;

		[SerializeField]
		private bool m_SortNearTargetsAfterTargetFilter;

		[Space]
		[SerializeField]
		private bool m_EnableFarCasting;

		[SerializeField]
		[RequireInterface(typeof(ICurveInteractionCaster))]
		private Object m_FarInteractionCaster;

		private readonly UnityObjectReferenceCache<ICurveInteractionCaster, Object> m_FarCasterObjectRef;

		[SerializeField]
		private InteractorFarAttachMode m_FarAttachMode;

		[SerializeField]
		private bool m_EnableUIInteraction;

		[SerializeField]
		private bool m_BlockUIOnInteractableSelection;

		[SerializeField]
		private UIHoverEnterEvent m_UIHoverEntered;

		[SerializeField]
		private UIHoverExitEvent m_UIHoverExited;

		[SerializeField]
		private XRInputButtonReader m_UIPressInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_UIScrollInput;

		private readonly BindableEnum<Region> m_SelectionRegion;

		private Region m_ValidTargetCastSource;

		private Region m_SelectedTargetCastSource;

		private readonly List<Collider> m_TargetColliders;

		private readonly List<RaycastHit> m_FarRayCastHits;

		private readonly List<IXRInteractable> m_InternalValidTargets;

		private readonly List<XRInteractableSnapVolume> m_InteractableSnapVolumes;

		private readonly List<IXRInteractable> m_PreFilteredTargets;

		private readonly Dictionary<IXRInteractable, int> m_FarTargetToIndexMap;

		private bool m_ReleasedNearInteractionThisFrame;

		private RegisteredUIInteractorCache m_RegisteredUIInteractorCache;

		private readonly UnityObjectReferenceCache<IUIModelUpdater, Object> m_UIModelUpdaterReferenceCache;

		private bool m_HasValidRayHit;

		private Vector3 m_RayEndPoint;

		private bool m_ValidHitIsUI;

		private Vector3 m_ValidHitNormal;

		private Vector3 m_NormalRelativeToInteractable;

		private Transform m_RayEndTransform;

		private readonly bool m_AllowMultipleValidTargets;

		public IInteractionAttachController interactionAttachController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enableNearCasting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IInteractionCaster nearInteractionCaster
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NearCasterSortingStrategy nearCasterSortingStrategy
		{
			get
			{
				return default(NearCasterSortingStrategy);
			}
			set
			{
			}
		}

		public bool sortNearTargetsAfterTargetFilter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableFarCasting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ICurveInteractionCaster farInteractionCaster
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InteractorFarAttachMode farAttachMode
		{
			get
			{
				return default(InteractorFarAttachMode);
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

		Transform IXRRayProvider.rayEndTransform => null;

		Vector3 IXRRayProvider.rayEndPoint => default(Vector3);

		public IReadOnlyBindableVariable<Region> selectionRegion => null;

		private IUIModelUpdater uiModelUpdater => null;

		private bool isUiSelectInputActive => false;

		private Vector2 uiScrollInputValue => default(Vector2);

		bool ICurveInteractionDataProvider.isActive => false;

		bool ICurveInteractionDataProvider.hasValidSelect => false;

		NativeArray<Vector3> ICurveInteractionDataProvider.samplePoints => default(NativeArray<Vector3>);

		Vector3 ICurveInteractionDataProvider.lastSamplePoint => default(Vector3);

		public Transform curveOrigin => null;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void InitializeReferences()
		{
		}

		public override void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		private void InitializeInteractor()
		{
		}

		private void UpdateAnchor()
		{
		}

		private Region DetermineSelectionRegion()
		{
			return default(Region);
		}

		private void UpdateSelectionRegion(Region newSelectionRegion)
		{
		}

		private void EvaluateNearInteraction()
		{
		}

		private void EvaluateFarInteraction(Region newSelectionRegion)
		{
		}

		private void Process3dHit(in Vector3 farCasterOrigin, bool has2dHit, float uiHitSqDistance, ref bool shouldProcess2dHit)
		{
		}

		private void Process2dHit(in RaycastResult uiHit)
		{
		}

		protected virtual IInteractorDistanceEvaluator GetEvaluatorForSortingStrategy(NearCasterSortingStrategy strategy)
		{
			return null;
		}

		private int RegisterNearValidTargets(List<Collider> targets, List<IXRInteractable> interactables)
		{
			return 0;
		}

		private int RegisterFarValidTargets(List<Collider> targets, List<IXRInteractable> interactables, List<XRInteractableSnapVolume> snapVolumes, out int firstRegisteredIndex)
		{
			firstRegisteredIndex = default(int);
			return 0;
		}

		public override void GetValidTargets(List<IXRInteractable> targets)
		{
		}

		protected override void OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectExiting(SelectExitEventArgs args)
		{
		}

		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		Transform IXRRayProvider.GetOrCreateAttachTransform()
		{
			return null;
		}

		void IXRRayProvider.SetAttachTransform(Transform newAttach)
		{
		}

		Transform IXRRayProvider.GetOrCreateRayOrigin()
		{
			return null;
		}

		void IXRRayProvider.SetRayOrigin(Transform newOrigin)
		{
		}

		public void UpdateUIModel(ref TrackedDeviceModel model)
		{
		}

		public bool TryGetUIModel(out TrackedDeviceModel model)
		{
			model = default(TrackedDeviceModel);
			return false;
		}

		public bool TryGetCurrentUIRaycastResult(out RaycastResult raycastResult)
		{
			raycastResult = default(RaycastResult);
			return false;
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

		public EndPointType TryGetCurveEndPoint(out Vector3 endPoint, bool snapToSelectedAttachIfAvailable = false, bool snapToSnapVolumeIfAvailable = false)
		{
			endPoint = default(Vector3);
			return default(EndPointType);
		}

		public EndPointType TryGetCurveEndNormal(out Vector3 endNormal, bool snapToSelectedAttachIfAvailable = false)
		{
			endNormal = default(Vector3);
			return default(EndPointType);
		}
	}
}
