using System.Diagnostics;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Feedback
{
	[AddComponentMenu("XR/Feedback/Simple Audio Feedback", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback.html")]
	public class SimpleAudioFeedback : MonoBehaviour
	{
		[SerializeField]
		[RequireInterface(typeof(IXRInteractor))]
		private Object m_InteractorSourceObject;

		[SerializeField]
		private AudioSource m_AudioSource;

		[SerializeField]
		private bool m_PlaySelectEntered;

		[SerializeField]
		private AudioClip m_SelectEnteredClip;

		[SerializeField]
		private bool m_PlaySelectExited;

		[SerializeField]
		private AudioClip m_SelectExitedClip;

		[SerializeField]
		private bool m_PlaySelectCanceled;

		[SerializeField]
		private AudioClip m_SelectCanceledClip;

		[SerializeField]
		private bool m_PlayHoverEntered;

		[SerializeField]
		private AudioClip m_HoverEnteredClip;

		[SerializeField]
		private bool m_PlayHoverExited;

		[SerializeField]
		private AudioClip m_HoverExitedClip;

		[SerializeField]
		private bool m_PlayHoverCanceled;

		[SerializeField]
		private AudioClip m_HoverCanceledClip;

		[SerializeField]
		private bool m_AllowHoverAudioWhileSelecting;

		private readonly UnityObjectReferenceCache<IXRInteractor, Object> m_InteractorSource;

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

		public bool playSelectEntered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioClip selectEnteredClip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool playSelectExited
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioClip selectExitedClip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool playSelectCanceled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioClip selectCanceledClip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool playHoverEntered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioClip hoverEnteredClip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool playHoverExited
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioClip hoverExitedClip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool playHoverCanceled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioClip hoverCanceledClip
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

		[Conditional("UNITY_EDITOR")]
		protected void Reset()
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

		public IXRInteractor GetInteractorSource()
		{
			return null;
		}

		public void SetInteractorSource(IXRInteractor interactor)
		{
		}

		protected void PlayAudio(AudioClip clip)
		{
		}

		private void CreateAudioSource()
		{
		}

		private void Subscribe(IXRInteractor interactor)
		{
		}

		private void Unsubscribe(IXRInteractor interactor)
		{
		}

		private void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		private void OnSelectExited(SelectExitEventArgs args)
		{
		}

		private void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		private void OnHoverExited(HoverExitEventArgs args)
		{
		}

		private bool IsHoverAudioAllowed(IXRInteractor interactor, IXRInteractable interactable)
		{
			return false;
		}

		private static bool IsSelecting(IXRInteractor interactor, IXRInteractable interactable)
		{
			return false;
		}
	}
}
