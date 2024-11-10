using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Datums;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State
{
	[AddComponentMenu("Affordance System/XR Interactable Affordance State Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State.XRInteractableAffordanceStateProvider.html")]
	[DisallowMultipleComponent]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class XRInteractableAffordanceStateProvider : BaseAffordanceStateProvider
	{
		public enum SelectClickAnimationMode
		{
			None = 0,
			SelectEntered = 1,
			SelectExited = 2
		}

		public enum ActivateClickAnimationMode
		{
			None = 0,
			Activated = 1,
			Deactivated = 2
		}

		[CompilerGenerated]
		private sealed class _003CClickAnimation_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public XRInteractableAffordanceStateProvider _003C_003E4__this;

			public byte targetStateIndex;

			public Action onComplete;

			private float _003CelapsedTime_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CClickAnimation_003Ed__91(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CHoveredPriorityRoutine_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XRInteractableAffordanceStateProvider _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CHoveredPriorityRoutine_003Ed__93(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		[RequireInterface(typeof(IXRInteractable))]
		[Tooltip("The interactable component that drives the affordance states. If null, Unity will try and find an interactable component attached.")]
		private Object m_InteractableSource;

		[Header("Event Constraints")]
		[SerializeField]
		[Tooltip("When hover events are registered and this is true, the state will fallback to idle or disabled.")]
		private bool m_IgnoreHoverEvents;

		[SerializeField]
		[Tooltip("When this is true, the state will fallback to hover if the later is not ignored. When this is false, this provider will check if the Interactable Source has priority for selection when hovered, and update its state accordingly.")]
		private bool m_IgnoreHoverPriorityEvents;

		[SerializeField]
		[Tooltip("When focus events are registered and this is true, the state will fallback to idle or disabled.")]
		private bool m_IgnoreFocusEvents;

		[SerializeField]
		[Tooltip("When select events are registered and this is true, the state will fallback to idle or disabled. Note this will not affect click animations which can be disabled separately.")]
		private bool m_IgnoreSelectEvents;

		[SerializeField]
		[Tooltip("When activate events are registered and this is true, the state will fallback to idle or disabled.Note this will not affect click animations which can be disabled separately.")]
		private bool m_IgnoreActivateEvents;

		[Header("Click Animation Config")]
		[SerializeField]
		[Tooltip("Condition to trigger click animation for Selected interaction events.")]
		private SelectClickAnimationMode m_SelectClickAnimationMode;

		[SerializeField]
		[Tooltip("Condition to trigger click animation for activated interaction events.")]
		private ActivateClickAnimationMode m_ActivateClickAnimationMode;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Duration of click animations for selected and activated events.")]
		private float m_ClickAnimationDuration;

		[SerializeField]
		[Tooltip("Animation curve reference for click animation events. Select the More menu (⋮) to choose between a direct reference and a reusable scriptable object animation curve datum.")]
		private AnimationCurveDatumProperty m_ClickAnimationCurve;

		private IXRInteractable m_Interactable;

		private IXRHoverInteractable m_HoverInteractable;

		private IXRSelectInteractable m_SelectInteractable;

		private IXRFocusInteractable m_FocusInteractable;

		private IXRActivateInteractable m_ActivateInteractable;

		private IXRInteractionStrengthInteractable m_InteractionStrengthInteractable;

		private Coroutine m_SelectedClickAnimation;

		private Coroutine m_ActivatedClickAnimation;

		private Coroutine m_HoveredPriorityRoutine;

		private bool m_IsBoundToInteractionEvents;

		private bool m_IsActivated;

		private bool m_IsRegistered;

		private bool m_IsHoveredPriority;

		private bool m_HasHoverInteractable;

		private bool m_HasSelectInteractable;

		private bool m_HasInteractionStrengthInteractable;

		private int m_HoveringPriorityInteractorCount;

		public Object interactableSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ignoreHoverEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreHoverPriorityEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreFocusEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreSelectEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreActivateEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SelectClickAnimationMode selectClickAnimationMode
		{
			get
			{
				return default(SelectClickAnimationMode);
			}
			set
			{
			}
		}

		public ActivateClickAnimationMode activateClickAnimationMode
		{
			get
			{
				return default(ActivateClickAnimationMode);
			}
			set
			{
			}
		}

		public float clickAnimationDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurveDatumProperty clickAnimationCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual bool isHovered => false;

		protected virtual bool isSelected => false;

		protected virtual bool isFocused => false;

		protected virtual bool isActivated => false;

		protected virtual bool isRegistered => false;

		protected void Awake()
		{
		}

		protected override void OnValidate()
		{
		}

		public bool SetBoundInteractionReceiver(IXRInteractable receiver)
		{
			return false;
		}

		protected virtual void OnRegistered(InteractableRegisteredEventArgs args)
		{
		}

		protected virtual void OnUnregistered(InteractableUnregisteredEventArgs args)
		{
		}

		protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args)
		{
		}

		protected virtual void OnLastHoverExited(HoverExitEventArgs args)
		{
		}

		protected virtual void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		protected virtual void OnHoverExited(HoverExitEventArgs args)
		{
		}

		private void StopHoveredPriorityRoutine()
		{
		}

		protected virtual void OnFirstSelectEntered(SelectEnterEventArgs args)
		{
		}

		protected virtual void OnLastSelectExited(SelectExitEventArgs args)
		{
		}

		protected virtual void OnFirstFocusEntered(FocusEnterEventArgs args)
		{
		}

		protected virtual void OnLastFocusExited(FocusExitEventArgs args)
		{
		}

		protected virtual void OnActivatedEvent(ActivateEventArgs args)
		{
		}

		protected virtual void OnDeactivatedEvent(DeactivateEventArgs args)
		{
		}

		protected virtual void OnLargestInteractionStrengthChanged(float value)
		{
		}

		protected virtual void SelectedClickBehavior()
		{
		}

		protected virtual void ActivatedClickBehavior()
		{
		}

		private void StopActivatedCoroutine()
		{
		}

		private void StopSelectedCoroutine()
		{
		}

		private void StopAllClickAnimations()
		{
		}

		[IteratorStateMachine(typeof(_003CClickAnimation_003Ed__91))]
		protected virtual IEnumerator ClickAnimation(byte targetStateIndex, float duration, Action onComplete = null)
		{
			return null;
		}

		protected virtual AffordanceStateData GenerateNewAffordanceState()
		{
			return default(AffordanceStateData);
		}

		[IteratorStateMachine(typeof(_003CHoveredPriorityRoutine_003Ed__93))]
		private IEnumerator HoveredPriorityRoutine()
		{
			return null;
		}

		protected override void BindToProviders()
		{
		}

		public void RefreshState()
		{
		}

		protected override void ClearBindings()
		{
		}
	}
}
