using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/XR Interaction Group", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup.html")]
	[DefaultExecutionOrder(-100)]
	public class XRInteractionGroup : MonoBehaviour, IXRInteractionOverrideGroup, IXRInteractionGroup, IXRGroupMember
	{
		public static class GroupNames
		{
			public static readonly string k_Left;

			public static readonly string k_Right;

			public static readonly string k_Center;
		}

		[Serializable]
		internal class GroupMemberAndOverridesPair
		{
			[RequireInterface(typeof(IXRGroupMember))]
			public Object groupMember;

			[RequireInterface(typeof(IXRGroupMember))]
			public List<Object> overrideGroupMembers;
		}

		[SerializeField]
		[Tooltip("The name of the interaction group, which can be used to retrieve it from the Interaction Manager.")]
		private string m_GroupName;

		[SerializeField]
		[Tooltip("The XR Interaction Manager that this Interaction Group will communicate with (will find one if not set manually).")]
		private XRInteractionManager m_InteractionManager;

		private XRInteractionManager m_RegisteredInteractionManager;

		[SerializeField]
		[Tooltip("Ordered list of Interactors or Interaction Groups that are registered with the Group on Awake.")]
		[RequireInterface(typeof(IXRGroupMember))]
		private List<Object> m_StartingGroupMembers;

		[SerializeField]
		[Tooltip("Configuration for each Group Member of which other Members are able to override its interaction when they attempt to select, despite the difference in priority order.")]
		private List<GroupMemberAndOverridesPair> m_StartingInteractionOverridesMap;

		private readonly RegistrationList<IXRGroupMember> m_GroupMembers;

		private readonly List<IXRGroupMember> m_TempGroupMembers;

		private bool m_IsProcessingGroupMembers;

		private readonly Dictionary<IXRGroupMember, HashSet<IXRGroupMember>> m_InteractionOverridesMap;

		private readonly List<IXRInteractable> m_ValidTargets;

		private static readonly List<IXRSelectInteractable> s_InteractablesSelected;

		private static readonly List<IXRHoverInteractable> s_InteractablesHovered;

		public string groupName => null;

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

		public List<Object> startingGroupMembers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IXRInteractor activeInteractor
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

		public IXRInteractor focusInteractor
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

		public IXRFocusInteractable focusInteractable
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

		internal bool isRegisteredWithInteractionManager => false;

		internal bool hasRegisteredStartingMembers
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event Action<InteractionGroupRegisteredEventArgs> registered
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

		public event Action<InteractionGroupUnregisteredEventArgs> unregistered
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

		internal void RemoveMissingMembersFromStartingOverridesMap()
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

		public void AddStartingInteractionOverride(Object sourceGroupMember, Object overrideGroupMember)
		{
		}

		public bool RemoveStartingInteractionOverride(Object sourceGroupMember, Object overrideGroupMember)
		{
			return false;
		}

		private bool TryGetStartingGroupMemberAndOverridesPair(Object sourceGroupMember, out GroupMemberAndOverridesPair groupMemberAndOverrides)
		{
			groupMemberAndOverrides = null;
			return false;
		}

		void IXRInteractionGroup.OnRegistered(InteractionGroupRegisteredEventArgs args)
		{
		}

		void IXRInteractionGroup.OnBeforeUnregistered()
		{
		}

		void IXRInteractionGroup.OnUnregistered(InteractionGroupUnregisteredEventArgs args)
		{
		}

		public void AddGroupMember(IXRGroupMember groupMember)
		{
		}

		public void MoveGroupMemberTo(IXRGroupMember groupMember, int newIndex)
		{
		}

		private bool ValidateAddGroupMember(IXRGroupMember groupMember)
		{
			return false;
		}

		public bool RemoveGroupMember(IXRGroupMember groupMember)
		{
			return false;
		}

		private bool GroupMemberIsOrContainsInteractor(IXRGroupMember groupMember, IXRInteractor interactor)
		{
			return false;
		}

		public void ClearGroupMembers()
		{
		}

		public bool ContainsGroupMember(IXRGroupMember groupMember)
		{
			return false;
		}

		public void GetGroupMembers(List<IXRGroupMember> results)
		{
		}

		public bool HasDependencyOnGroup(IXRInteractionGroup group)
		{
			return false;
		}

		public void AddInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember)
		{
		}

		public bool GroupMemberIsPartOfOverrideChain(IXRGroupMember sourceGroupMember, IXRGroupMember potentialOverrideGroupMember)
		{
			return false;
		}

		public bool RemoveInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember)
		{
			return false;
		}

		public bool ClearInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember)
		{
			return false;
		}

		public void GetInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember, HashSet<IXRGroupMember> results)
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

		private void RegisterAsGroupMember(IXRGroupMember groupMember)
		{
		}

		private void RegisterAsNonGroupMember(IXRGroupMember groupMember)
		{
		}

		private void ReRegisterGroupMemberWithInteractionManager(IXRGroupMember groupMember)
		{
		}

		void IXRInteractionGroup.PreprocessGroupMembers(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		void IXRInteractionGroup.ProcessGroupMembers(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		void IXRInteractionGroup.UpdateGroupMemberInteractions()
		{
		}

		private bool CanStartOrContinueAnySelect(IXRSelectInteractor selectInteractor)
		{
			return false;
		}

		void IXRInteractionGroup.UpdateGroupMemberInteractions(IXRInteractor prePrioritizedInteractor, out IXRInteractor interactorThatPerformedInteraction)
		{
			interactorThatPerformedInteraction = null;
		}

		bool IXRInteractionOverrideGroup.ShouldOverrideActiveInteraction(out IXRSelectInteractor overridingInteractor)
		{
			overridingInteractor = null;
			return false;
		}

		private bool TryGetOverridesForContainedInteractor(IXRInteractor interactor, out HashSet<IXRGroupMember> overrideGroupMembers)
		{
			overrideGroupMembers = null;
			return false;
		}

		bool IXRInteractionOverrideGroup.ShouldAnyMemberOverrideInteraction(IXRInteractor interactingInteractor, out IXRSelectInteractor overridingInteractor)
		{
			overridingInteractor = null;
			return false;
		}

		private bool ShouldGroupMemberOverrideInteraction(IXRInteractor interactingInteractor, IXRGroupMember overrideGroupMember, out IXRSelectInteractor overridingInteractor)
		{
			overridingInteractor = null;
			return false;
		}

		private bool ShouldInteractorOverrideInteraction(IXRInteractor interactingInteractor, IXRSelectInteractor overridingInteractor)
		{
			return false;
		}

		private void UpdateInteractorInteractions(IXRInteractor interactor, bool preventInteraction, out bool performedInteraction)
		{
			performedInteraction = default(bool);
		}

		private void ClearAllInteractorSelections(IXRSelectInteractor selectInteractor)
		{
		}

		private void ClearAllInteractorHovers(IXRHoverInteractor hoverInteractor)
		{
		}

		public void OnFocusEntering(FocusEnterEventArgs args)
		{
		}

		public void OnFocusExiting(FocusExitEventArgs args)
		{
		}

		void IXRGroupMember.OnRegisteringAsGroupMember(IXRInteractionGroup group)
		{
		}

		void IXRGroupMember.OnRegisteringAsNonGroupMember()
		{
		}
	}
}
