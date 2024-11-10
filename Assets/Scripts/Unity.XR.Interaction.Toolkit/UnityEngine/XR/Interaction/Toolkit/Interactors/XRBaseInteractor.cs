using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using Unity.XR.CoreUtils.Bindings.Variables;
using Unity.XR.CoreUtils.Collections;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[SelectionBase]
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(-99)]
	public abstract class XRBaseInteractor : MonoBehaviour, IXRHoverInteractor, IXRInteractor, IXRSelectInteractor, IXRTargetPriorityInteractor, IXRGroupMember, IXRInteractionStrengthInteractor
	{
		private const float k_InteractionStrengthHover = 0f;

		private const float k_InteractionStrengthSelect = 1f;

		[SerializeField]
		private XRInteractionManager m_InteractionManager;

		[SerializeField]
		private InteractionLayerMask m_InteractionLayers;

		[SerializeField]
		private InteractorHandedness m_Handedness;

		[SerializeField]
		private Transform m_AttachTransform;

		[SerializeField]
		private bool m_KeepSelectedTargetValid;

		[SerializeField]
		private bool m_DisableVisualsWhenBlockedInGroup;

		[SerializeField]
		private XRBaseInteractable m_StartingSelectedInteractable;

		[SerializeField]
		private XRBaseTargetFilter m_StartingTargetFilter;

		[SerializeField]
		private HoverEnterEvent m_HoverEntered;

		[SerializeField]
		private HoverExitEvent m_HoverExited;

		[SerializeField]
		private SelectEnterEvent m_SelectEntered;

		[SerializeField]
		private SelectExitEvent m_SelectExited;

		private IXRTargetFilter m_TargetFilter;

		private bool m_AllowHover;

		private bool m_AllowSelect;

		private bool m_IsPerformingManualInteraction;

		private readonly HashSetList<IXRHoverInteractable> m_InteractablesHovered;

		private readonly HashSetList<IXRSelectInteractable> m_InteractablesSelected;

		[SerializeField]
		[RequireInterface(typeof(IXRHoverFilter))]
		private List<Object> m_StartingHoverFilters;

		private readonly ExposedRegistrationList<IXRHoverFilter> m_HoverFilters;

		[SerializeField]
		[RequireInterface(typeof(IXRSelectFilter))]
		private List<Object> m_StartingSelectFilters;

		private readonly ExposedRegistrationList<IXRSelectFilter> m_SelectFilters;

		private readonly BindableVariable<float> m_LargestInteractionStrength;

		private readonly Dictionary<IXRSelectInteractable, Pose> m_AttachPoseOnSelect;

		private readonly Dictionary<IXRSelectInteractable, Pose> m_LocalAttachPoseOnSelect;

		private readonly HashSetList<IXRInteractionStrengthInteractable> m_InteractionStrengthInteractables;

		private readonly Dictionary<IXRInteractable, float> m_InteractionStrengths;

		private IXRSelectInteractable m_ManualInteractionInteractable;

		private XRInteractionManager m_RegisteredInteractionManager;

		private static readonly ProfilerMarker s_ProcessInteractionStrengthMarker;

		private Transform m_XROriginTransform;

		private bool m_HasXROrigin;

		private bool m_FailedToFindXROrigin;

		private const string k_InteractionLayerMaskDeprecated = "interactionLayerMask has been deprecated. Use interactionLayers instead.";

		private const string k_EnableInteractionsDeprecated = "enableInteractions has been deprecated. Use allowHover and allowSelect instead.";

		private const string k_OnHoverEnteringDeprecated = "OnHoverEntering(XRBaseInteractable) has been deprecated. Use OnHoverEntering(HoverEnterEventArgs) instead.";

		private const string k_OnHoverEnteredDeprecated = "OnHoverEntered(XRBaseInteractable) has been deprecated. Use OnHoverEntered(HoverEnterEventArgs) instead.";

		private const string k_OnHoverExitingDeprecated = "OnHoverExiting(XRBaseInteractable) has been deprecated. Use OnHoverExiting(HoverExitEventArgs) instead.";

		private const string k_OnHoverExitedDeprecated = "OnHoverExited(XRBaseInteractable) has been deprecated. Use OnHoverExited(HoverExitEventArgs) instead.";

		private const string k_OnSelectEnteringDeprecated = "OnSelectEntering(XRBaseInteractable) has been deprecated. Use OnSelectEntering(SelectEnterEventArgs) instead.";

		private const string k_OnSelectEnteredDeprecated = "OnSelectEntered(XRBaseInteractable) has been deprecated. Use OnSelectEntered(SelectEnterEventArgs) instead.";

		private const string k_OnSelectExitingDeprecated = "OnSelectExiting(XRBaseInteractable) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) instead.";

		private const string k_OnSelectExitedDeprecated = "OnSelectExited(XRBaseInteractable) has been deprecated. Use OnSelectExited(SelectExitEventArgs) instead.";

		private const string k_SelectTargetDeprecated = "selectTarget has been deprecated. Use interactablesSelected, GetOldestInteractableSelected, hasSelection, or IsSelecting for similar functionality.";

		private const string k_HoverTargetsDeprecated = "hoverTargets has been deprecated. Use interactablesHovered instead.";

		private const string k_GetHoverTargetsDeprecated = "GetHoverTargets has been deprecated. Use interactablesHovered instead.";

		private const string k_GetValidTargetsDeprecated = "GetValidTargets(List<XRBaseInteractable>) has been deprecated. Override GetValidTargets(List<IXRInteractable>) instead.";

		private const string k_CanHoverDeprecated = "CanHover(XRBaseInteractable) has been deprecated. Use CanHover(IXRHoverInteractable) instead.";

		private const string k_CanSelectDeprecated = "CanSelect(XRBaseInteractable) has been deprecated. Use CanSelect(IXRSelectInteractable) instead.";

		private const string k_RequireSelectExclusiveDeprecated = "requireSelectExclusive has been deprecated. Put logic in CanSelect instead.";

		private const string k_StartManualInteractionDeprecated = "StartManualInteraction(XRBaseInteractable) has been deprecated. Use StartManualInteraction(IXRSelectInteractable) instead.";

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

		public IXRInteractionGroup containingGroup
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

		public InteractorHandedness handedness
		{
			get
			{
				return default(InteractorHandedness);
			}
			set
			{
			}
		}

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

		public bool keepSelectedTargetValid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool disableVisualsWhenBlockedInGroup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public XRBaseInteractable startingSelectedInteractable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRBaseTargetFilter startingTargetFilter
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

		public IXRTargetFilter targetFilter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool allowHover
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isPerformingManualInteraction => false;

		public List<IXRHoverInteractable> interactablesHovered => null;

		public bool hasHover => false;

		public List<IXRSelectInteractable> interactablesSelected => null;

		public IXRSelectInteractable firstInteractableSelected
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

		public bool hasSelection => false;

		internal bool isInteractingWithUI
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

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

		public IReadOnlyBindableVariable<float> largestInteractionStrength => null;

		public virtual bool isHoverActive => false;

		public virtual bool isSelectActive => false;

		public virtual TargetPriorityMode targetPriorityMode
		{
			[CompilerGenerated]
			get
			{
				return default(TargetPriorityMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual List<IXRSelectInteractable> targetsForSelection
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

		public virtual XRBaseInteractable.MovementType? selectedInteractableMovementTypeOverride => null;

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

		[Obsolete("enableInteractions has been deprecated. Use allowHover and allowSelect instead.", true)]
		public bool enableInteractions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("onHoverEntered has been deprecated. Use hoverEntered with updated signature instead.", true)]
		public XRInteractorEvent onHoverEntered
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
		public XRInteractorEvent onHoverExited
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
		public XRInteractorEvent onSelectEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onSelectExited has been deprecated. Use selectExited with updated signature instead.", true)]
		public XRInteractorEvent onSelectExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("onHoverEnter has been deprecated. Use onHoverEntered instead. (UnityUpgradable) -> onHoverEntered", true)]
		public XRInteractorEvent onHoverEnter => null;

		[Obsolete("onHoverExit has been deprecated. Use onHoverExited instead. (UnityUpgradable) -> onHoverExited", true)]
		public XRInteractorEvent onHoverExit => null;

		[Obsolete("onSelectEnter has been deprecated. Use onSelectEntered instead. (UnityUpgradable) -> onSelectEntered", true)]
		public XRInteractorEvent onSelectEnter => null;

		[Obsolete("onSelectExit has been deprecated. Use onSelectExited instead. (UnityUpgradable) -> onSelectExited", true)]
		public XRInteractorEvent onSelectExit => null;

		[Obsolete("selectTarget has been deprecated. Use interactablesSelected, GetOldestInteractableSelected, hasSelection, or IsSelecting for similar functionality.", true)]
		public XRBaseInteractable selectTarget
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		[Obsolete("hoverTargets has been deprecated. Use interactablesHovered instead.", true)]
		protected List<XRBaseInteractable> hoverTargets => null;

		[Obsolete("requireSelectExclusive has been deprecated. Put logic in CanSelect instead.", true)]
		public virtual bool requireSelectExclusive => false;

		public event Action<InteractorRegisteredEventArgs> registered
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

		public event Action<InteractorUnregisteredEventArgs> unregistered
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

		internal bool TryGetXROrigin(out Transform origin)
		{
			origin = null;
			return false;
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

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual Transform GetAttachTransform(IXRInteractable interactable)
		{
			return null;
		}

		public Pose GetAttachPoseOnSelect(IXRSelectInteractable interactable)
		{
			return default(Pose);
		}

		public Pose GetLocalAttachPoseOnSelect(IXRSelectInteractable interactable)
		{
			return default(Pose);
		}

		public virtual void GetValidTargets(List<IXRInteractable> targets)
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

		public virtual bool CanHover(IXRHoverInteractable interactable)
		{
			return false;
		}

		public virtual bool CanSelect(IXRSelectInteractable interactable)
		{
			return false;
		}

		public bool IsHovering(IXRHoverInteractable interactable)
		{
			return false;
		}

		public bool IsSelecting(IXRSelectInteractable interactable)
		{
			return false;
		}

		protected bool IsHovering(IXRInteractable interactable)
		{
			return false;
		}

		protected bool IsSelecting(IXRInteractable interactable)
		{
			return false;
		}

		protected void CaptureAttachPose(IXRSelectInteractable interactable)
		{
		}

		protected void CreateAttachTransform()
		{
		}

		public virtual void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public virtual void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public float GetInteractionStrength(IXRInteractable interactable)
		{
			return 0f;
		}

		void IXRInteractionStrengthInteractor.ProcessInteractionStrength(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		void IXRInteractor.OnRegistered(InteractorRegisteredEventArgs args)
		{
		}

		void IXRInteractor.OnUnregistered(InteractorUnregisteredEventArgs args)
		{
		}

		bool IXRHoverInteractor.CanHover(IXRHoverInteractable interactable)
		{
			return false;
		}

		void IXRHoverInteractor.OnHoverEntering(HoverEnterEventArgs args)
		{
		}

		void IXRHoverInteractor.OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		void IXRHoverInteractor.OnHoverExiting(HoverExitEventArgs args)
		{
		}

		void IXRHoverInteractor.OnHoverExited(HoverExitEventArgs args)
		{
		}

		bool IXRSelectInteractor.CanSelect(IXRSelectInteractable interactable)
		{
			return false;
		}

		void IXRSelectInteractor.OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		void IXRSelectInteractor.OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		void IXRSelectInteractor.OnSelectExiting(SelectExitEventArgs args)
		{
		}

		void IXRSelectInteractor.OnSelectExited(SelectExitEventArgs args)
		{
		}

		protected virtual void OnRegistered(InteractorRegisteredEventArgs args)
		{
		}

		protected virtual void OnUnregistered(InteractorUnregisteredEventArgs args)
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

		protected virtual void ProcessInteractionStrength(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public virtual void StartManualInteraction(IXRSelectInteractable interactable)
		{
		}

		public virtual void EndManualInteraction()
		{
		}

		protected bool ProcessHoverFilters(IXRHoverInteractable interactable)
		{
			return false;
		}

		protected bool ProcessSelectFilters(IXRSelectInteractable interactable)
		{
			return false;
		}

		void IXRGroupMember.OnRegisteringAsGroupMember(IXRInteractionGroup group)
		{
		}

		void IXRGroupMember.OnRegisteringAsNonGroupMember()
		{
		}

		[Obsolete("OnHoverEntering(XRBaseInteractable) has been deprecated. Use OnHoverEntering(HoverEnterEventArgs) instead.", true)]
		protected virtual void OnHoverEntering(XRBaseInteractable interactable)
		{
		}

		[Obsolete("OnHoverEntered(XRBaseInteractable) has been deprecated. Use OnHoverEntered(HoverEnterEventArgs) instead.", true)]
		protected virtual void OnHoverEntered(XRBaseInteractable interactable)
		{
		}

		[Obsolete("OnHoverExiting(XRBaseInteractable) has been deprecated. Use OnHoverExiting(HoverExitEventArgs) instead.", true)]
		protected virtual void OnHoverExiting(XRBaseInteractable interactable)
		{
		}

		[Obsolete("OnHoverExited(XRBaseInteractable) has been deprecated. Use OnHoverExited(HoverExitEventArgs) instead.", true)]
		protected virtual void OnHoverExited(XRBaseInteractable interactable)
		{
		}

		[Obsolete("OnSelectEntering(XRBaseInteractable) has been deprecated. Use OnSelectEntering(SelectEnterEventArgs) instead.", true)]
		protected virtual void OnSelectEntering(XRBaseInteractable interactable)
		{
		}

		[Obsolete("OnSelectEntered(XRBaseInteractable) has been deprecated. Use OnSelectEntered(SelectEnterEventArgs) instead.", true)]
		protected virtual void OnSelectEntered(XRBaseInteractable interactable)
		{
		}

		[Obsolete("OnSelectExiting(XRBaseInteractable) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) instead.", true)]
		protected virtual void OnSelectExiting(XRBaseInteractable interactable)
		{
		}

		[Obsolete("OnSelectExited(XRBaseInteractable) has been deprecated. Use OnSelectExited(SelectExitEventArgs) instead.", true)]
		protected virtual void OnSelectExited(XRBaseInteractable interactable)
		{
		}

		[Obsolete("GetHoverTargets has been deprecated. Use interactablesHovered instead.", true)]
		public void GetHoverTargets(List<XRBaseInteractable> targets)
		{
		}

		[Obsolete("GetValidTargets(List<XRBaseInteractable>) has been deprecated. Override GetValidTargets(List<IXRInteractable>) instead.", true)]
		public virtual void GetValidTargets(List<XRBaseInteractable> targets)
		{
		}

		[Obsolete("CanHover(XRBaseInteractable) has been deprecated. Use CanHover(IXRHoverInteractable) instead.", true)]
		public virtual bool CanHover(XRBaseInteractable interactable)
		{
			return false;
		}

		[Obsolete("CanSelect(XRBaseInteractable) has been deprecated. Use CanSelect(IXRSelectInteractable) instead.", true)]
		public virtual bool CanSelect(XRBaseInteractable interactable)
		{
			return false;
		}

		[Obsolete("StartManualInteraction(XRBaseInteractable) has been deprecated. Use StartManualInteraction(IXRSelectInteractable) instead.", true)]
		public virtual void StartManualInteraction(XRBaseInteractable interactable)
		{
		}

		Transform IXRInteractor.get_transform()
		{
			return null;
		}
	}
}
