using Unity.Mathematics;
using Unity.XR.CoreUtils.Bindings;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	[AddComponentMenu("XR/XR Poke Follow Affordance", 22)]
	public class XRPokeFollowAffordance : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Transform that will move in the poke direction when this or a parent GameObject is poked.\nNote: Should be a direct child GameObject.")]
		private Transform m_PokeFollowTransform;

		[SerializeField]
		[Range(0f, 20f)]
		[Tooltip("Multiplies transform position interpolation as a factor of Time.deltaTime. If 0, no smoothing will be applied.")]
		private float m_SmoothingSpeed;

		[SerializeField]
		[Tooltip("When this component is no longer the target of the poke, the Poke Follow Transform returns to the original position.")]
		private bool m_ReturnToInitialPosition;

		[SerializeField]
		[Tooltip("Whether to apply the follow animation if the target of the poke is a child of this transform. This is useful for UI objects that may have child graphics.")]
		private bool m_ApplyIfChildIsTarget;

		[SerializeField]
		[Tooltip("Whether to keep the Poke Follow Transform from moving past a maximum distance from the poke target.")]
		private bool m_ClampToMaxDistance;

		[SerializeField]
		[Tooltip("The maximum distance from this transform that the Poke Follow Transform can move.")]
		private float m_MaxDistance;

		private IPokeStateDataProvider m_PokeDataProvider;

		private IMultiPokeStateDataProvider m_MultiPokeStateDataProvider;

		private readonly Vector3TweenableVariable m_TransformTweenableVariable;

		private readonly BindingsGroup m_BindingsGroup;

		private Vector3 m_InitialPosition;

		private bool m_IsFirstFrame;

		public Transform pokeFollowTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float smoothingSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool returnToInitialPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool applyIfChildIsTarget
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool clampToMaxDistance
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

		public Vector3 initialPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void Start()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void LateUpdate()
		{
		}

		private void OnTransformTweenableVariableUpdated(float3 position)
		{
		}

		private void OnPokeStateDataUpdated(PokeStateData data)
		{
		}

		public void ResetFollowTransform()
		{
		}
	}
}
