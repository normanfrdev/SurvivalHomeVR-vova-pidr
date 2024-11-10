using System;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering
{
	[AddComponentMenu("Affordance System/Receiver/Rendering/Color Gradient Line Renderer Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.ColorGradientLineRendererAffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class ColorGradientLineRendererAffordanceReceiver : ColorAffordanceReceiver
	{
		public enum LineColorProperty
		{
			StartColor = 0,
			EndColor = 1
		}

		[SerializeField]
		[Tooltip("Line Renderer on which to animate colors.")]
		private LineRenderer m_LineRenderer;

		[SerializeField]
		[Tooltip("Mode determining how color is applied to the associated Line Renderer.")]
		private LineColorProperty m_LineColorProperty;

		[SerializeField]
		[Tooltip("Prevent XR Interactor Line Visual from controlling line rendering color if present.")]
		private bool m_DisableXRInteractorLineVisualColorControlIfPresent;

		private Color m_InitialStartColor;

		private Color m_InitialEndColor;

		public LineRenderer lineRenderer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LineColorProperty lineColorProperty
		{
			get
			{
				return default(LineColorProperty);
			}
			set
			{
			}
		}

		public bool disableXRInteractorLineVisualColorControlIfPresent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnAffordanceValueUpdated(Color newValue)
		{
		}

		protected override void CaptureInitialValue()
		{
		}

		protected override Color GetCurrentValueForCapture()
		{
			return default(Color);
		}
	}
}
