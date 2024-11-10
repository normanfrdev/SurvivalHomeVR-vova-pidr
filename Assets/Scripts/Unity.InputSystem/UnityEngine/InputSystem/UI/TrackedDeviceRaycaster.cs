using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UnityEngine.InputSystem.UI
{
	[AddComponentMenu("Event/Tracked Device Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class TrackedDeviceRaycaster : BaseRaycaster
	{
		private struct RaycastHitData
		{
			public readonly Graphic graphic
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public readonly Vector3 worldHitPosition
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
			}

			public readonly Vector2 screenPosition
			{
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
			}

			public readonly float distance
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance)
			{
			}
		}

		[NonSerialized]
		private List<RaycastHitData> m_RaycastResultsCache;

		internal static InlinedArray<TrackedDeviceRaycaster> s_Instances;

		private static readonly List<RaycastHitData> s_SortedGraphics;

		[FormerlySerializedAs("ignoreReversedGraphics")]
		[SerializeField]
		private bool m_IgnoreReversedGraphics;

		[FormerlySerializedAs("checkFor2DOcclusion")]
		[SerializeField]
		private bool m_CheckFor2DOcclusion;

		[FormerlySerializedAs("checkFor3DOcclusion")]
		[SerializeField]
		private bool m_CheckFor3DOcclusion;

		[Tooltip("Maximum distance (in 3D world space) that rays are traced to find a hit.")]
		[SerializeField]
		private float m_MaxDistance;

		[SerializeField]
		private LayerMask m_BlockingMask;

		[NonSerialized]
		private Canvas m_Canvas;

		public override Camera eventCamera => null;

		public LayerMask blockingMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public bool checkFor3DOcclusion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool checkFor2DOcclusion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreReversedGraphics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float maxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private Canvas canvas => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<RaycastHitData> results)
		{
		}

		private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance)
		{
			worldPosition = default(Vector3);
			distance = default(float);
			return false;
		}
	}
}
