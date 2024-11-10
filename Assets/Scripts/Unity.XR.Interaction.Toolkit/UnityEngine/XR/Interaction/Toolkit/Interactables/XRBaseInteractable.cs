using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using Unity.XR.CoreUtils.Bindings.Variables;
using Unity.XR.CoreUtils.Collections;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Gaze;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Interactables
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[SelectionBase]
	[DefaultExecutionOrder(-98)]
	public abstract class XRBaseInteractable : MonoBehaviour, IXRActivateInteractable, IXRInteractable, IXRHoverInteractable, IXRSelectInteractable, IXRFocusInteractable, IXRInteractionStrengthInteractable, IXROverridesGazeAutoSelect
	{
		public enum MovementType
		{
			VelocityTracking = 0,
			Kinematic = 1,
			Instantaneous = 2
		}

		public enum DistanceCalculationMode
		{
			TransformPosition = 0,
			ColliderPosition = 1,
			ColliderVolume = 2
		}

		private const float k_InteractionStrengthHover = 0f;

		private const float k_InteractionStrengthSelect = 1f;

		[SerializeField]
		private XRInteractionManager m_InteractionManager;

		[SerializeField]
		private List<Collider> m_Colliders;

		[SerializeField]
		private InteractionLayerMask m_InteractionLayers;

		[SerializeField]
		private DistanceCalculationMode m_DistanceCalculationMode;

		[SerializeField]
		private InteractableSelectMode m_SelectMode;

		[SerializeField]
		private InteractableFocusMode m_FocusMode;

		[SerializeField]
		private GameObject m_CustomReticle;

		[SerializeField]
		private bool m_AllowGazeInteraction;

		[SerializeField]
		private bool m_AllowGazeSelect;

		[SerializeField]
		private bool m_OverrideGazeTimeToSelect;

		[SerializeField]
		private float m_GazeTimeToSelect;

		[SerializeField]
		private bool m_OverrideTimeToAutoDeselectGaze;

		[SerializeField]
		private float m_TimeToAutoDeselectGaze;

		[SerializeField]
		private bool m_AllowGazeAssistance;

		[SerializeField]
		private HoverEnterEvent m_FirstHoverEntered;

		[SerializeField]
		private HoverExitEvent m_LastHoverExited;

		[SerializeField]
		private HoverEnterEvent m_HoverEntered;

		[SerializeField]
		private HoverExitEvent m_HoverExited;

		[SerializeField]
		private SelectEnterEvent m_FirstSelectEntered;

		[SerializeField]
		private SelectExitEvent m_LastSelectExited;

		[SerializeField]
		private SelectEnterEvent m_SelectEntered;

		[SerializeField]
		private SelectExitEvent m_SelectExited;

		[SerializeField]
		private FocusEnterEvent m_FirstFocusEntered;

		[SerializeField]
		private FocusExitEvent m_LastFocusExited;

		[SerializeField]
		private FocusEnterEvent m_FocusEntered;

		[SerializeField]
		private FocusExitEvent m_FocusExited;

		[SerializeField]
		private ActivateEvent m_Activated;

		[SerializeField]
		private DeactivateEvent m_Deactivated;

		private readonly HashSetList<IXRHoverInteractor> m_InteractorsHovering;

		private readonly HashSetList<IXRSelectInteractor> m_InteractorsSelecting;

		private readonly HashSetList<IXRInteractionGroup> m_InteractionGroupsFocusing;

		[SerializeField]
		[RequireInterface(typeof(IXRHoverFilter))]
		private List<Object> m_StartingHoverFilters;

		private readonly ExposedRegistrationList<IXRHoverFilter> m_HoverFilters;

		[SerializeField]
		[RequireInterface(typeof(IXRSelectFilter))]
		private List<Object> m_StartingSelectFilters;

		private readonly ExposedRegistrationList<IXRSelectFilter> m_SelectFilters;

		[SerializeField]
		[RequireInterface(typeof(IXRInteractionStrengthFilter))]
		private List<Object> m_StartingInteractionStrengthFilters;

		private readonly ExposedRegistrationList<IXRInteractionStrengthFilter> m_InteractionStrengthFilters;

		private readonly BindableVariable<float> m_LargestInteractionStrength;

		private readonly Dictionary<IXRSelectInteractor, Pose> m_AttachPoseOnSelect;

		private readonly Dictionary<IXRSelectInteractor, Pose> m_LocalAttachPoseOnSelect;

		private readonly Dictionary<IXRInteractor, GameObject> m_ReticleCache;

		private readonly HashSetList<XRBaseInputInteractor> m_VariableSelectInteractors;

		private readonly Dictionary<IXRInteractor, float> m_InteractionStrengths;

		private XRInteractionManager m_RegisteredInteractionManager;

		private static readonly ProfilerMarker s_ProcessInteractionStrengthMarker;

		private const string k_InteractionLayerMaskDeprecated = "interactionLayerMask has been deprecated. Use interactionLayers instead.";

		private const string k_OnHoverEnteringDeprecated = "OnHoverEntering(XRBaseInteractor) has been deprecated. Use OnHoverEntering(HoverEnterEventArgs) instead.";

		private const string k_OnHoverEnteredDeprecated = "OnHoverEntered(XRBaseInteractor) has been deprecated. Use OnHoverEntered(HoverEnterEventArgs) instead.";

		private const string k_OnHoverExitingDeprecated = "OnHoverExiting(XRBaseInteractor) has been deprecated. Use OnHoverExiting(HoverExitEventArgs) instead.";

		private const string k_OnHoverExitedDeprecated = "OnHoverExited(XRBaseInteractor) has been deprecated. Use OnHoverExited(HoverExitEventArgs) instead.";

		private const string k_OnSelectEnteringDeprecated = "OnSelectEntering(XRBaseInteractor) has been deprecated. Use OnSelectEntering(SelectEnterEventArgs) instead.";

		private const string k_OnSelectEnteredDeprecated = "OnSelectEntered(XRBaseInteractor) has been deprecated. Use OnSelectEntered(SelectEnterEventArgs) instead.";

		private const string k_OnSelectExitingDeprecated = "OnSelectExiting(XRBaseInteractor) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) and check for !args.isCanceled instead.";

		private const string k_OnSelectExitedDeprecated = "OnSelectExited(XRBaseInteractor) has been deprecated. Use OnSelectExited(SelectExitEventArgs) and check for !args.isCanceled instead.";

		private const string k_OnSelectCancelingDeprecated = "OnSelectCanceling(XRBaseInteractor) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) and check for args.isCanceled instead.";

		private const string k_OnSelectCanceledDeprecated = "OnSelectCanceled(XRBaseInteractor) has been deprecated. Use OnSelectExited(SelectExitEventArgs) and check for args.isCanceled instead.";

		private const string k_OnActivateDeprecated = "OnActivate(XRBaseInteractor) has been deprecated. Use OnActivated(ActivateEventArgs) instead.";

		private const string k_OnDeactivateDeprecated = "OnDeactivate(XRBaseInteractor) has been deprecated. Use OnDeactivated(DeactivateEventArgs) instead.";

		private const string k_GetDistanceSqrToInteractorDeprecated = "GetDistanceSqrToInteractor(XRBaseInteractor) has been deprecated. Use GetDistanceSqrToInteractor(IXRInteractor) instead.";

		private const string k_AttachCustomReticleDeprecated = "AttachCustomReticle(XRBaseInteractor) has been deprecated. Use AttachCustomReticle(IXRInteractor) instead.";

		private const string k_RemoveCustomReticleDeprecated = "RemoveCustomReticle(XRBaseInteractor) has been deprecated. Use RemoveCustomReticle(IXRInteractor) instead.";

		private const string k_HoveringInteractorsDeprecated = "hoveringInteractors has been deprecated. Use interactorsHovering instead.";

		private const string k_SelectingInteractorDeprecated = "selectingInteractor has been deprecated. Use interactorsSelecting, GetOldestInteractorSelecting, or isSelected for similar functionality.";

		private const string k_IsHoverableByDeprecated = "IsHoverableBy(XRBaseInteractor) has been deprecated. Use IsHoverableBy(IXRHoverInteractor) instead.";

		private const string k_IsSelectableByDeprecated = "IsSelectableBy(XRBaseInteractor) has been deprecated. Use IsSelectableBy(IXRSelectInteractor) instead.";

		public Func<IXRInteractable, Vector3, DistanceInfo> getDistanceOverride
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public XRInteractionManager interactionManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Collider> colliders => null;

		public InteractionLayerMask interactionLayers
		{
			get
			{
				return default(InteractionLayerMask);
			}
			set
			{
			}
		}

		public DistanceCalculationMode distanceCalculationMode
		{
			get
			{
				return default(DistanceCalculationMode);
			}
			set
			{
			}
		}

		public InteractableSelectMode selectMode
		{
			get
			{
				return default(InteractableSelectMode);
			}
			set
			{
			}
		}

		public InteractableFocusMode focusMode
		{
			get
			{
				return default(InteractableFocusMode);
			}
			set
			{
			}
		}

		public GameObject customReticle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool allowGazeInteraction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowGazeSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool overrideGazeTimeToSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float gazeTimeToSelect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool overrideTimeToAutoDeselectGaze
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float timeToAutoDeselectGaze
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool allowGazeAssistance
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public HoverEnterEvent firstHoverEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HoverExitEvent lastHoverExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HoverEnterEvent hoverEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HoverExitEvent hoverExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectEnterEvent firstSelectEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectExitEvent lastSelectExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectEnterEvent selectEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectExitEvent selectExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FocusEnterEvent firstFocusEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FocusExitEvent lastFocusExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FocusEnterEvent focusEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FocusExitEvent focusExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ActivateEvent activated
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DeactivateEvent deactivated
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<IXRHoverInteractor> interactorsHovering => null;

		public bool isHovered => false;

		public List<IXRSelectInteractor> interactorsSelecting => null;

		public IXRSelectInteractor firstInteractorSelecting
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

		public bool isSelected => false;

		public List<IXRInteractionGroup> interactionGroupsFocusing => null;

		public IXRInteractionGroup firstInteractionGroupFocusing
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

		public bool isFocused => false;

		public bool canFocus => false;

		public List<Object> startingHoverFilters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IXRFilterList<IXRHoverFilter> hoverFilters => null;

		public List<Object> startingSelectFilters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IXRFilterList<IXRSelectFilter> selectFilters => null;

		public List<Object> startingInteractionStrengthFilters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IXRFilterList<IXRInteractionStrengthFilter> interactionStrengthFilters => null;

		public IReadOnlyBindableVariable<float> largestInteractionStrength => null;

		[Obsolete("interactionLayerMask has been deprecated. Use interactionLayers instead.", true)]
		public LayerMask interactionLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		[Obsolete("onFirstHoverEntered has been deprecated. Use firstHoverEntered with updated signature instead.", true)]
		public XRInteractableEvent onFirstHoverEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onLastHoverExited has been deprecated. Use lastHoverExited with updated signature instead.", true)]
		public XRInteractableEvent onLastHoverExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onHoverEntered has been deprecated. Use hoverEntered with updated signature instead.", true)]
		public XRInteractableEvent onHoverEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onHoverExited has been deprecated. Use hoverExited with updated signature instead.", true)]
		public XRInteractableEvent onHoverExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onSelectEntered has been deprecated. Use selectEntered with updated signature instead.", true)]
		public XRInteractableEvent onSelectEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onSelectExited has been deprecated. Use selectExited with updated signature and check for !args.isCanceled instead.", true)]
		public XRInteractableEvent onSelectExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onSelectCanceled has been deprecated. Use selectExited with updated signature and check for args.isCanceled instead.", true)]
		public XRInteractableEvent onSelectCanceled
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onActivate has been deprecated. Use activated with updated signature instead.", true)]
		public XRInteractableEvent onActivate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onDeactivate has been deprecated. Use deactivated with updated signature instead.", true)]
		public XRInteractableEvent onDeactivate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onFirstHoverEnter has been deprecated. Use onFirstHoverEntered instead. (UnityUpgradable) -> onFirstHoverEntered", true)]
		public XRInteractableEvent onFirstHoverEnter => null;

		[Obsolete("onHoverEnter has been deprecated. Use onHoverEntered instead. (UnityUpgradable) -> onHoverEntered", true)]
		public XRInteractableEvent onHoverEnter => null;

		[Obsolete("onHoverExit has been deprecated. Use onHoverExited instead. (UnityUpgradable) -> onHoverExited", true)]
		public XRInteractableEvent onHoverExit => null;

		[Obsolete("onLastHoverExit has been deprecated. Use onLastHoverExited instead. (UnityUpgradable) -> onLastHoverExited", true)]
		public XRInteractableEvent onLastHoverExit => null;

		[Obsolete("onSelectEnter has been deprecated. Use onSelectEntered instead. (UnityUpgradable) -> onSelectEntered", true)]
		public XRInteractableEvent onSelectEnter => null;

		[Obsolete("onSelectExit has been deprecated. Use onSelectExited instead. (UnityUpgradable) -> onSelectExited", true)]
		public XRInteractableEvent onSelectExit => null;

		[Obsolete("onSelectCancel has been deprecated. Use onSelectCanceled instead. (UnityUpgradable) -> onSelectCanceled", true)]
		public XRInteractableEvent onSelectCancel => null;

		[Obsolete("hoveringInteractors has been deprecated. Use interactorsHovering instead.", true)]
		public List<XRBaseInteractor> hoveringInteractors => null;

		[Obsolete("selectingInteractor has been deprecated. Use interactorsSelecting, GetOldestInteractorSelecting, or isSelected for similar functionality.", true)]
		public XRBaseInteractor selectingInteractor
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public event Action<InteractableRegisteredEventArgs> registered
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

		public event Action<InteractableUnregisteredEventArgs> unregistered
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

		[Conditional("UNITY_EDITOR")]
		protected virtual void Reset()
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

		protected virtual void OnDestroy()
		{
		}

		private void FindCreateInteractionManager()
		{
		}

		private void RegisterWithInteractionManager()
		{
		}

		private void UnregisterWithInteractionManager()
		{
		}

		public virtual Transform GetAttachTransform(IXRInteractor interactor)
		{
			return null;
		}

		public Pose GetAttachPoseOnSelect(IXRSelectInteractor interactor)
		{
			return default(Pose);
		}

		public Pose GetLocalAttachPoseOnSelect(IXRSelectInteractor interactor)
		{
			return default(Pose);
		}

		public virtual float GetDistanceSqrToInteractor(IXRInteractor interactor)
		{
			return 0f;
		}

		public virtual DistanceInfo GetDistance(Vector3 position)
		{
			return default(DistanceInfo);
		}

		public float GetInteractionStrength(IXRInteractor interactor)
		{
			return 0f;
		}

		public virtual bool IsHoverableBy(IXRHoverInteractor interactor)
		{
			return false;
		}

		public virtual bool IsSelectableBy(IXRSelectInteractor interactor)
		{
			return false;
		}

		public bool IsHovered(IXRHoverInteractor interactor)
		{
			return false;
		}

		public bool IsSelected(IXRSelectInteractor interactor)
		{
			return false;
		}

		protected bool IsHovered(IXRInteractor interactor)
		{
			return false;
		}

		protected bool IsSelected(IXRInteractor interactor)
		{
			return false;
		}

		public virtual GameObject GetCustomReticle(IXRInteractor interactor)
		{
			return null;
		}

		public virtual void AttachCustomReticle(IXRInteractor interactor)
		{
		}

		public virtual void RemoveCustomReticle(IXRInteractor interactor)
		{
		}

		protected void CaptureAttachPose(IXRSelectInteractor interactor)
		{
		}

		public virtual void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		void IXRInteractionStrengthInteractable.ProcessInteractionStrength(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		void IXRInteractable.OnRegistered(InteractableRegisteredEventArgs args)
		{
		}

		void IXRInteractable.OnUnregistered(InteractableUnregisteredEventArgs args)
		{
		}

		void IXRActivateInteractable.OnActivated(ActivateEventArgs args)
		{
		}

		void IXRActivateInteractable.OnDeactivated(DeactivateEventArgs args)
		{
		}

		bool IXRHoverInteractable.IsHoverableBy(IXRHoverInteractor interactor)
		{
			return false;
		}

		void IXRHoverInteractable.OnHoverEntering(HoverEnterEventArgs args)
		{
		}

		void IXRHoverInteractable.OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		void IXRHoverInteractable.OnHoverExiting(HoverExitEventArgs args)
		{
		}

		void IXRHoverInteractable.OnHoverExited(HoverExitEventArgs args)
		{
		}

		bool IXRSelectInteractable.IsSelectableBy(IXRSelectInteractor interactor)
		{
			return false;
		}

		void IXRSelectInteractable.OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		void IXRSelectInteractable.OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		void IXRSelectInteractable.OnSelectExiting(SelectExitEventArgs args)
		{
		}

		void IXRSelectInteractable.OnSelectExited(SelectExitEventArgs args)
		{
		}

		void IXRFocusInteractable.OnFocusEntering(FocusEnterEventArgs args)
		{
		}

		void IXRFocusInteractable.OnFocusEntered(FocusEnterEventArgs args)
		{
		}

		void IXRFocusInteractable.OnFocusExiting(FocusExitEventArgs args)
		{
		}

		void IXRFocusInteractable.OnFocusExited(FocusExitEventArgs args)
		{
		}

		protected virtual void OnRegistered(InteractableRegisteredEventArgs args)
		{
		}

		protected virtual void OnUnregistered(InteractableUnregisteredEventArgs args)
		{
		}

		protected virtual void OnHoverEntering(HoverEnterEventArgs args)
		{
		}

		protected virtual void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		protected virtual void OnHoverExiting(HoverExitEventArgs args)
		{
		}

		protected virtual void OnHoverExited(HoverExitEventArgs args)
		{
		}

		protected virtual void OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		protected virtual void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		protected virtual void OnSelectExiting(SelectExitEventArgs args)
		{
		}

		protected virtual void OnSelectExited(SelectExitEventArgs args)
		{
		}

		protected virtual void OnFocusEntering(FocusEnterEventArgs args)
		{
		}

		protected virtual void OnFocusEntered(FocusEnterEventArgs args)
		{
		}

		protected virtual void OnFocusExiting(FocusExitEventArgs args)
		{
		}

		protected virtual void OnFocusExited(FocusExitEventArgs args)
		{
		}

		protected virtual void OnActivated(ActivateEventArgs args)
		{
		}

		protected virtual void OnDeactivated(DeactivateEventArgs args)
		{
		}

		protected virtual void ProcessInteractionStrength(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected bool ProcessHoverFilters(IXRHoverInteractor interactor)
		{
			return false;
		}

		protected bool ProcessSelectFilters(IXRSelectInteractor interactor)
		{
			return false;
		}

		protected float ProcessInteractionStrengthFilters(IXRInteractor interactor, float interactionStrength)
		{
			return 0f;
		}

		[Obsolete("OnHoverEntering(XRBaseInteractor) has been deprecated. Use OnHoverEntering(HoverEnterEventArgs) instead.", true)]
		protected virtual void OnHoverEntering(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnHoverEntered(XRBaseInteractor) has been deprecated. Use OnHoverEntered(HoverEnterEventArgs) instead.", true)]
		protected virtual void OnHoverEntered(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnHoverExiting(XRBaseInteractor) has been deprecated. Use OnHoverExiting(HoverExitEventArgs) instead.", true)]
		protected virtual void OnHoverExiting(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnHoverExited(XRBaseInteractor) has been deprecated. Use OnHoverExited(HoverExitEventArgs) instead.", true)]
		protected virtual void OnHoverExited(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnSelectEntering(XRBaseInteractor) has been deprecated. Use OnSelectEntering(SelectEnterEventArgs) instead.", true)]
		protected virtual void OnSelectEntering(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnSelectEntered(XRBaseInteractor) has been deprecated. Use OnSelectEntered(SelectEnterEventArgs) instead.", true)]
		protected virtual void OnSelectEntered(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnSelectExiting(XRBaseInteractor) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) and check for !args.isCanceled instead.", true)]
		protected virtual void OnSelectExiting(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnSelectExited(XRBaseInteractor) has been deprecated. Use OnSelectExited(SelectExitEventArgs) and check for !args.isCanceled instead.", true)]
		protected virtual void OnSelectExited(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnSelectCanceling(XRBaseInteractor) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) and check for args.isCanceled instead.", true)]
		protected virtual void OnSelectCanceling(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnSelectCanceled(XRBaseInteractor) has been deprecated. Use OnSelectExited(SelectExitEventArgs) and check for args.isCanceled instead.", true)]
		protected virtual void OnSelectCanceled(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnActivate(XRBaseInteractor) has been deprecated. Use OnActivated(ActivateEventArgs) instead.", true)]
		protected virtual void OnActivate(XRBaseInteractor interactor)
		{
		}

		[Obsolete("OnDeactivate(XRBaseInteractor) has been deprecated. Use OnDeactivated(DeactivateEventArgs) instead.", true)]
		protected virtual void OnDeactivate(XRBaseInteractor interactor)
		{
		}

		[Obsolete("GetDistanceSqrToInteractor(XRBaseInteractor) has been deprecated. Use GetDistanceSqrToInteractor(IXRInteractor) instead.", true)]
		public virtual float GetDistanceSqrToInteractor(XRBaseInteractor interactor)
		{
			return 0f;
		}

		[Obsolete("AttachCustomReticle(XRBaseInteractor) has been deprecated. Use AttachCustomReticle(IXRInteractor) instead.", true)]
		public virtual void AttachCustomReticle(XRBaseInteractor interactor)
		{
		}

		[Obsolete("RemoveCustomReticle(XRBaseInteractor) has been deprecated. Use RemoveCustomReticle(IXRInteractor) instead.", true)]
		public virtual void RemoveCustomReticle(XRBaseInteractor interactor)
		{
		}

		[Obsolete("IsHoverableBy(XRBaseInteractor) has been deprecated. Use IsHoverableBy(IXRHoverInteractor) instead.", true)]
		public virtual bool IsHoverableBy(XRBaseInteractor interactor)
		{
			return false;
		}

		[Obsolete("IsSelectableBy(XRBaseInteractor) has been deprecated. Use IsSelectableBy(IXRSelectInteractor) instead.", true)]
		public virtual bool IsSelectableBy(XRBaseInteractor interactor)
		{
			return false;
		}

		Transform IXRInteractable.get_transform()
		{
			return null;
		}
	}
}
