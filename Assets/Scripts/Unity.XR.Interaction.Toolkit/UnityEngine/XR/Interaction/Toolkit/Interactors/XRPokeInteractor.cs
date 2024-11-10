using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Attachment;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[AddComponentMenu("XR/Interactors/XR Poke Interactor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor.html")]
	public class XRPokeInteractor : XRBaseInteractor, IUIHoverInteractor, IUIInteractor, IPokeStateDataProvider, IAttachPointVelocityProvider
	{
		private readonly struct PokeCollision
		{
			public readonly IXRInteractable interactable;

			public readonly IXRPokeFilter filter;

			public PokeCollision(IXRInteractable interactable, IXRPokeFilter filter)
			{
			}
		}

		private static readonly List<IXRInteractable> s_Results;

		[SerializeField]
		[Tooltip("The depth threshold within which an interaction can begin to be evaluated as a poke.")]
		private float m_PokeDepth;

		[SerializeField]
		[Tooltip("The width threshold within which an interaction can begin to be evaluated as a poke.")]
		private float m_PokeWidth;

		[SerializeField]
		[Tooltip("The width threshold within which an interaction can be evaluated as a poke select.")]
		private float m_PokeSelectWidth;

		[SerializeField]
		[Tooltip("The radius threshold within which an interaction can be evaluated as a poke hover.")]
		private float m_PokeHoverRadius;

		[SerializeField]
		[Tooltip("Distance along the poke interactable interaction axis that allows for a poke to be triggered sooner/with less precision.")]
		private float m_PokeInteractionOffset;

		[SerializeField]
		[Tooltip("Physics layer mask used for limiting poke sphere overlap.")]
		private LayerMask m_PhysicsLayerMask;

		[SerializeField]
		[Tooltip("Determines whether the poke sphere overlap will hit triggers.")]
		private QueryTriggerInteraction m_PhysicsTriggerInteraction;

		[SerializeField]
		[Tooltip("Denotes whether or not valid targets will only include objects with a poke filter.")]
		private bool m_RequirePokeFilter;

		[SerializeField]
		[Tooltip("When enabled, this allows the poke interactor to hover and select UI elements.")]
		private bool m_EnableUIInteraction;

		[SerializeField]
		[Tooltip("Denotes whether or not debug visuals are enabled for this poke interactor.")]
		private bool m_DebugVisualizationsEnabled;

		[SerializeField]
		private UIHoverEnterEvent m_UIHoverEntered;

		[SerializeField]
		private UIHoverExitEvent m_UIHoverExited;

		private BindableVariable<PokeStateData> m_PokeStateData;

		private GameObject m_HoverDebugSphere;

		private MeshRenderer m_HoverDebugRenderer;

		private Vector3 m_LastPokeInteractionPoint;

		private bool m_FirstFrame;

		private IXRSelectInteractable m_CurrentPokeTarget;

		private IXRPokeFilter m_CurrentPokeFilter;

		private readonly RaycastHit[] m_SphereCastHits;

		private readonly Collider[] m_OverlapSphereHits;

		private readonly List<PokeCollision> m_PokeTargets;

		private readonly List<IXRSelectFilter> m_InteractableSelectFilters;

		private readonly List<IXRInteractable> m_ValidTargets;

		private static readonly Dictionary<IXRInteractable, IXRPokeFilter> s_ValidTargetsScratchMap;

		private RegisteredUIInteractorCache m_RegisteredUIInteractorCache;

		private PhysicsScene m_LocalPhysicsScene;

		private Func<Vector3> m_PositionGetter;

		public float pokeDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pokeWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pokeSelectWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pokeHoverRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pokeInteractionOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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

		public bool requirePokeFilter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableUIInteraction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool debugVisualizationsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public UIHoverEnterEvent uiHoverEntered
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UIHoverExitEvent uiHoverExited
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IReadOnlyBindableVariable<PokeStateData> pokeStateData => null;

		protected IAttachPointVelocityTracker attachPointVelocityTracker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public override void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		private bool RegisterValidTargets(out IXRSelectInteractable currentTarget, out IXRPokeFilter pokeFilter)
		{
			currentTarget = null;
			pokeFilter = null;
			return false;
		}

		private void ProcessPokeStateData()
		{
		}

		public override void GetValidTargets(List<IXRInteractable> targets)
		{
		}

		private int EvaluateSphereOverlap()
		{
			return 0;
		}

		private bool FindPokeTarget(Collider hitCollider, out PokeCollision newPokeCollision)
		{
			newPokeCollision = default(PokeCollision);
			return false;
		}

		private void SetDebugObjectVisibility(bool isVisible)
		{
		}

		private void UpdateDebugVisuals()
		{
		}

		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		public virtual void UpdateUIModel(ref TrackedDeviceModel model)
		{
		}

		private Vector3 GetPokePosition()
		{
			return default(Vector3);
		}

		public bool TryGetUIModel(out TrackedDeviceModel model)
		{
			model = default(TrackedDeviceModel);
			return false;
		}

		void IUIHoverInteractor.OnUIHoverEntered(UIHoverEventArgs args)
		{
		}

		void IUIHoverInteractor.OnUIHoverExited(UIHoverEventArgs args)
		{
		}

		protected virtual void OnUIHoverEntered(UIHoverEventArgs args)
		{
		}

		protected virtual void OnUIHoverExited(UIHoverEventArgs args)
		{
		}

		protected override void OnHoverEntering(HoverEnterEventArgs args)
		{
		}

		public Vector3 GetAttachPointVelocity()
		{
			return default(Vector3);
		}

		public Vector3 GetAttachPointAngularVelocity()
		{
			return default(Vector3);
		}
	}
}
