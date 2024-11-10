using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[AddComponentMenu("XR/Visual/XR Tint Interactable Visual", 11)]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual.html")]
	public class XRTintInteractableVisual : MonoBehaviour
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		private struct ShaderPropertyLookup
		{
			public static readonly int emissionColor;
		}

		[SerializeField]
		[Tooltip("Tint color for interactable.")]
		private Color m_TintColor;

		[SerializeField]
		[Tooltip("Tint on hover.")]
		private bool m_TintOnHover;

		[SerializeField]
		[Tooltip("Tint on selection.")]
		private bool m_TintOnSelection;

		[SerializeField]
		[Tooltip("Renderer(s) to use for tinting (will default to any Renderer on the GameObject if not specified).")]
		private List<Renderer> m_TintRenderers;

		private IXRInteractable m_Interactable;

		private IXRHoverInteractable m_HoverInteractable;

		private IXRSelectInteractable m_SelectInteractable;

		private MaterialPropertyBlock m_TintPropertyBlock;

		private bool m_EmissionEnabled;

		private bool m_HasLoggedMaterialInstance;

		private static readonly List<Material> s_Materials;

		public Color tintColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool tintOnHover
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool tintOnSelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<Renderer> tintRenderers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		protected virtual void SetTint(bool on)
		{
		}

		protected virtual bool GetEmissionEnabled()
		{
			return false;
		}

		private void OnFirstHoverEntered(HoverEnterEventArgs args)
		{
		}

		private void OnLastHoverExited(HoverExitEventArgs args)
		{
		}

		private void OnFirstSelectEntered(SelectEnterEventArgs args)
		{
		}

		private void OnLastSelectExited(SelectExitEventArgs args)
		{
		}
	}
}
