using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Bindings;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	[AddComponentMenu("Event/Tracked Device Graphic Raycaster", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.UI.TrackedDeviceGraphicRaycaster.html")]
	public class TrackedDeviceGraphicRaycaster : BaseRaycaster, IPokeStateDataProvider, IMultiPokeStateDataProvider
	{
		private readonly struct RaycastHitData
		{
			public Graphic graphic
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public Vector3 worldHitPosition
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
			}

			public Vector2 screenPosition
			{
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
			}

			public float distance
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			public int displayIndex
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance, int displayIndex)
			{
			}
		}

		private sealed class RaycastHitComparer : IComparer<RaycastHitData>
		{
			public int Compare(RaycastHitData a, RaycastHitData b)
			{
				return 0;
			}
		}

		private const int k_MaxRaycastHits = 10;

		[SerializeField]
		[Tooltip("Whether Graphics facing away from the ray caster are checked for ray casts. Enable this to ignore backfacing Graphics.")]
		private bool m_IgnoreReversedGraphics;

		[SerializeField]
		[Tooltip("Whether or not 2D occlusion is checked when performing ray casts. Enable to make Graphics be blocked by 2D objects that exist in front of it.")]
		private bool m_CheckFor2DOcclusion;

		[SerializeField]
		[Tooltip("Whether or not 3D occlusion is checked when performing ray casts. Enable to make Graphics be blocked by 3D objects that exist in front of it.")]
		private bool m_CheckFor3DOcclusion;

		[SerializeField]
		[Tooltip("The layers of objects that are checked to determine if they block Graphic ray casts when checking for 2D or 3D occlusion.")]
		private LayerMask m_BlockingMask;

		[SerializeField]
		[Tooltip("Specifies whether the ray cast should hit Triggers when checking for 3D occlusion.")]
		private QueryTriggerInteraction m_RaycastTriggerInteraction;

		private Canvas m_Canvas;

		private bool m_HasWarnedEventCameraNull;

		private readonly RaycastHit[] m_OcclusionHits3D;

		private readonly RaycastHit2D[] m_OcclusionHits2D;

		private static readonly RaycastHitComparer s_RaycastHitComparer;

		private static readonly Vector3[] s_Corners;

		private readonly List<RaycastHitData> m_RaycastResultsCache;

		[NonSerialized]
		private static readonly List<RaycastHitData> s_SortedGraphics;

		private XRPokeLogic m_PokeLogic;

		[NonSerialized]
		private static readonly Dictionary<IUIInteractor, TrackedDeviceGraphicRaycaster> s_InteractorRaycasters;

		[NonSerialized]
		private static readonly Dictionary<TrackedDeviceGraphicRaycaster, HashSet<IUIInteractor>> s_PokeHoverRaycasters;

		private BindingsGroup m_BindingsGroup;

		private PhysicsScene m_LocalPhysicsScene;

		private PhysicsScene2D m_LocalPhysicsScene2D;

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

		public override Camera eventCamera => null;

		private Canvas canvas => null;

		public IReadOnlyBindableVariable<PokeStateData> pokeStateData => null;

		private Dictionary<Transform, BindableVariable<PokeStateData>> pokeStateDataDictionary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		internal static bool IsPokeInteractingWithUI(IUIInteractor interactor)
		{
			return false;
		}

		private void EndPokeInteraction(IUIInteractor interactor)
		{
		}

		internal static bool TryGetPokeStateDataForInteractor(IUIInteractor interactor, out PokeStateData data)
		{
			data = default(PokeStateData);
			return false;
		}

		public IReadOnlyBindableVariable<PokeStateData> GetPokeStateDataForTarget(Transform target)
		{
			return null;
		}

		internal static bool HasPokeSelect(IUIInteractor interactor)
		{
			return false;
		}

		private static RaycastHit FindClosestHit(RaycastHit[] hits, int count)
		{
			return default(RaycastHit);
		}

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void SetupPoke()
		{
		}

		private void PerformRaycasts(TrackedDeviceEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private bool PerformSpherecast(Vector3 origin, float radius, LayerMask layerMask, Camera currentEventCamera, List<RaycastResult> resultAppendList)
		{
			return false;
		}

		private bool PerformRaycast(Vector3 from, Vector3 to, LayerMask layerMask, Camera currentEventCamera, List<RaycastResult> resultAppendList)
		{
			return false;
		}

		private bool ProcessSortedHitsResults(Ray ray, float hitDistance, bool hitSomething, List<RaycastHitData> raycastHitDatums, List<RaycastResult> resultAppendList)
		{
			return false;
		}

		private static void SortedSpherecastGraphics(Canvas canvas, Vector3 origin, float radius, LayerMask layerMask, Camera eventCamera, List<RaycastHitData> results)
		{
		}

		private static void SortedRaycastGraphics(Canvas canvas, Ray ray, float maxDistance, LayerMask layerMask, Camera eventCamera, List<RaycastHitData> results)
		{
		}

		private static bool ShouldTestGraphic(Graphic graphic, LayerMask layerMask)
		{
			return false;
		}

		private static bool SphereIntersectsRectTransform(RectTransform transform, Vector4 raycastPadding, Vector3 from, out Vector3 worldPosition, out float distance)
		{
			worldPosition = default(Vector3);
			distance = default(float);
			return false;
		}

		private static bool RayIntersectsRectTransform(RectTransform transform, Vector4 raycastPadding, Ray ray, out Vector3 worldPosition, out float distance)
		{
			worldPosition = default(Vector3);
			distance = default(float);
			return false;
		}

		private static bool RayIntersectsRectTransform(Ray ray, Plane plane, out Vector3 worldPosition, out float distance)
		{
			worldPosition = default(Vector3);
			distance = default(float);
			return false;
		}

		private static Plane GetRectTransformPlane(RectTransform transform, Vector4 raycastPadding, Vector3[] fourCornersArray)
		{
			return default(Plane);
		}

		private static void GetRectTransformWorldCorners(RectTransform transform, Vector4 offset, Vector3[] fourCornersArray)
		{
		}

		[Conditional("UNITY_EDITOR")]
		protected void OnDrawGizmosSelected()
		{
		}
	}
}
