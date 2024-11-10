using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Casters
{
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Interactors/Curve Interaction Caster", 22)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster.html")]
	public class CurveInteractionCaster : InteractionCasterBase, ICurveInteractionCaster, IInteractionCaster, IUIModelUpdater
	{
		public enum HitDetectionType
		{
			Raycast = 0,
			SphereCast = 1,
			ConeCast = 2
		}

		public enum QuerySnapVolumeInteraction
		{
			Ignore = 0,
			Collide = 1
		}

		protected sealed class RaycastHitComparer : IComparer<RaycastHit>
		{
			public int Compare(RaycastHit a, RaycastHit b)
			{
				return 0;
			}
		}

		private const int k_MaxRaycastHits = 10;

		private const int k_MinNumCurveSegments = 1;

		private const int k_MaxNumCurveSegments = 100;

		private NativeArray<Vector3> m_SamplePoints;

		[Header("Filtering Settings")]
		[SerializeField]
		[Tooltip("Gets or sets layer mask used for limiting ray cast targets.")]
		private LayerMask m_RaycastMask;

		[SerializeField]
		[Tooltip("Gets or sets type of interaction with trigger colliders via ray cast.")]
		private QueryTriggerInteraction m_RaycastTriggerInteraction;

		[SerializeField]
		[Tooltip("Determines if ray casts include snap volume triggers: 'Collide' to include, 'Ignore' for performance optimization when not using specific XR components.")]
		private QuerySnapVolumeInteraction m_RaycastSnapVolumeInteraction;

		[Header("Curve Casting settings")]
		[SerializeField]
		[Range(1f, 100f)]
		private int m_TargetNumCurveSegments;

		[SerializeField]
		private HitDetectionType m_HitDetectionType;

		[SerializeField]
		private float m_CastDistance;

		[SerializeField]
		[Range(0.01f, 0.25f)]
		private float m_SphereCastRadius;

		[SerializeField]
		private float m_ConeCastAngle;

		private PhysicsScene m_LocalPhysicsScene;

		private int m_RaycastHitsCount;

		private readonly RaycastHit[] m_RaycastHits;

		private readonly RaycastHitComparer m_RaycastHitComparer;

		private static readonly RaycastHit[] s_SpherecastScratch;

		private static readonly HashSet<Collider> s_OptimalHits;

		public NativeArray<Vector3> samplePoints
		{
			get
			{
				return default(NativeArray<Vector3>);
			}
			protected set
			{
			}
		}

		public Vector3 lastSamplePoint => default(Vector3);

		public LayerMask raycastMask
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

		public QuerySnapVolumeInteraction raycastSnapVolumeInteraction
		{
			get
			{
				return default(QuerySnapVolumeInteraction);
			}
			set
			{
			}
		}

		public int targetNumCurveSegments
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public HitDetectionType hitDetectionType
		{
			get
			{
				return default(HitDetectionType);
			}
			set
			{
			}
		}

		public float castDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float sphereCastRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float coneCastAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected bool isDestroyed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override bool InitializeCaster()
		{
			return false;
		}

		public override bool TryGetColliderTargets(XRInteractionManager interactionManager, List<Collider> targets)
		{
			return false;
		}

		public bool TryGetColliderTargets(XRInteractionManager interactionManager, List<Collider> targets, List<RaycastHit> raycastHits)
		{
			return false;
		}

		protected override void UpdateInternalData()
		{
		}

		protected virtual void UpdateSamplePoints()
		{
		}

		protected virtual void UpdateSamplePoints(in Vector3 origin, in Vector3 direction, float totalDistance, NativeArray<Vector3> points)
		{
		}

		protected virtual bool UpdatePhysicscastHits(in XRInteractionManager interactionManager)
		{
			return false;
		}

		protected virtual int CheckCollidersBetweenPoints(in XRInteractionManager interactionManager, Vector3 from, Vector3 to, Vector3 origin, RaycastHit[] raycastHits)
		{
			return 0;
		}

		private int FilteredConecast(XRInteractionManager interactionManager, in Vector3 from, float coneCastAngleDegrees, in Vector3 direction, in Vector3 origin, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		private static int FilterOutSnapTriggerColliders(in XRInteractionManager interactionManager, RaycastHit[] raycastHits, int count)
		{
			return 0;
		}

		private static int FilterOutNonSnapTriggerColliders(in XRInteractionManager interactionManager, RaycastHit[] raycastHits, int count)
		{
			return 0;
		}

		public bool UpdateUIModel(ref TrackedDeviceModel uiModel, bool isSelectActive, in Vector2 scrollDelta)
		{
			return false;
		}

		bool IUIModelUpdater.UpdateUIModel(ref TrackedDeviceModel uiModel, bool isSelectActive, in Vector2 scrollDelta)
		{
			return false;
		}
	}
}
