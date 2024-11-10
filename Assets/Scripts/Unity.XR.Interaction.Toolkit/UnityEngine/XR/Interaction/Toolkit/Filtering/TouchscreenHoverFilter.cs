using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[AddComponentMenu("XR/AR/Touchscreen Hover Filter", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter.html")]
	public class TouchscreenHoverFilter : MonoBehaviour, IXRHoverFilter
	{
		[SerializeField]
		private XRInputValueReader<int> m_ScreenTouchCountInput;

		public XRInputValueReader<int> screenTouchCountInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool canProcess => false;

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public bool Process(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
		{
			return false;
		}
	}
}
