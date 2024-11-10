using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Feedback;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public abstract class XRBaseInputInteractor : XRBaseInteractor, IXRActivateInteractor, IXRInteractor
	{
		public enum InputTriggerType
		{
			State = 0,
			StateChange = 1,
			Toggle = 2,
			Sticky = 3
		}

		public class LogicalInputState
		{
			private InputTriggerType m_Mode;

			private bool m_HasSelection;

			private float m_TimeAtPerformed;

			private float m_TimeAtCompleted;

			private bool m_ToggleActive;

			private bool m_ToggleDeactivatedThisFrame;

			private bool m_WaitingForDeactivate;

			public bool active
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

			public InputTriggerType mode
			{
				get
				{
					return default(InputTriggerType);
				}
				set
				{
				}
			}

			public bool isPerformed
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

			public bool wasPerformedThisFrame
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

			public bool wasCompletedThisFrame
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

			[Obsolete("wasUnperformedThisFrame has been deprecated in version 3.0.0-pre.2. It has been renamed to wasCompletedThisFrame. (UnityUpgradable) -> wasCompletedThisFrame")]
			public bool wasUnperformedThisFrame => false;

			internal void UpdateInput(bool performed, bool performedThisFrame, bool completedThisFrame, bool hasSelection)
			{
			}

			private void UpdateInput(bool performed, bool performedThisFrame, bool completedThisFrame, bool hasSelection, float realtime)
			{
			}

			internal void UpdateHasSelection(bool hasSelection)
			{
			}

			private void Refresh()
			{
			}
		}

		[Obsolete("InputCompatibilityMode introduced in version 3.0.0 is marked for removal. This is only used for backwards compatibility and will be eventually removed in a future version.")]
		public enum InputCompatibilityMode
		{
			Automatic = 0,
			ForceDeprecatedInput = 1,
			ForceInputReaders = 2
		}

		[SerializeField]
		private XRInputButtonReader m_SelectInput;

		[SerializeField]
		private XRInputButtonReader m_ActivateInput;

		[SerializeField]
		private InputTriggerType m_SelectActionTrigger;

		[SerializeField]
		private bool m_AllowHoveredActivate;

		[SerializeField]
		private TargetPriorityMode m_TargetPriorityMode;

		private bool m_AllowActivate;

		private readonly LinkedPool<ActivateEventArgs> m_ActivateEventArgs;

		private readonly LinkedPool<DeactivateEventArgs> m_DeactivateEventArgs;

		private static readonly List<IXRActivateInteractable> s_ActivateTargets;

		private readonly LogicalInputState m_LogicalSelectState;

		private readonly LogicalInputState m_LogicalActivateState;

		private SimpleAudioFeedback m_AudioFeedback;

		private SimpleHapticFeedback m_HapticFeedback;

		private AudioSource m_AudioSource;

		private HapticImpulsePlayer m_HapticImpulsePlayer;

		[SerializeField]
		private bool m_HideControllerOnSelect;

		[SerializeField]
		[Obsolete("m_InputCompatibilityMode introduced in version 3.0.0 is marked for removal. This is only used for backwards compatibility and will be eventually removed in a future version.")]
		private InputCompatibilityMode m_InputCompatibilityMode;

		[Obsolete("m_Controller has been deprecated in version 3.0.0.")]
		private XRBaseController m_Controller;

		private bool m_HasXRController;

		[SerializeField]
		[FormerlySerializedAs("m_PlayAudioClipOnSelectEnter")]
		private bool m_PlayAudioClipOnSelectEntered;

		[SerializeField]
		[FormerlySerializedAs("m_AudioClipForOnSelectEnter")]
		private AudioClip m_AudioClipForOnSelectEntered;

		[SerializeField]
		[FormerlySerializedAs("m_PlayAudioClipOnSelectExit")]
		private bool m_PlayAudioClipOnSelectExited;

		[SerializeField]
		[FormerlySerializedAs("m_AudioClipForOnSelectExit")]
		private AudioClip m_AudioClipForOnSelectExited;

		[SerializeField]
		private bool m_PlayAudioClipOnSelectCanceled;

		[SerializeField]
		private AudioClip m_AudioClipForOnSelectCanceled;

		[SerializeField]
		[FormerlySerializedAs("m_PlayAudioClipOnHoverEnter")]
		private bool m_PlayAudioClipOnHoverEntered;

		[SerializeField]
		[FormerlySerializedAs("m_AudioClipForOnHoverEnter")]
		private AudioClip m_AudioClipForOnHoverEntered;

		[SerializeField]
		[FormerlySerializedAs("m_PlayAudioClipOnHoverExit")]
		private bool m_PlayAudioClipOnHoverExited;

		[SerializeField]
		[FormerlySerializedAs("m_AudioClipForOnHoverExit")]
		private AudioClip m_AudioClipForOnHoverExited;

		[SerializeField]
		private bool m_PlayAudioClipOnHoverCanceled;

		[SerializeField]
		private AudioClip m_AudioClipForOnHoverCanceled;

		[SerializeField]
		private bool m_AllowHoverAudioWhileSelecting;

		[SerializeField]
		[FormerlySerializedAs("m_PlayHapticsOnSelectEnter")]
		private bool m_PlayHapticsOnSelectEntered;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_HapticSelectEnterIntensity;

		[SerializeField]
		private float m_HapticSelectEnterDuration;

		[SerializeField]
		[FormerlySerializedAs("m_PlayHapticsOnSelectExit")]
		private bool m_PlayHapticsOnSelectExited;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_HapticSelectExitIntensity;

		[SerializeField]
		private float m_HapticSelectExitDuration;

		[SerializeField]
		private bool m_PlayHapticsOnSelectCanceled;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_HapticSelectCancelIntensity;

		[SerializeField]
		private float m_HapticSelectCancelDuration;

		[SerializeField]
		[FormerlySerializedAs("m_PlayHapticsOnHoverEnter")]
		private bool m_PlayHapticsOnHoverEntered;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_HapticHoverEnterIntensity;

		[SerializeField]
		private float m_HapticHoverEnterDuration;

		[SerializeField]
		[FormerlySerializedAs("m_PlayHapticsOnHoverExit")]
		private bool m_PlayHapticsOnHoverExited;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_HapticHoverExitIntensity;

		[SerializeField]
		private float m_HapticHoverExitDuration;

		[SerializeField]
		private bool m_PlayHapticsOnHoverCanceled;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_HapticHoverCancelIntensity;

		[SerializeField]
		private float m_HapticHoverCancelDuration;

		[SerializeField]
		private bool m_AllowHoverHapticsWhileSelecting;

		public XRInputButtonReader selectInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputButtonReader activateInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputTriggerType selectActionTrigger
		{
			get
			{
				return default(InputTriggerType);
			}
			set
			{
			}
		}

		public bool allowHoveredActivate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override TargetPriorityMode targetPriorityMode
		{
			get
			{
				return default(TargetPriorityMode);
			}
			set
			{
			}
		}

		public bool allowActivate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool isSelectActive => false;

		public virtual bool shouldActivate => false;

		public virtual bool shouldDeactivate => false;

		public LogicalInputState logicalSelectState => null;

		public LogicalInputState logicalActivateState => null;

		protected List<XRInputButtonReader> buttonReaders
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected List<XRInputValueReader> valueReaders
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Obsolete("hideControllerOnSelect has been deprecated in version 3.0.0.")]
		public bool hideControllerOnSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("inputCompatibilityMode introduced in version 3.0.0 is marked for removal. This is only used for backwards compatibility and will be eventually removed in a future version.")]
		public InputCompatibilityMode inputCompatibilityMode
		{
			get
			{
				return default(InputCompatibilityMode);
			}
			set
			{
			}
		}

		[Obsolete("forceDeprecatedInput introduced in version 3.0.0 is marked for removal. This is only used for backwards compatibility and will be eventually removed in a future version.")]
		public bool forceDeprecatedInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("xrController has been deprecated in version 3.0.0.")]
		public XRBaseController xrController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("isUISelectActive has been deprecated in version 3.0.0. Use a serialized XRInputButtonProvider to read button input instead.")]
		protected virtual bool isUISelectActive => false;

		[Obsolete("uiScrollValue has been deprecated in version 3.0.0. Use a serialized XRInputValueProvider<Vector2> to read scroll input instead.")]
		protected Vector2 uiScrollValue => default(Vector2);

		[Obsolete("playAudioClipOnSelectEntered has been deprecated in version 3.0.0. Use SimpleAudioFeedback.playSelectEntered instead.")]
		public bool playAudioClipOnSelectEntered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("audioClipForOnSelectEntered has been deprecated in version 3.0.0. Use SimpleAudioFeedback.selectEnteredClip instead.")]
		public AudioClip audioClipForOnSelectEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnSelectExited has been deprecated in version 3.0.0. Use SimpleAudioFeedback.playSelectExited instead.")]
		public bool playAudioClipOnSelectExited
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("audioClipForOnSelectExited has been deprecated in version 3.0.0. Use SimpleAudioFeedback.selectExitedClip instead.")]
		public AudioClip audioClipForOnSelectExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnSelectCanceled has been deprecated in version 3.0.0. Use SimpleAudioFeedback.playSelectCanceled instead.")]
		public bool playAudioClipOnSelectCanceled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("audioClipForOnSelectCanceled has been deprecated in version 3.0.0. Use SimpleAudioFeedback.selectCanceledClip instead.")]
		public AudioClip audioClipForOnSelectCanceled
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnHoverEntered has been deprecated in version 3.0.0. Use SimpleAudioFeedback.playHoverEntered instead.")]
		public bool playAudioClipOnHoverEntered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("audioClipForOnHoverEntered has been deprecated in version 3.0.0. Use SimpleAudioFeedback.hoverEnteredClip instead.")]
		public AudioClip audioClipForOnHoverEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnHoverExited has been deprecated in version 3.0.0. Use SimpleAudioFeedback.playHoverExited instead.")]
		public bool playAudioClipOnHoverExited
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("audioClipForOnHoverExited has been deprecated in version 3.0.0. Use SimpleAudioFeedback.hoverExitedClip instead.")]
		public AudioClip audioClipForOnHoverExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnHoverCanceled has been deprecated in version 3.0.0. Use SimpleAudioFeedback.playHoverCanceled instead.")]
		public bool playAudioClipOnHoverCanceled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("audioClipForOnHoverCanceled has been deprecated in version 3.0.0. Use SimpleAudioFeedback.hoverCanceledClip instead.")]
		public AudioClip audioClipForOnHoverCanceled
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("allowHoverAudioWhileSelecting has been deprecated in version 3.0.0. Use SimpleAudioFeedback.allowHoverAudioWhileSelecting instead.")]
		public bool allowHoverAudioWhileSelecting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("playHapticsOnSelectEntered has been deprecated in version 3.0.0. Use SimpleHapticFeedback.playSelectEntered instead.")]
		public bool playHapticsOnSelectEntered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("hapticSelectEnterIntensity has been deprecated in version 3.0.0. Use SimpleHapticFeedback.selectEnteredData.amplitude instead.")]
		public float hapticSelectEnterIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("hapticSelectEnterDuration has been deprecated in version 3.0.0. Use SimpleHapticFeedback.selectEnteredData.duration instead.")]
		public float hapticSelectEnterDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("playHapticsOnSelectExited has been deprecated in version 3.0.0. Use SimpleHapticFeedback.playSelectExited instead.")]
		public bool playHapticsOnSelectExited
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("hapticSelectExitIntensity has been deprecated in version 3.0.0. Use SimpleHapticFeedback.selectExitedData.amplitude instead.")]
		public float hapticSelectExitIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("hapticSelectExitDuration has been deprecated in version 3.0.0. Use SimpleHapticFeedback.selectExitedData.duration instead.")]
		public float hapticSelectExitDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("playHapticsOnSelectCanceled has been deprecated in version 3.0.0. Use SimpleHapticFeedback.playSelectCanceled instead.")]
		public bool playHapticsOnSelectCanceled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("hapticSelectCancelIntensity has been deprecated in version 3.0.0. Use SimpleHapticFeedback.selectCanceledData.amplitude instead.")]
		public float hapticSelectCancelIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("hapticSelectCancelDuration has been deprecated in version 3.0.0. Use SimpleHapticFeedback.selectCanceledData.duration instead.")]
		public float hapticSelectCancelDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("playHapticsOnHoverEntered has been deprecated in version 3.0.0. Use SimpleHapticFeedback.playHoverEntered instead.")]
		public bool playHapticsOnHoverEntered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("hapticHoverEnterIntensity has been deprecated in version 3.0.0. Use SimpleHapticFeedback.hoverEnteredData.amplitude instead.")]
		public float hapticHoverEnterIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("hapticHoverEnterDuration has been deprecated in version 3.0.0. Use SimpleHapticFeedback.hoverEnteredData.duration instead.")]
		public float hapticHoverEnterDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("playHapticsOnHoverExited has been deprecated in version 3.0.0. Use SimpleHapticFeedback.playHoverExited instead.")]
		public bool playHapticsOnHoverExited
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("hapticHoverExitIntensity has been deprecated in version 3.0.0. Use SimpleHapticFeedback.hoverExitedData.amplitude instead.")]
		public float hapticHoverExitIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("hapticHoverExitDuration has been deprecated in version 3.0.0. Use SimpleHapticFeedback.hoverExitedData.duration instead.")]
		public float hapticHoverExitDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("playHapticsOnHoverCanceled has been deprecated in version 3.0.0. Use SimpleHapticFeedback.playHoverCanceled instead.")]
		public bool playHapticsOnHoverCanceled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("hapticHoverCancelIntensity has been deprecated in version 3.0.0. Use SimpleHapticFeedback.hoverCanceledData.amplitude instead.")]
		public float hapticHoverCancelIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("hapticHoverCancelDuration has been deprecated in version 3.0.0. Use SimpleHapticFeedback.hoverCanceledData.duration instead.")]
		public float hapticHoverCancelDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("allowHoverHapticsWhileSelecting has been deprecated in version 3.0.0. Use SimpleHapticFeedback.allowHoverHapticsWhileSelecting instead.")]
		public bool allowHoverHapticsWhileSelecting
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

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public override void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected void SetInputProperty(ref XRInputButtonReader property, XRInputButtonReader value)
		{
		}

		protected void SetInputProperty<TValue>(ref XRInputValueReader<TValue> property, XRInputValueReader<TValue> value) where TValue : struct
		{
		}

		private void SendActivateEvent(List<IXRActivateInteractable> targets)
		{
		}

		private void SendDeactivateEvent(List<IXRActivateInteractable> targets)
		{
		}

		public virtual void GetActivateTargets(List<IXRActivateInteractable> targets)
		{
		}

		protected override void OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectExiting(SelectExitEventArgs args)
		{
		}

		public bool SendHapticImpulse(float amplitude, float duration)
		{
			return false;
		}

		protected virtual void PlayAudio(AudioClip audioClip)
		{
		}

		private void GetOrCreateAudioSource()
		{
		}

		private void GetOrCreateHapticImpulsePlayer()
		{
		}

		private void GetOrCreateAndMigrateAudioFeedback()
		{
		}

		private void GetOrCreateAndMigrateHapticFeedback()
		{
		}

		[Obsolete("OnXRControllerChanged has been deprecated in version 3.0.0.")]
		private protected virtual void OnXRControllerChanged()
		{
		}

		private void WarnMixedInputConfiguration()
		{
		}

		[Obsolete("CreateEffectsAudioSource has been deprecated in version 3.0.0.")]
		private void CreateEffectsAudioSource()
		{
		}

		[Obsolete("CanPlayHoverAudio has been deprecated in version 3.0.0.")]
		private bool CanPlayHoverAudio(IXRHoverInteractable hoveredInteractable)
		{
			return false;
		}

		[Obsolete("CanPlayHoverHaptics has been deprecated in version 3.0.0.")]
		private bool CanPlayHoverHaptics(IXRHoverInteractable hoveredInteractable)
		{
			return false;
		}

		[Obsolete("HandleSelecting has been deprecated in version 3.0.0.")]
		private void HandleSelecting()
		{
		}

		[Obsolete("HandleDeselecting has been deprecated in version 3.0.0.")]
		private void HandleDeselecting()
		{
		}

		protected override void OnHoverEntering(HoverEnterEventArgs args)
		{
		}

		protected override void OnHoverExiting(HoverExitEventArgs args)
		{
		}

		private static ActivateEventArgs CreateActivateEventArgs()
		{
			return null;
		}

		private static DeactivateEventArgs CreateDeactivateEventArgs()
		{
			return null;
		}

		Transform IXRInteractor.get_transform()
		{
			return null;
		}
	}
}
