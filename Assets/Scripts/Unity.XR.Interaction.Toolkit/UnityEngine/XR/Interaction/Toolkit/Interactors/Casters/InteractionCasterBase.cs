using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Casters
{
	public abstract class InteractionCasterBase : MonoBehaviour, IInteractionCaster
	{
		[SerializeField]
		[Tooltip("Source of origin and direction used when updating sample points.")]
		private Transform m_CastOrigin;

		[Header("Stabilization Parameters")]
		[SerializeField]
		[Tooltip("Determines whether to stabilize the cast origin")]
		private bool m_EnableStabilization;

		[SerializeField]
		[Tooltip("Factor for stabilizing position. Larger values increase the range of stabilization, making the effect more pronounced over a greater distance.")]
		private float m_PositionStabilization;

		[SerializeField]
		[Tooltip("Factor for stabilizing angle. Larger values increase the range of stabilization, making the effect more pronounced over a greater angle.")]
		private float m_AngleStabilization;

		[SerializeField]
		[RequireInterface(typeof(IXRRayProvider))]
		[Tooltip("Optional ray provider for calculating stable rotation.")]
		private Object m_AimTargetObject;

		private readonly UnityObjectReferenceCache<IXRRayProvider, Object> m_AimTargetObjectRef;

		private bool m_InitializedStabilizationOrigin;

		private Transform m_StabilizationAnchor;

		private float m_LastStabilizationUpdateTime;

		public bool isInitialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Transform castOrigin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform effectiveCastOrigin => null;

		public bool enableStabilization
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float positionStabilization
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angleStabilization
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public IXRRayProvider aimTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual bool TryGetColliderTargets(XRInteractionManager interactionManager, List<Collider> targets)
		{
			return false;
		}

		protected abstract bool InitializeCaster();

		protected virtual void UpdateInternalData()
		{
		}

		protected virtual bool InitializeStabilization()
		{
			return false;
		}
	}
}
