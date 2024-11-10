using System.Diagnostics;
using Unity.XR.CoreUtils.Bindings;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[AddComponentMenu("XR/XR Poke Filter", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter.html")]
	public class XRPokeFilter : MonoBehaviour, IXRPokeFilter, IXRSelectFilter, IXRInteractionStrengthFilter, IPokeStateDataProvider
	{
		[SerializeField]
		[Tooltip("The interactable associated with this poke filter.")]
		private XRBaseInteractable m_Interactable;

		[SerializeField]
		[Tooltip("The collider used to compute bounds of the poke interaction.")]
		private Collider m_PokeCollider;

		[SerializeField]
		[Tooltip("The settings used to fine tune the vector and offsets which dictate how the poke interaction will be evaluated.")]
		private PokeThresholdDatumProperty m_PokeConfiguration;

		private XRPokeLogic m_PokeLogic;

		private readonly BindingsGroup m_BindingsGroup;

		public XRBaseInteractable pokeInteractable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Collider pokeCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PokeThresholdDatumProperty pokeConfiguration
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

		public virtual bool canProcess => false;

		[Conditional("UNITY_EDITOR")]
		protected virtual void Reset()
		{
		}

		[Conditional("UNITY_EDITOR")]
		protected void OnValidate()
		{
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

		[Conditional("UNITY_EDITOR")]
		protected void OnDrawGizmosSelected()
		{
		}

		private void SetupBindings()
		{
		}

		private void ClearBindings()
		{
		}

		public bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
		{
			return false;
		}

		public float Process(IXRInteractor interactor, IXRInteractable interactable, float interactionStrength)
		{
			return 0f;
		}

		private void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		private void OnHoverExited(HoverExitEventArgs args)
		{
		}

		private XRBaseInteractable FindPokeInteractable()
		{
			return null;
		}

		private Collider FindPokeCollider()
		{
			return null;
		}

		private void Setup()
		{
		}
	}
}
