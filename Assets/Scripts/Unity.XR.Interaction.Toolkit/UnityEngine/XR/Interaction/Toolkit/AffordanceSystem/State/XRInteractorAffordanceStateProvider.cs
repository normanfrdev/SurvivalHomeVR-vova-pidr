using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Datums;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State
{
	[AddComponentMenu("Affordance System/XR Interactor Affordance State Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State.XRInteractorAffordanceStateProvider.html")]
	[DisallowMultipleComponent]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class XRInteractorAffordanceStateProvider : BaseAffordanceStateProvider
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
		private sealed class _003CClickAnimation_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public XRInteractorAffordanceStateProvider _003C_003E4__this;

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
			public _003CClickAnimation_003Ed__98(int _003C_003E1__state)
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
		private sealed class _003CUIUpdateCheckCoroutine_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XRInteractorAffordanceStateProvider _003C_003E4__this;

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
			public _003CUIUpdateCheckCoroutine_003Ed__99(int _003C_003E1__state)
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
		[RequireInterface(typeof(IXRInteractor))]
		[Tooltip("The interactor component that drives the affordance states. If null, Unity will try and find an interactor component attached.")]
		private Object m_InteractorSource;

		[Header("Event Constraints")]
		[SerializeField]
		[Tooltip("When hover events are registered and this is true, the state will fallback to idle or disabled.")]
		private bool m_IgnoreHoverEvents;

		[SerializeField]
		[Tooltip("When select events are registered and this is true, the state will fallback to idle or disabled. \nNote: Click animations must be disabled separately.")]
		private bool m_IgnoreSelectEvents;

		[SerializeField]
		[Tooltip("When activate events are registered and this is true, the state will fallback to idle or disabled.\nNote: Click animations must be disabled separately.")]
		private bool m_IgnoreActivateEvents;

		[SerializeField]
		[Tooltip("With the XR Ray Interactor it is possible to trigger select events from the ray interactor overlapping with a canvas.")]
		private bool m_IgnoreUGUIHover;

		[SerializeField]
		[Tooltip("With the XR Ray Interactor it is possible to trigger select events from the ray interactor overlapping with a canvas and triggering the select input.")]
		private bool m_IgnoreUGUISelect;

		[SerializeField]
		[Tooltip("This option will prevent Hover, Select, and Activate events from being triggered when they come from the XR Interaction Manager. UGUI hover and select events will still come through.")]
		private bool m_IgnoreXRInteractionEvents;

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
		[Tooltip("Animation curve reference for click animation events. Select the More menu (⋮) to choose between a direct reference and a reusable asset.")]
		private AnimationCurveDatumProperty m_ClickAnimationCurve;

		private IXRInteractor m_Interactor;

		private IXRHoverInteractor m_HoverInteractor;

		private IXRSelectInteractor m_SelectInteractor;

		private IXRInteractionStrengthInteractor m_InteractionStrengthInteractor;

		private XRRayInteractor m_RayInteractor;

		private ICurveInteractionDataProvider m_CurveInteractionDataProvider;

		private bool m_IsBoundToInteractionEvents;

		private bool m_HasRayInteractor;

		private bool m_HasCurveInteractionDataProvider;

		private bool m_HasHoverInteractor;

		private bool m_HasSelectInteractor;

		private bool m_HasInteractionStrengthInteractor;

		private bool m_IsIXRInteractor;

		private Coroutine m_SelectedClickAnimation;

		private Coroutine m_ActivatedClickAnimation;

		private bool m_IsActivated;

		private bool m_IsRegistered;

		private readonly HashSet<IXRActivateInteractable> m_BoundActivateInteractable;

		private bool m_UIHovering;

		private bool m_UISelecting;

		private Coroutine m_UGUIUpdateCoroutine;

		public Object interactorSource
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

		public bool ignoreUGUIHover
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreUGUISelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreXRInteractionEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual bool hasXRHover => false;

		protected virtual bool hasUIHover => false;

		protected virtual bool hasXRSelection => false;

		protected virtual bool hasUISelection => false;

		protected virtual bool isActivated => false;

		protected virtual bool isRegistered => false;

		protected virtual bool isBlockedByGroup => false;

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

		protected void Awake()
		{
		}

		public bool SetBoundInteractionReceiver(IXRInteractor interactor)
		{
			return false;
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

		protected virtual AffordanceStateData GenerateNewAffordanceState()
		{
			return default(AffordanceStateData);
		}

		protected virtual void OnRegistered(InteractorRegisteredEventArgs args)
		{
		}

		protected virtual void OnUnregistered(InteractorUnregisteredEventArgs args)
		{
		}

		protected virtual void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		protected virtual void OnHoverExited(HoverExitEventArgs args)
		{
		}

		protected virtual void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		protected virtual void OnSelectExited(SelectExitEventArgs args)
		{
		}

		protected virtual void OnLargestInteractionStrengthChanged(float value)
		{
		}

		private void OnActivated(ActivateEventArgs args)
		{
		}

		private void OnDeactivated(DeactivateEventArgs args)
		{
		}

		protected virtual void SelectedClickBehavior()
		{
		}

		protected virtual void ActivatedClickBehavior()
		{
		}

		[IteratorStateMachine(typeof(_003CClickAnimation_003Ed__98))]
		protected virtual IEnumerator ClickAnimation(byte targetStateIndex, float duration, Action onComplete = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUIUpdateCheckCoroutine_003Ed__99))]
		private IEnumerator UIUpdateCheckCoroutine()
		{
			return null;
		}
	}
}
