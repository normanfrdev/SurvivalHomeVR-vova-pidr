using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.Serialization;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	[DefaultExecutionOrder(-200)]
	public abstract class UIInputModule : BaseInputModule
	{
		[Header("Configuration")]
		[SerializeField]
		[FormerlySerializedAs("clickSpeed")]
		[Tooltip("The maximum time (in seconds) between two mouse presses for it to be consecutive click.")]
		private float m_ClickSpeed;

		[SerializeField]
		[FormerlySerializedAs("moveDeadzone")]
		[Tooltip("The absolute value required by a move action on either axis required to trigger a move event.")]
		private float m_MoveDeadzone;

		[SerializeField]
		[FormerlySerializedAs("repeatDelay")]
		[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
		private float m_RepeatDelay;

		[FormerlySerializedAs("repeatRate")]
		[SerializeField]
		[Tooltip("The speed (in seconds) that the move action repeats itself once repeating.")]
		private float m_RepeatRate;

		[FormerlySerializedAs("trackedDeviceDragThresholdMultiplier")]
		[SerializeField]
		[Tooltip("Scales the EventSystem.pixelDragThreshold, for tracked devices, to make selection easier.")]
		private float m_TrackedDeviceDragThresholdMultiplier;

		[SerializeField]
		[Tooltip("Scales the scrollDelta in event data, for tracked devices, to scroll at an expected speed.")]
		private float m_TrackedScrollDeltaMultiplier;

		private Camera m_UICamera;

		private Camera m_MainCameraCache;

		private AxisEventData m_CachedAxisEvent;

		private readonly Dictionary<int, PointerEventData> m_PointerEventByPointerId;

		private readonly Dictionary<int, TrackedDeviceEventData> m_TrackedDeviceEventByPointerId;

		public float clickSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float moveDeadzone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float repeatDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float repeatRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float trackedDeviceDragThresholdMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float trackedScrollDeltaMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Camera uiCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<PointerEventData, List<RaycastResult>> finalizeRaycastResults
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

		public event Action<GameObject, PointerEventData> pointerEnter
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

		public event Action<GameObject, PointerEventData> pointerExit
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

		public event Action<GameObject, PointerEventData> pointerDown
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

		public event Action<GameObject, PointerEventData> pointerUp
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

		public event Action<GameObject, PointerEventData> pointerClick
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

		public event Action<GameObject, PointerEventData> pointerMove
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

		public event Action<GameObject, PointerEventData> initializePotentialDrag
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

		public event Action<GameObject, PointerEventData> beginDrag
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

		public event Action<GameObject, PointerEventData> drag
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

		public event Action<GameObject, PointerEventData> endDrag
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

		public event Action<GameObject, PointerEventData> drop
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

		public event Action<GameObject, PointerEventData> scroll
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

		public event Action<GameObject, BaseEventData> updateSelected
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

		public event Action<GameObject, AxisEventData> move
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

		public event Action<GameObject, BaseEventData> submit
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

		public event Action<GameObject, BaseEventData> cancel
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

		protected virtual void Update()
		{
		}

		protected virtual void DoProcess()
		{
		}

		public override void Process()
		{
		}

		protected bool SendUpdateEventToSelectedObject()
		{
			return false;
		}

		public override void ActivateModule()
		{
		}

		public GameObject GetCurrentGameObject(int pointerId)
		{
			return null;
		}

		public override bool IsPointerOverGameObject(int pointerId)
		{
			return false;
		}

		private RaycastResult PerformRaycast(PointerEventData eventData)
		{
			return default(RaycastResult);
		}

		internal void ProcessMouseState(ref MouseModel mouseState)
		{
		}

		private void ProcessPointerMovement(PointerEventData eventData)
		{
		}

		private void ProcessPointerButton(ButtonDeltaState mouseButtonChanges, PointerEventData eventData)
		{
		}

		private void ProcessPointerButtonDrag(PointerEventData eventData, UIPointerType pointerType, float pixelDragThresholdMultiplier = 1f)
		{
		}

		private void ProcessScrollWheel(PointerEventData eventData)
		{
		}

		internal void ProcessTouch(ref TouchModel touchState)
		{
		}

		internal void ProcessTrackedDevice(ref TrackedDeviceModel deviceState, bool force = false)
		{
		}

		private bool TryGetCamera(PointerEventData eventData, out Camera screenPointCamera)
		{
			screenPointCamera = null;
			return false;
		}

		internal void ProcessNavigationState(ref NavigationModel navigationState)
		{
		}

		internal void RemovePointerEventData(int pointerId)
		{
		}

		private PointerEventData GetOrCreateCachedPointerEvent(int pointerId)
		{
			return null;
		}

		private TrackedDeviceEventData GetOrCreateCachedTrackedDeviceEvent(int pointerId)
		{
			return null;
		}

		private AxisEventData GetOrCreateCachedAxisEvent()
		{
			return null;
		}
	}
}
