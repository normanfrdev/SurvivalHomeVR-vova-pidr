using System.Diagnostics;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Feedback
{
	[AddComponentMenu("XR/Feedback/Simple Haptic Feedback", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback.html")]
	public class SimpleHapticFeedback : MonoBehaviour
	{
		[SerializeField]
		[RequireInterface(typeof(IXRInteractor))]
		private Object m_InteractorSourceObject;

		[SerializeField]
		private HapticImpulsePlayer m_HapticImpulsePlayer;

		[SerializeField]
		private bool m_PlaySelectEntered;

		[SerializeField]
		private HapticImpulseData m_SelectEnteredData;

		[SerializeField]
		private bool m_PlaySelectExited;

		[SerializeField]
		private HapticImpulseData m_SelectExitedData;

		[SerializeField]
		private bool m_PlaySelectCanceled;

		[SerializeField]
		private HapticImpulseData m_SelectCanceledData;

		[SerializeField]
		private bool m_PlayHoverEntered;

		[SerializeField]
		private HapticImpulseData m_HoverEnteredData;

		[SerializeField]
		private bool m_PlayHoverExited;

		[SerializeField]
		private HapticImpulseData m_HoverExitedData;

		[SerializeField]
		private bool m_PlayHoverCanceled;

		[SerializeField]
		private HapticImpulseData m_HoverCanceledData;

		[SerializeField]
		private bool m_AllowHoverHapticsWhileSelecting;

		private readonly UnityObjectReferenceCache<IXRInteractor, Object> m_InteractorSource;

		public HapticImpulsePlayer hapticImpulsePlayer
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

		public HapticImpulseData selectEnteredData
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

		public HapticImpulseData selectExitedData
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

		public HapticImpulseData selectCanceledData
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

		public HapticImpulseData hoverEnteredData
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

		public HapticImpulseData hoverExitedData
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

		public HapticImpulseData hoverCanceledData
		{
			get
			{
				return null;
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

		protected bool SendHapticImpulse(HapticImpulseData data)
		{
			return false;
		}

		protected bool SendHapticImpulse(float amplitude, float duration, float frequency)
		{
			return false;
		}

		private void CreateHapticImpulsePlayer()
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

		private bool IsHoverHapticsAllowed(IXRInteractor interactor, IXRInteractable interactable)
		{
			return false;
		}

		private static bool IsSelecting(IXRInteractor interactor, IXRInteractable interactable)
		{
			return false;
		}
	}
}
