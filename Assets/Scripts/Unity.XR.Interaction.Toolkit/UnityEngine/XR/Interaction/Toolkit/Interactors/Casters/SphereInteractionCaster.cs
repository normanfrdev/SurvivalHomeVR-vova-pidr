using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Casters
{
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Interactors/Sphere Interaction Caster", 22)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster.html")]
	public class SphereInteractionCaster : InteractionCasterBase
	{
		private const int k_MaxRaycastHits = 10;

		private readonly RaycastHit[] m_OverlapSphereHits;

		private readonly Collider[] m_OverlapSphereColliderHits;

		[Header("Filtering Settings")]
		[SerializeField]
		[Tooltip("Layer mask used for limiting sphere cast and sphere overlap targets.")]
		private LayerMask m_PhysicsLayerMask;

		[SerializeField]
		private QueryTriggerInteraction m_PhysicsTriggerInteraction;

		[Header("Sphere Casting Settings")]
		[SerializeField]
		[Tooltip("Radius of the sphere cast.")]
		private float m_CastRadius;

		private bool m_FirstFrame;

		private Vector3 m_LastSphereCastOrigin;

		private PhysicsScene m_LocalPhysicsScene;

		public LayerMask physicsLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public QueryTriggerInteraction physicsTriggerInteraction
		{
			get
			{
				return default(QueryTriggerInteraction);
			}
			set
			{
			}
		}

		public float castRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public override bool TryGetColliderTargets(XRInteractionManager interactionManager, List<Collider> targets)
		{
			return false;
		}

		protected override bool InitializeCaster()
		{
			return false;
		}
	}
}
