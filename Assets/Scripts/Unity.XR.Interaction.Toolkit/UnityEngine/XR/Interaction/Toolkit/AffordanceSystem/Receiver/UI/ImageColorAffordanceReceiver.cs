using System;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.UI
{
	[AddComponentMenu("Affordance System/Receiver/UI/Image Color Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.UI.ImageColorAffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class ImageColorAffordanceReceiver : ColorAffordanceReceiver
	{
		[Tooltip("Image to apply the color to.")]
		[SerializeField]
		private Image m_Image;

		[Tooltip("If set, alpha changes will be applied to the CanvasGroup rather than the Image.")]
		[SerializeField]
		private CanvasGroup m_CanvasGroup;

		[Tooltip("Ignore alpha changes in color theme.")]
		[SerializeField]
		private bool m_IgnoreAlpha;

		private bool m_HasImage;

		private bool m_HasCanvasGroup;

		public Image image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CanvasGroup canvasGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ignoreAlpha
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnAffordanceValueUpdated(Color newValue)
		{
		}

		protected override Color GetCurrentValueForCapture()
		{
			return default(Color);
		}
	}
}
