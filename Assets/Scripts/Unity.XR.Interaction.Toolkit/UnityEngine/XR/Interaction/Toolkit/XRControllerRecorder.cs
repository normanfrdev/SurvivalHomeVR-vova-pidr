using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/Debug/XR Controller Recorder", 11)]
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(-30000)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.XRControllerRecorder.html")]
	public class XRControllerRecorder : MonoBehaviour
	{
		private class ButtonBypass : IXRInputButtonReader, IXRInputValueReader<float>, IXRInputValueReader
		{
			public InteractionState state
			{
				[CompilerGenerated]
				get
				{
					return default(InteractionState);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool ReadIsPerformed()
			{
				return false;
			}

			public bool ReadWasPerformedThisFrame()
			{
				return false;
			}

			public bool ReadWasCompletedThisFrame()
			{
				return false;
			}

			public float ReadValue()
			{
				return 0f;
			}

			public bool TryReadValue(out float value)
			{
				value = default(float);
				return false;
			}
		}

		private class ValueBypass<TValue> : IXRInputValueReader<TValue>, IXRInputValueReader where TValue : struct
		{
			public TValue state
			{
				[CompilerGenerated]
				get
				{
					return default(TValue);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public TValue ReadValue()
			{
				return default(TValue);
			}

			public bool TryReadValue(out TValue value)
			{
				value = default(TValue);
				return false;
			}
		}

		[Header("Input Recording/Playback")]
		[SerializeField]
		[Tooltip("Controls whether this recording will start playing when the component's Awake() method is called.")]
		private bool m_PlayOnStart;

		[SerializeField]
		[Tooltip("Controller Recording asset for recording and playback of controller events.")]
		private XRControllerRecording m_Recording;

		[SerializeField]
		[Tooltip("Interactor whose input will be recorded and played back.")]
		[RequireInterface(typeof(IXRInteractor))]
		private Object m_InteractorObject;

		[SerializeField]
		[Tooltip("If true, every frame of the recording must be visited even if a larger time period has passed.")]
		private bool m_VisitEachFrame;

		private double m_CurrentTime;

		private readonly UnityObjectReferenceCache<IXRInteractor, Object> m_Interactor;

		private bool m_IsRecording;

		private bool m_IsPlaying;

		private double m_LastPlaybackTime;

		private int m_LastFrameIdx;

		private bool m_PrevEnableInputActions;

		private bool m_PrevEnableInputTracking;

		private IXRInputButtonReader m_PrevSelectBypass;

		private IXRInputButtonReader m_PrevActivateBypass;

		private IXRInputButtonReader m_PrevUIPressBypass;

		private IXRInputValueReader<Vector2> m_PrevUIScrollBypass;

		private readonly ButtonBypass m_SelectBypass;

		private readonly ButtonBypass m_ActivateBypass;

		private readonly ButtonBypass m_UIPressBypass;

		private readonly ValueBypass<Vector2> m_UIScrollBypass;

		[SerializeField]
		[Tooltip("(Deprecated) XR Controller whose output will be recorded and played back.")]
		[Obsolete("m_XRController has been deprecated in version 3.0.0.")]
		private XRBaseController m_XRController;

		public bool playOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public XRControllerRecording recording
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool visitEachFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isRecording
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isPlaying
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public double currentTime => 0.0;

		public double duration => 0.0;

		protected float recordingStartTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Obsolete("xrController has been deprecated in version 3.0.0. Use interactor to allow the recorder to read and playback button input instead.")]
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

		protected void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected void OnDestroy()
		{
		}

		public IXRInteractor GetInteractor()
		{
			return null;
		}

		public void SetInteractor(IXRInteractor interactor)
		{
		}

		public void ResetPlayback()
		{
		}

		private void StartPlaying()
		{
		}

		private void StopPlaying()
		{
		}

		private void UpdatePlaybackTime(double playbackTime)
		{
		}

		public virtual bool GetControllerState(out XRControllerState controllerState)
		{
			controllerState = null;
			return false;
		}
	}
}
