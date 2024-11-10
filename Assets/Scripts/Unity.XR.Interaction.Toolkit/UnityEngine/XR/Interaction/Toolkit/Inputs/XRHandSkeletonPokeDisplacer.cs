using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs
{
	[AddComponentMenu("XR/XR Hand Skeleton Poke Displacer", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer.html")]
	public class XRHandSkeletonPokeDisplacer : MonoBehaviour
	{
		private const float k_MinSmoothingAmount = 0f;

		private const float k_MaxSmoothingAmount = 30f;

		[SerializeField]
		[RequireInterface(typeof(IPokeStateDataProvider))]
		[Tooltip("Poke interactor reference used to get poke data.")]
		private Object m_PokeInteractorObject;

		private IPokeStateDataProvider m_PokeInteractor;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Threshold poke interaction strength must be above to snap the poke pose to the current pose.")]
		private float m_PokeStrengthSnapThreshold;

		[SerializeField]
		[Range(0f, 30f)]
		[Tooltip("Smoothing to apply to the offset root. If smoothing amount is 0, no smoothing will be applied.")]
		private float m_SmoothingAmount;

		[SerializeField]
		[Tooltip("Additional offset subtracted along the poke interaction axis to apply to the root pose when poking. Default value accounts for the width of the finger mesh.")]
		private float m_FixedOffset;

		public IPokeStateDataProvider pokeInteractor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float pokeStrengthSnapThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float smoothingAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fixedOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Update()
		{
		}
	}
}
