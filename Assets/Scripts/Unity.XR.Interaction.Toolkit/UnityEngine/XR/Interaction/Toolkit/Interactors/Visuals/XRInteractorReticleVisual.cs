using Unity.Collections;
using Unity.XR.CoreUtils;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[AddComponentMenu("XR/Visual/XR Interactor Reticle Visual", 11)]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual.html")]
	public class XRInteractorReticleVisual : MonoBehaviour
	{
		private const int k_MaxRaycastHits = 10;

		[SerializeField]
		private float m_MaxRaycastDistance;

		[SerializeField]
		private GameObject m_ReticlePrefab;

		[SerializeField]
		private float m_PrefabScalingFactor;

		[SerializeField]
		private bool m_UndoDistanceScaling;

		[SerializeField]
		private bool m_AlignPrefabWithSurfaceNormal;

		[SerializeField]
		private float m_EndpointSmoothingTime;

		[SerializeField]
		private bool m_DrawWhileSelecting;

		[SerializeField]
		private bool m_DrawOnNoHit;

		[SerializeField]
		private LayerMask m_RaycastMask;

		private bool m_ReticleActive;

		private NativeArray<Vector3> m_InteractorLinePoints;

		private XROrigin m_XROrigin;

		private GameObject m_ReticleInstance;

		private XRBaseInteractor m_Interactor;

		private Vector3 m_TargetEndPoint;

		private Vector3 m_TargetEndNormal;

		private PhysicsScene m_LocalPhysicsScene;

		private bool m_HasRaycastHit;

		private readonly RaycastHit[] m_RaycastHits;

		public float maxRaycastDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GameObject reticlePrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float prefabScalingFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool undoDistanceScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool alignPrefabWithSurfaceNormal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float endpointSmoothingTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool drawWhileSelecting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool drawOnNoHit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public bool reticleActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Update()
		{
		}

		protected void OnDestroy()
		{
		}

		private void FindXROrigin()
		{
		}

		private void SetupReticlePrefab()
		{
		}

		private static RaycastHit FindClosestHit(RaycastHit[] hits, int hitCount)
		{
			return default(RaycastHit);
		}

		private bool TryGetRaycastPoint(ref Vector3 raycastPos, ref Vector3 raycastNormal)
		{
			return false;
		}

		private bool UpdateReticleTarget()
		{
			return false;
		}

		private void ActivateReticleAtTarget()
		{
		}

		private void OnSelectEntered(SelectEnterEventArgs args)
		{
		}
	}
}
