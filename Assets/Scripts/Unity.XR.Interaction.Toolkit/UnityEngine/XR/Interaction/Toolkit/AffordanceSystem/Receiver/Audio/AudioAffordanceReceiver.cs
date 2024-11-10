using System;
using Unity.XR.CoreUtils.Bindings;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Audio;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Audio
{
	[RequireComponent(typeof(AudioSource))]
	[AddComponentMenu("Affordance System/Receiver/Audio/Audio Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Audio.AudioAffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class AudioAffordanceReceiver : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Affordance state provider component to subscribe to.")]
		private BaseAffordanceStateProvider m_AffordanceStateProvider;

		[SerializeField]
		[Tooltip("Audio Affordance Theme datum property used to map affordance state to a Audio affordance value. Can store an asset or a serialized value.")]
		private AudioAffordanceThemeDatumProperty m_AffordanceThemeDatum;

		[SerializeField]
		[Tooltip("Audio Source where the audio clip will be played.")]
		private AudioSource m_AudioSource;

		private readonly BindingsGroup m_BindingsGroup;

		private byte m_LastAffordanceStateIndex;

		public BaseAffordanceStateProvider affordanceStateProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AudioAffordanceThemeDatumProperty affordanceThemeDatum
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AudioSource audioSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void OnValidate()
		{
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private void LogIfMissingAffordanceStates(AudioAffordanceTheme theme)
		{
		}

		private void OnAffordanceStateUpdated(AffordanceStateData affordanceStateData)
		{
		}

		private void PlayAudioClip(AudioClip clipToPlay)
		{
		}
	}
}
