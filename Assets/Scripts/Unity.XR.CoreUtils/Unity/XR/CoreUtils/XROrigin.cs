using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR;

namespace Unity.XR.CoreUtils
{
	[AddComponentMenu("XR/XR Origin")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.core-utils@2.0/api/Unity.XR.CoreUtils.XROrigin.html")]
	public class XROrigin : MonoBehaviour
	{
		public enum TrackingOriginMode
		{
			NotSpecified = 0,
			Device = 1,
			Floor = 2
		}

		[CompilerGenerated]
		private sealed class _003CRepeatInitializeCamera_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XROrigin _003C_003E4__this;

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
			public _003CRepeatInitializeCamera_003Ed__48(int _003C_003E1__state)
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
		[Tooltip("The Camera to associate with the XR device.")]
		private Camera m_Camera;

		private const float k_DefaultCameraYOffset = 1.1176f;

		[SerializeField]
		[FormerlySerializedAs("m_RigBaseGameObject")]
		private GameObject m_OriginBaseGameObject;

		[SerializeField]
		private GameObject m_CameraFloorOffsetObject;

		[SerializeField]
		private TrackingOriginMode m_RequestedTrackingOriginMode;

		[SerializeField]
		private float m_CameraYOffset;

		private static readonly List<XRInputSubsystem> s_InputSubsystems;

		private bool m_CameraInitialized;

		private bool m_CameraInitializing;

		public Camera Camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform TrackablesParent
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

		public GameObject Origin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject CameraFloorOffsetObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TrackingOriginMode RequestedTrackingOriginMode
		{
			get
			{
				return default(TrackingOriginMode);
			}
			set
			{
			}
		}

		public float CameraYOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TrackingOriginModeFlags CurrentTrackingOriginMode
		{
			[CompilerGenerated]
			get
			{
				return default(TrackingOriginModeFlags);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 OriginInCameraSpacePos => default(Vector3);

		public Vector3 CameraInOriginSpacePos => default(Vector3);

		public float CameraInOriginSpaceHeight => 0f;

		public event Action<ARTrackablesParentTransformChangedEventArgs> TrackablesParentTransformChanged
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

		private void MoveOffsetHeight()
		{
		}

		private void MoveOffsetHeight(float y)
		{
		}

		private void TryInitializeCamera()
		{
		}

		private bool SetupCamera()
		{
			return false;
		}

		private bool SetupCamera(XRInputSubsystem inputSubsystem)
		{
			return false;
		}

		private void OnInputSubsystemTrackingOriginUpdated(XRInputSubsystem inputSubsystem)
		{
		}

		[IteratorStateMachine(typeof(_003CRepeatInitializeCamera_003Ed__48))]
		private IEnumerator RepeatInitializeCamera()
		{
			return null;
		}

		public bool RotateAroundCameraUsingOriginUp(float angleDegrees)
		{
			return false;
		}

		public bool RotateAroundCameraPosition(Vector3 vector, float angleDegrees)
		{
			return false;
		}

		public bool MatchOriginUp(Vector3 destinationUp)
		{
			return false;
		}

		public bool MatchOriginUpCameraForward(Vector3 destinationUp, Vector3 destinationForward)
		{
			return false;
		}

		public bool MatchOriginUpOriginForward(Vector3 destinationUp, Vector3 destinationForward)
		{
			return false;
		}

		public bool MoveCameraToWorldLocation(Vector3 desiredWorldLocation)
		{
			return false;
		}

		protected void Awake()
		{
		}

		private Pose GetCameraOriginPose()
		{
			return default(Pose);
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private void OnBeforeRender()
		{
		}

		protected void OnValidate()
		{
		}

		protected void Start()
		{
		}

		protected void OnDestroy()
		{
		}
	}
}
