using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Obsolete("XRBaseControllerInteractor has been deprecated in version 3.0.0. It has been renamed to XRBaseInputInteractor. (UnityUpgradable) -> UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor")]
	public abstract class XRBaseControllerInteractor : XRBaseInteractor, IXRActivateInteractor, IXRInteractor
	{
		[Obsolete("XRBaseControllerInteractor.InputTriggerType has been deprecated in version 3.0.0. It has been moved to XRBaseInputInteractor.InputTriggerType.")]
		public enum InputTriggerType
		{
			State = 0,
			StateChange = 1,
			Toggle = 2,
			Sticky = 3
		}

		[SerializeField]
		private InputTriggerType m_SelectActionTrigger;

		[SerializeField]
		private bool m_HideControllerOnSelect;

		[SerializeField]
		private bool m_AllowHoveredActivate;

		[SerializeField]
		private TargetPriorityMode m_TargetPriorityMode;

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

		private bool m_AllowActivate;

		private XRBaseController m_Controller;

		private readonly LinkedPool<ActivateEventArgs> m_ActivateEventArgs;

		private readonly LinkedPool<DeactivateEventArgs> m_DeactivateEventArgs;

		private static readonly List<IXRActivateInteractable> s_ActivateTargets;

		private bool m_ToggleSelectActive;

		private bool m_ToggleSelectDeactivatedThisFrame;

		private bool m_WaitingForSelectDeactivate;

		private AudioSource m_EffectsAudioSource;

		[Obsolete("playAudioClipOnSelectEnter has been deprecated. Use playAudioClipOnSelectEntered instead. (UnityUpgradable) -> playAudioClipOnSelectEntered", true)]
		public bool playAudioClipOnSelectEnter => false;

		[Obsolete("audioClipForOnSelectEnter has been deprecated. Use audioClipForOnSelectEntered instead. (UnityUpgradable) -> audioClipForOnSelectEntered", true)]
		public AudioClip audioClipForOnSelectEnter => null;

		[Obsolete("AudioClipForOnSelectEnter has been deprecated. Use audioClipForOnSelectEntered instead. (UnityUpgradable) -> audioClipForOnSelectEntered", true)]
		public AudioClip AudioClipForOnSelectEnter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnSelectExit has been deprecated. Use playAudioClipOnSelectExited instead. (UnityUpgradable) -> playAudioClipOnSelectExited", true)]
		public bool playAudioClipOnSelectExit => false;

		[Obsolete("audioClipForOnSelectExit has been deprecated. Use audioClipForOnSelectExited instead. (UnityUpgradable) -> audioClipForOnSelectExited", true)]
		public AudioClip audioClipForOnSelectExit => null;

		[Obsolete("AudioClipForOnSelectExit has been deprecated. Use audioClipForOnSelectExited instead. (UnityUpgradable) -> audioClipForOnSelectExited", true)]
		public AudioClip AudioClipForOnSelectExit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnHoverEnter has been deprecated. Use playAudioClipOnHoverEntered instead. (UnityUpgradable) -> playAudioClipOnHoverEntered", true)]
		public bool playAudioClipOnHoverEnter => false;

		[Obsolete("audioClipForOnHoverEnter has been deprecated. Use audioClipForOnHoverEntered instead. (UnityUpgradable) -> audioClipForOnHoverEntered", true)]
		public AudioClip audioClipForOnHoverEnter => null;

		[Obsolete("AudioClipForOnHoverEnter has been deprecated. Use audioClipForOnHoverEntered instead. (UnityUpgradable) -> audioClipForOnHoverEntered", true)]
		public AudioClip AudioClipForOnHoverEnter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playAudioClipOnHoverExit has been deprecated. Use playAudioClipOnHoverExited instead. (UnityUpgradable) -> playAudioClipOnHoverExited", true)]
		public bool playAudioClipOnHoverExit => false;

		[Obsolete("audioClipForOnHoverExit has been deprecated. Use audioClipForOnHoverExited instead. (UnityUpgradable) -> audioClipForOnHoverExited", true)]
		public AudioClip audioClipForOnHoverExit => null;

		[Obsolete("AudioClipForOnHoverExit has been deprecated. Use audioClipForOnHoverExited instead. (UnityUpgradable) -> audioClipForOnHoverExited", true)]
		public AudioClip AudioClipForOnHoverExit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("playHapticsOnSelectEnter has been deprecated. Use playHapticsOnSelectEntered instead. (UnityUpgradable) -> playHapticsOnSelectEntered", true)]
		public bool playHapticsOnSelectEnter => false;

		[Obsolete("playHapticsOnSelectExit has been deprecated. Use playHapticsOnSelectExited instead. (UnityUpgradable) -> playHapticsOnSelectExited", true)]
		public bool playHapticsOnSelectExit => false;

		[Obsolete("playHapticsOnHoverEnter has been deprecated. Use playHapticsOnHoverEntered instead. (UnityUpgradable) -> playHapticsOnHoverEntered", true)]
		public bool playHapticsOnHoverEnter => false;

		[Obsolete("validTargets has been deprecated. Use a property of type List<IXRInteractable> instead.", true)]
		protected virtual List<XRBaseInteractable> validTargets
		{
			[CompilerGenerated]
			get
			{
				return null;
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

		public override bool isSelectActive => false;

		protected virtual bool isUISelectActive => false;

		protected Vector2 uiScrollValue => default(Vector2);

		public virtual bool shouldActivate => false;

		public virtual bool shouldDeactivate => false;

		private static ActivateEventArgs CreateActivateEventArgs()
		{
			return null;
		}

		private static DeactivateEventArgs CreateDeactivateEventArgs()
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private protected virtual void OnXRControllerChanged()
		{
		}

		public override void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public override void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
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

		protected override void OnHoverEntering(HoverEnterEventArgs args)
		{
		}

		protected override void OnHoverExiting(HoverExitEventArgs args)
		{
		}

		private bool CanPlayHoverAudio(IXRHoverInteractable hoveredInteractable)
		{
			return false;
		}

		private bool CanPlayHoverHaptics(IXRHoverInteractable hoveredInteractable)
		{
			return false;
		}

		public bool SendHapticImpulse(float amplitude, float duration)
		{
			return false;
		}

		protected virtual void PlayAudio(AudioClip audioClip)
		{
		}

		private void CreateEffectsAudioSource()
		{
		}

		private void HandleSelecting()
		{
		}

		private void HandleDeselecting()
		{
		}

		Transform IXRInteractor.get_transform()
		{
			return null;
		}
	}
}
