using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/XR Interaction Manager", 11)]
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(-105)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.html")]
	public class XRInteractionManager : MonoBehaviour
	{
		[SerializeField]
		[RequireInterface(typeof(IXRHoverFilter))]
		private List<Object> m_StartingHoverFilters;

		private readonly ExposedRegistrationList<IXRHoverFilter> m_HoverFilters;

		[SerializeField]
		[RequireInterface(typeof(IXRSelectFilter))]
		private List<Object> m_StartingSelectFilters;

		private readonly ExposedRegistrationList<IXRSelectFilter> m_SelectFilters;

		private readonly Dictionary<Collider, IXRInteractable> m_ColliderToInteractableMap;

		private readonly Dictionary<Collider, XRInteractableSnapVolume> m_ColliderToSnapVolumes;

		private readonly RegistrationList<IXRInteractor> m_Interactors;

		private readonly RegistrationList<IXRInteractionGroup> m_InteractionGroups;

		private readonly RegistrationList<IXRInteractable> m_Interactables;

		private readonly List<IXRHoverInteractable> m_CurrentHovered;

		private readonly List<IXRSelectInteractable> m_CurrentSelected;

		private readonly Dictionary<IXRSelectInteractable, List<IXRTargetPriorityInteractor>> m_HighestPriorityTargetMap;

		private static readonly LinkedPool<List<IXRTargetPriorityInteractor>> s_TargetPriorityInteractorListPool;

		private readonly List<IXRInteractable> m_ValidTargets;

		private readonly HashSet<IXRInteractable> m_UnorderedValidTargets;

		private readonly HashSet<IXRInteractor> m_InteractorsInGroup;

		private readonly HashSet<IXRInteractionGroup> m_GroupsInGroup;

		private readonly List<IXRInteractionGroup> m_ScratchInteractionGroups;

		private readonly List<IXRInteractor> m_ScratchInteractors;

		private readonly LinkedPool<FocusEnterEventArgs> m_FocusEnterEventArgs;

		private readonly LinkedPool<FocusExitEventArgs> m_FocusExitEventArgs;

		private readonly LinkedPool<SelectEnterEventArgs> m_SelectEnterEventArgs;

		private readonly LinkedPool<SelectExitEventArgs> m_SelectExitEventArgs;

		private readonly LinkedPool<HoverEnterEventArgs> m_HoverEnterEventArgs;

		private readonly LinkedPool<HoverExitEventArgs> m_HoverExitEventArgs;

		private readonly LinkedPool<InteractionGroupRegisteredEventArgs> m_InteractionGroupRegisteredEventArgs;

		private readonly LinkedPool<InteractionGroupUnregisteredEventArgs> m_InteractionGroupUnregisteredEventArgs;

		private readonly LinkedPool<InteractorRegisteredEventArgs> m_InteractorRegisteredEventArgs;

		private readonly LinkedPool<InteractorUnregisteredEventArgs> m_InteractorUnregisteredEventArgs;

		private readonly LinkedPool<InteractableRegisteredEventArgs> m_InteractableRegisteredEventArgs;

		private readonly LinkedPool<InteractableUnregisteredEventArgs> m_InteractableUnregisteredEventArgs;

		private static readonly ProfilerMarker s_PreprocessInteractorsMarker;

		private static readonly ProfilerMarker s_ProcessInteractionStrengthMarker;

		private static readonly ProfilerMarker s_ProcessInteractorsMarker;

		private static readonly ProfilerMarker s_ProcessInteractablesMarker;

		private static readonly ProfilerMarker s_UpdateGroupMemberInteractionsMarker;

		internal static readonly ProfilerMarker s_GetValidTargetsMarker;

		private static readonly ProfilerMarker s_FilterRegisteredValidTargetsMarker;

		internal static readonly ProfilerMarker s_EvaluateInvalidFocusMarker;

		internal static readonly ProfilerMarker s_EvaluateInvalidSelectionsMarker;

		internal static readonly ProfilerMarker s_EvaluateInvalidHoversMarker;

		internal static readonly ProfilerMarker s_EvaluateValidSelectionsMarker;

		internal static readonly ProfilerMarker s_EvaluateValidHoversMarker;

		private static readonly ProfilerMarker s_FocusEnterMarker;

		private static readonly ProfilerMarker s_FocusExitMarker;

		private static readonly ProfilerMarker s_SelectEnterMarker;

		private static readonly ProfilerMarker s_SelectExitMarker;

		private static readonly ProfilerMarker s_HoverEnterMarker;

		private static readonly ProfilerMarker s_HoverExitMarker;

		private const string k_RegisterInteractorDeprecated = "RegisterInteractor(XRBaseInteractor) has been deprecated. Use RegisterInteractor(IXRInteractor) instead. You may need to modify your code by casting the argument to call the intended method, such as `RegisterInteractor((IXRInteractor)this)` instead.";

		private const string k_UnregisterInteractorDeprecated = "UnregisterInteractor(XRBaseInteractor) has been deprecated. Use UnregisterInteractor(IXRInteractor) instead. You may need to modify your code by casting the argument to call the intended method, such as `UnregisterInteractor((IXRInteractor)this)` instead.";

		private const string k_RegisterInteractableDeprecated = "RegisterInteractable(XRBaseInteractable) has been deprecated. Use RegisterInteractable(IXRInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `RegisterInteractable((IXRInteractable)this)` instead.";

		private const string k_UnregisterInteractableDeprecated = "UnregisterInteractable(XRBaseInteractable) has been deprecated. Use UnregisterInteractable(IXRInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `UnregisterInteractable((IXRInteractable)this)` instead.";

		private const string k_GetRegisteredInteractorsDeprecated = "GetRegisteredInteractors(List<XRBaseInteractor>) has been deprecated. Use GetRegisteredInteractors(List<IXRInteractor>) instead.";

		private const string k_GetRegisteredInteractablesDeprecated = "GetRegisteredInteractables(List<XRBaseInteractable>) has been deprecated. Use GetRegisteredInteractables(List<IXRInteractable>) instead.";

		private const string k_IsRegisteredInteractorDeprecated = "IsRegistered(XRBaseInteractor) has been deprecated. Use IsRegistered(IXRInteractor) instead. You may need to modify your code by casting the argument to call the intended method, such as `IsRegistered((IXRInteractor)this)` instead.";

		private const string k_IsRegisteredInteractableDeprecated = "IsRegistered(XRBaseInteractable) has been deprecated. Use IsRegistered(IXRInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `IsRegistered((IXRInteractable)this)` instead.";

		private const string k_TryGetInteractableForColliderDeprecated = "TryGetInteractableForCollider has been deprecated. Use GetInteractableForCollider instead. (UnityUpgradable) -> GetInteractableForCollider(*)";

		private const string k_GetInteractableForColliderDeprecated = "GetInteractableForCollider has been deprecated. Use TryGetInteractableForCollider(Collider, out IXRInteractable) instead.";

		private const string k_GetColliderToInteractableMapDeprecated = "GetColliderToInteractableMap has been deprecated. The signature no longer matches the field used by the XRInteractionManager, so a copy is returned instead of a ref. Changes to the returned Dictionary will not be observed by the XRInteractionManager.";

		private const string k_GetValidTargetsDeprecated = "GetValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use GetValidTargets(IXRInteractor, List<IXRInteractable>) instead.";

		private const string k_ForceSelectDeprecated = "ForceSelect(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable) instead.";

		private const string k_ClearInteractorSelectionDeprecated = "ClearInteractorSelection(XRBaseInteractor) has been deprecated. Use ClearInteractorSelection(IXRSelectInteractor, List<IXRInteractable>) instead.";

		private const string k_CancelInteractorSelectionDeprecated = "CancelInteractorSelection(XRBaseInteractor) has been deprecated. Use CancelInteractorSelection(IXRSelectInteractor) instead.";

		private const string k_CancelInteractableSelectionDeprecated = "CancelInteractableSelection(XRBaseInteractable) has been deprecated. Use CancelInteractableSelection(IXRSelectInteractable) instead.";

		private const string k_ClearInteractorHoverDeprecated = "ClearInteractorHover(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use ClearInteractorHover(IXRHoverInteractor, List<IXRInteractable>) instead.";

		private const string k_CancelInteractorHoverDeprecated = "CancelInteractorHover(XRBaseInteractor) has been deprecated. Use CancelInteractorHover(IXRHoverInteractor) instead.";

		private const string k_CancelInteractableHoverDeprecated = "CancelInteractableHover(XRBaseInteractable) has been deprecated. Use CancelInteractableHover(IXRHoverInteractable) instead.";

		private const string k_SelectEnterDeprecated = "SelectEnter(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `SelectEnter((IXRSelectInteractor)interactor, (IXRSelectInteractable)interactable)` instead.";

		private const string k_SelectExitDeprecated = "SelectExit(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectExit(IXRSelectInteractor, IXRSelectInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `SelectExit((IXRSelectInteractor)interactor, (IXRSelectInteractable)interactable)` instead.";

		private const string k_SelectCancelDeprecated = "SelectCancel(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectCancel(IXRSelectInteractor, IXRSelectInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `SelectCancel((IXRSelectInteractor)interactor, (IXRSelectInteractable)interactable)` instead.";

		private const string k_HoverEnterDeprecated = "HoverEnter(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverEnter(IXRHoverInteractor, IXRHoverInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `HoverEnter((IXRHoverInteractor)interactor, (IXRHoverInteractable)interactable)` instead.";

		private const string k_HoverExitDeprecated = "HoverExit(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverExit(IXRHoverInteractor, IXRHoverInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `HoverExit((IXRHoverInteractor)interactor, (IXRHoverInteractable)interactable)` instead.";

		private const string k_HoverCancelDeprecated = "HoverCancel(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverCancel(IXRHoverInteractor, IXRHoverInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `HoverCancel((IXRHoverInteractor)interactor, (IXRHoverInteractable)interactable)` instead.";

		private const string k_SelectEnterProtectedDeprecated = "SelectEnter(XRBaseInteractor, XRBaseInteractable, SelectEnterEventArgs) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable, SelectEnterEventArgs) instead.";

		private const string k_SelectExitProtectedDeprecated = "SelectExit(XRBaseInteractor, XRBaseInteractable, SelectExitEventArgs) has been deprecated. Use SelectExit(IXRSelectInteractor, IXRSelectInteractable, SelectExitEventArgs) instead.";

		private const string k_HoverEnterProtectedDeprecated = "HoverEnter(XRBaseInteractor, XRBaseInteractable, HoverEnterEventArgs) has been deprecated. Use HoverEnter(IXRHoverInteractor, IXRHoverInteractable, HoverEnterEventArgs) instead.";

		private const string k_HoverExitProtectedDeprecated = "HoverExit(XRBaseInteractor, XRBaseInteractable, HoverExitEventArgs) has been deprecated. Use HoverExit(IXRHoverInteractor, IXRHoverInteractable, HoverExitEventArgs) instead.";

		private const string k_InteractorSelectValidTargetsDeprecated = "InteractorSelectValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use InteractorSelectValidTargets(IXRSelectInteractor, List<IXRInteractable>) instead.";

		private const string k_InteractorHoverValidTargetsDeprecated = "InteractorHoverValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use InteractorHoverValidTargets(IXRHoverInteractor, List<IXRInteractable>) instead.";

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

		public IXRFocusInteractable lastFocused
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		internal static List<XRInteractionManager> activeInteractionManagers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public event Action<InteractionGroupRegisteredEventArgs> interactionGroupRegistered
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

		public event Action<InteractionGroupUnregisteredEventArgs> interactionGroupUnregistered
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

		public event Action<InteractorRegisteredEventArgs> interactorRegistered
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

		public event Action<InteractorUnregisteredEventArgs> interactorUnregistered
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

		public event Action<InteractableRegisteredEventArgs> interactableRegistered
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

		public event Action<InteractableUnregisteredEventArgs> interactableUnregistered
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

		public event Action<FocusEnterEventArgs> focusGained
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

		public event Action<FocusExitEventArgs> focusLost
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

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		[BeforeRenderOrder(100)]
		protected virtual void OnBeforeRender()
		{
		}

		protected virtual void PreprocessInteractors(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected virtual void ProcessInteractors(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected virtual void ProcessInteractables(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected virtual void ProcessInteractionStrength(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public virtual bool CanHover(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
			return false;
		}

		public bool IsHoverPossible(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
			return false;
		}

		public virtual bool CanSelect(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
			return false;
		}

		public bool IsSelectPossible(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
			return false;
		}

		public virtual bool CanFocus(IXRInteractor interactor, IXRFocusInteractable interactable)
		{
			return false;
		}

		public bool IsFocusPossible(IXRInteractor interactor, IXRFocusInteractable interactable)
		{
			return false;
		}

		public virtual void RegisterInteractionGroup(IXRInteractionGroup interactionGroup)
		{
		}

		protected virtual void OnRegistered(InteractionGroupRegisteredEventArgs args)
		{
		}

		public virtual void UnregisterInteractionGroup(IXRInteractionGroup interactionGroup)
		{
		}

		protected virtual void OnUnregistered(InteractionGroupUnregisteredEventArgs args)
		{
		}

		public void GetInteractionGroups(List<IXRInteractionGroup> interactionGroups)
		{
		}

		public IXRInteractionGroup GetInteractionGroup(string groupName)
		{
			return null;
		}

		public virtual void RegisterInteractor(IXRInteractor interactor)
		{
		}

		protected virtual void OnRegistered(InteractorRegisteredEventArgs args)
		{
		}

		public virtual void UnregisterInteractor(IXRInteractor interactor)
		{
		}

		protected virtual void OnUnregistered(InteractorUnregisteredEventArgs args)
		{
		}

		public virtual void RegisterInteractable(IXRInteractable interactable)
		{
		}

		protected virtual void OnRegistered(InteractableRegisteredEventArgs args)
		{
		}

		public virtual void UnregisterInteractable(IXRInteractable interactable)
		{
		}

		protected virtual void OnUnregistered(InteractableUnregisteredEventArgs args)
		{
		}

		public void RegisterSnapVolume(XRInteractableSnapVolume snapVolume)
		{
		}

		public void UnregisterSnapVolume(XRInteractableSnapVolume snapVolume)
		{
		}

		public void GetRegisteredInteractionGroups(List<IXRInteractionGroup> results)
		{
		}

		public void GetRegisteredInteractors(List<IXRInteractor> results)
		{
		}

		public void GetRegisteredInteractables(List<IXRInteractable> results)
		{
		}

		public bool IsRegistered(IXRInteractionGroup interactionGroup)
		{
			return false;
		}

		public bool IsRegistered(IXRInteractor interactor)
		{
			return false;
		}

		public bool IsRegistered(IXRInteractable interactable)
		{
			return false;
		}

		public bool TryGetInteractableForCollider(Collider interactableCollider, out IXRInteractable interactable)
		{
			interactable = null;
			return false;
		}

		public bool TryGetInteractableForCollider(Collider interactableCollider, out IXRInteractable interactable, out XRInteractableSnapVolume snapVolume)
		{
			interactable = null;
			snapVolume = null;
			return false;
		}

		public bool IsColliderRegisteredToInteractable(in Collider colliderToCheck)
		{
			return false;
		}

		public bool IsColliderRegisteredSnapVolume(in Collider potentialSnapVolumeCollider)
		{
			return false;
		}

		public bool IsHighestPriorityTarget(IXRSelectInteractable target, List<IXRTargetPriorityInteractor> interactors = null)
		{
			return false;
		}

		public bool IsHandSelecting(InteractorHandedness hand)
		{
			return false;
		}

		public void GetValidTargets(IXRInteractor interactor, List<IXRInteractable> targets)
		{
		}

		internal static int RemoveAllUnregistered(XRInteractionManager manager, List<IXRInteractable> interactables)
		{
			return 0;
		}

		protected virtual void ClearInteractionGroupFocus(IXRInteractionGroup interactionGroup)
		{
		}

		private void CancelInteractorFocus(IXRInteractor interactor)
		{
		}

		public virtual void CancelInteractableFocus(IXRFocusInteractable interactable)
		{
		}

		protected internal virtual void ClearInteractorSelection(IXRSelectInteractor interactor, List<IXRInteractable> validTargets)
		{
		}

		public virtual void CancelInteractorSelection(IXRSelectInteractor interactor)
		{
		}

		public virtual void CancelInteractableSelection(IXRSelectInteractable interactable)
		{
		}

		protected internal virtual void ClearInteractorHover(IXRHoverInteractor interactor, List<IXRInteractable> validTargets)
		{
		}

		public virtual void CancelInteractorHover(IXRHoverInteractor interactor)
		{
		}

		public virtual void CancelInteractableHover(IXRHoverInteractable interactable)
		{
		}

		public virtual void FocusEnter(IXRInteractor interactor, IXRFocusInteractable interactable)
		{
		}

		public virtual void FocusExit(IXRInteractionGroup group, IXRFocusInteractable interactable)
		{
		}

		public virtual void FocusCancel(IXRInteractionGroup group, IXRFocusInteractable interactable)
		{
		}

		public virtual void SelectEnter(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
		}

		public virtual void SelectExit(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
		}

		public virtual void SelectCancel(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
		}

		public virtual void HoverEnter(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
		}

		public virtual void HoverExit(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
		}

		public virtual void HoverCancel(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
		}

		protected virtual void FocusEnter(IXRInteractionGroup group, IXRFocusInteractable interactable, FocusEnterEventArgs args)
		{
		}

		protected virtual void FocusExit(IXRInteractionGroup group, IXRFocusInteractable interactable, FocusExitEventArgs args)
		{
		}

		protected virtual void SelectEnter(IXRSelectInteractor interactor, IXRSelectInteractable interactable, SelectEnterEventArgs args)
		{
		}

		protected virtual void SelectExit(IXRSelectInteractor interactor, IXRSelectInteractable interactable, SelectExitEventArgs args)
		{
		}

		protected virtual void HoverEnter(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverEnterEventArgs args)
		{
		}

		protected virtual void HoverExit(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverExitEventArgs args)
		{
		}

		protected internal virtual void InteractorSelectValidTargets(IXRSelectInteractor interactor, List<IXRInteractable> validTargets)
		{
		}

		protected internal virtual void InteractorHoverValidTargets(IXRHoverInteractor interactor, List<IXRInteractable> validTargets)
		{
		}

		protected virtual bool ResolveExistingFocus(IXRInteractionGroup interactionGroup, IXRFocusInteractable interactable)
		{
			return false;
		}

		protected virtual bool ResolveExistingSelect(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
			return false;
		}

		protected static bool HasInteractionLayerOverlap(IXRInteractor interactor, IXRInteractable interactable)
		{
			return false;
		}

		protected bool ProcessHoverFilters(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
			return false;
		}

		protected bool ProcessSelectFilters(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
			return false;
		}

		private void ExitInteractableSelection(IXRSelectInteractable interactable)
		{
		}

		private void ExitInteractableFocus(IXRFocusInteractable interactable)
		{
		}

		private void ClearPriorityForSelectionMap()
		{
		}

		private void FlushRegistration()
		{
		}

		[Obsolete("RegisterInteractor(XRBaseInteractor) has been deprecated. Use RegisterInteractor(IXRInteractor) instead. You may need to modify your code by casting the argument to call the intended method, such as `RegisterInteractor((IXRInteractor)this)` instead.", true)]
		public virtual void RegisterInteractor(XRBaseInteractor interactor)
		{
		}

		[Obsolete("UnregisterInteractor(XRBaseInteractor) has been deprecated. Use UnregisterInteractor(IXRInteractor) instead. You may need to modify your code by casting the argument to call the intended method, such as `UnregisterInteractor((IXRInteractor)this)` instead.", true)]
		public virtual void UnregisterInteractor(XRBaseInteractor interactor)
		{
		}

		[Obsolete("RegisterInteractable(XRBaseInteractable) has been deprecated. Use RegisterInteractable(IXRInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `RegisterInteractable((IXRInteractable)this)` instead.", true)]
		public virtual void RegisterInteractable(XRBaseInteractable interactable)
		{
		}

		[Obsolete("UnregisterInteractable(XRBaseInteractable) has been deprecated. Use UnregisterInteractable(IXRInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `UnregisterInteractable((IXRInteractable)this)` instead.", true)]
		public virtual void UnregisterInteractable(XRBaseInteractable interactable)
		{
		}

		[Obsolete("GetRegisteredInteractors(List<XRBaseInteractor>) has been deprecated. Use GetRegisteredInteractors(List<IXRInteractor>) instead.", true)]
		public void GetRegisteredInteractors(List<XRBaseInteractor> results)
		{
		}

		[Obsolete("GetRegisteredInteractables(List<XRBaseInteractable>) has been deprecated. Use GetRegisteredInteractables(List<IXRInteractable>) instead.", true)]
		public void GetRegisteredInteractables(List<XRBaseInteractable> results)
		{
		}

		[Obsolete("IsRegistered(XRBaseInteractor) has been deprecated. Use IsRegistered(IXRInteractor) instead. You may need to modify your code by casting the argument to call the intended method, such as `IsRegistered((IXRInteractor)this)` instead.", true)]
		public bool IsRegistered(XRBaseInteractor interactor)
		{
			return false;
		}

		[Obsolete("IsRegistered(XRBaseInteractable) has been deprecated. Use IsRegistered(IXRInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `IsRegistered((IXRInteractable)this)` instead.", true)]
		public bool IsRegistered(XRBaseInteractable interactable)
		{
			return false;
		}

		[Obsolete("TryGetInteractableForCollider has been deprecated. Use GetInteractableForCollider instead. (UnityUpgradable) -> GetInteractableForCollider(*)", true)]
		public XRBaseInteractable TryGetInteractableForCollider(Collider interactableCollider)
		{
			return null;
		}

		[Obsolete("GetInteractableForCollider has been deprecated. Use TryGetInteractableForCollider(Collider, out IXRInteractable) instead.", true)]
		public XRBaseInteractable GetInteractableForCollider(Collider interactableCollider)
		{
			return null;
		}

		[Obsolete("GetColliderToInteractableMap has been deprecated. The signature no longer matches the field used by the XRInteractionManager, so a copy is returned instead of a ref. Changes to the returned Dictionary will not be observed by the XRInteractionManager.", true)]
		public void GetColliderToInteractableMap(ref Dictionary<Collider, XRBaseInteractable> map)
		{
		}

		[Obsolete("GetValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use GetValidTargets(IXRInteractor, List<IXRInteractable>) instead.", true)]
		public List<XRBaseInteractable> GetValidTargets(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets)
		{
			return null;
		}

		[Obsolete("ForceSelect(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable) instead.", true)]
		public void ForceSelect(XRBaseInteractor interactor, XRBaseInteractable interactable)
		{
		}

		[Obsolete("ClearInteractorSelection(XRBaseInteractor) has been deprecated. Use ClearInteractorSelection(IXRSelectInteractor, List<IXRInteractable>) instead.", true)]
		public virtual void ClearInteractorSelection(XRBaseInteractor interactor)
		{
		}

		[Obsolete("CancelInteractorSelection(XRBaseInteractor) has been deprecated. Use CancelInteractorSelection(IXRSelectInteractor) instead.", true)]
		public virtual void CancelInteractorSelection(XRBaseInteractor interactor)
		{
		}

		[Obsolete("CancelInteractableSelection(XRBaseInteractable) has been deprecated. Use CancelInteractableSelection(IXRSelectInteractable) instead.", true)]
		public virtual void CancelInteractableSelection(XRBaseInteractable interactable)
		{
		}

		[Obsolete("ClearInteractorHover(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use ClearInteractorHover(IXRHoverInteractor, List<IXRInteractable>) instead.", true)]
		public virtual void ClearInteractorHover(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets)
		{
		}

		[Obsolete("CancelInteractorHover(XRBaseInteractor) has been deprecated. Use CancelInteractorHover(IXRHoverInteractor) instead.", true)]
		public virtual void CancelInteractorHover(XRBaseInteractor interactor)
		{
		}

		[Obsolete("CancelInteractableHover(XRBaseInteractable) has been deprecated. Use CancelInteractableHover(IXRHoverInteractable) instead.", true)]
		public virtual void CancelInteractableHover(XRBaseInteractable interactable)
		{
		}

		[Obsolete("SelectEnter(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `SelectEnter((IXRSelectInteractor)interactor, (IXRSelectInteractable)interactable)` instead.", true)]
		public virtual void SelectEnter(XRBaseInteractor interactor, XRBaseInteractable interactable)
		{
		}

		[Obsolete("SelectExit(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectExit(IXRSelectInteractor, IXRSelectInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `SelectExit((IXRSelectInteractor)interactor, (IXRSelectInteractable)interactable)` instead.", true)]
		public virtual void SelectExit(XRBaseInteractor interactor, XRBaseInteractable interactable)
		{
		}

		[Obsolete("SelectCancel(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectCancel(IXRSelectInteractor, IXRSelectInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `SelectCancel((IXRSelectInteractor)interactor, (IXRSelectInteractable)interactable)` instead.", true)]
		public virtual void SelectCancel(XRBaseInteractor interactor, XRBaseInteractable interactable)
		{
		}

		[Obsolete("HoverEnter(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverEnter(IXRHoverInteractor, IXRHoverInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `HoverEnter((IXRHoverInteractor)interactor, (IXRHoverInteractable)interactable)` instead.", true)]
		public virtual void HoverEnter(XRBaseInteractor interactor, XRBaseInteractable interactable)
		{
		}

		[Obsolete("HoverExit(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverExit(IXRHoverInteractor, IXRHoverInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `HoverExit((IXRHoverInteractor)interactor, (IXRHoverInteractable)interactable)` instead.", true)]
		public virtual void HoverExit(XRBaseInteractor interactor, XRBaseInteractable interactable)
		{
		}

		[Obsolete("HoverCancel(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverCancel(IXRHoverInteractor, IXRHoverInteractable) instead. You may need to modify your code by casting the argument to call the intended method, such as `HoverCancel((IXRHoverInteractor)interactor, (IXRHoverInteractable)interactable)` instead.", true)]
		public virtual void HoverCancel(XRBaseInteractor interactor, XRBaseInteractable interactable)
		{
		}

		[Obsolete("SelectEnter(XRBaseInteractor, XRBaseInteractable, SelectEnterEventArgs) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable, SelectEnterEventArgs) instead.", true)]
		protected virtual void SelectEnter(XRBaseInteractor interactor, XRBaseInteractable interactable, SelectEnterEventArgs args)
		{
		}

		[Obsolete("SelectExit(XRBaseInteractor, XRBaseInteractable, SelectExitEventArgs) has been deprecated. Use SelectExit(IXRSelectInteractor, IXRSelectInteractable, SelectExitEventArgs) instead.", true)]
		protected virtual void SelectExit(XRBaseInteractor interactor, XRBaseInteractable interactable, SelectExitEventArgs args)
		{
		}

		[Obsolete("HoverEnter(XRBaseInteractor, XRBaseInteractable, HoverEnterEventArgs) has been deprecated. Use HoverEnter(IXRHoverInteractor, IXRHoverInteractable, HoverEnterEventArgs) instead.", true)]
		protected virtual void HoverEnter(XRBaseInteractor interactor, XRBaseInteractable interactable, HoverEnterEventArgs args)
		{
		}

		[Obsolete("HoverExit(XRBaseInteractor, XRBaseInteractable, HoverExitEventArgs) has been deprecated. Use HoverExit(IXRHoverInteractor, IXRHoverInteractable, HoverExitEventArgs) instead.", true)]
		protected virtual void HoverExit(XRBaseInteractor interactor, XRBaseInteractable interactable, HoverExitEventArgs args)
		{
		}

		[Obsolete("InteractorSelectValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use InteractorSelectValidTargets(IXRSelectInteractor, List<IXRInteractable>) instead.", true)]
		protected virtual void InteractorSelectValidTargets(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets)
		{
		}

		[Obsolete("InteractorHoverValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use InteractorHoverValidTargets(IXRHoverInteractor, List<IXRInteractable>) instead.", true)]
		protected virtual void InteractorHoverValidTargets(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets)
		{
		}
	}
}
