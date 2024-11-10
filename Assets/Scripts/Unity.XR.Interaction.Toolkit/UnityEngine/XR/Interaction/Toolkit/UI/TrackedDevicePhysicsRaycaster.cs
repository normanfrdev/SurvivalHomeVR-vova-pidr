using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	[AddComponentMenu("Event/Tracked Device Physics Raycaster", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.UI.TrackedDevicePhysicsRaycaster.html")]
	public class TrackedDevicePhysicsRaycaster : BaseRaycaster
	{
		private class RaycastHitArraySegment : IEnumerable<RaycastHit>, IEnumerable, IEnumerator<RaycastHit>, IEnumerator, IDisposable
		{
			private int m_Count;

			private readonly RaycastHit[] m_Hits;

			private int m_CurrentIndex;

			public int count
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public RaycastHit Current => default(RaycastHit);

			object IEnumerator.Current => null;

			public RaycastHitArraySegment(RaycastHit[] raycastHits, int count)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}

			public IEnumerator<RaycastHit> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private sealed class RaycastHitComparer : IComparer<RaycastHit>
		{
			public int Compare(RaycastHit a, RaycastHit b)
			{
				return 0;
			}
		}

		private const int k_EverythingLayerMask = -1;

		[SerializeField]
		[Tooltip("Specifies whether the ray cast should hit triggers.")]
		private QueryTriggerInteraction m_RaycastTriggerInteraction;

		[SerializeField]
		[Tooltip("Layer mask used to filter events. Always combined with the ray cast mask of the UI interactor.")]
		private LayerMask m_EventMask;

		[SerializeField]
		[Tooltip("The max number of intersections allowed. Value will be clamped to greater than 0.")]
		private int m_MaxRayIntersections;

		[SerializeField]
		[Tooltip("The event camera for this ray caster. The event camera is used to determine the screen position and display of the ray cast results.")]
		private Camera m_EventCamera;

		private bool m_HasWarnedEventCameraNull;

		private RaycastHit[] m_RaycastHits;

		private readonly RaycastHitComparer m_RaycastHitComparer;

		private RaycastHitArraySegment m_RaycastArrayWrapper;

		private readonly List<RaycastHit> m_RaycastResultsCache;

		private PhysicsScene m_LocalPhysicsScene;

		public QueryTriggerInteraction raycastTriggerInteraction
		{
			get
			{
				return default(QueryTriggerInteraction);
			}
			set
			{
			}
		}

		public LayerMask eventMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public int maxRayIntersections
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override Camera eventCamera => null;

		public void SetEventCamera(Camera newEventCamera)
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		protected override void Awake()
		{
		}

		private void PerformRaycasts(TrackedDeviceEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private bool PerformRaycast(Vector3 from, Vector3 to, LayerMask layerMask, Camera currentEventCamera, List<RaycastResult> resultAppendList)
		{
			return false;
		}
	}
}
