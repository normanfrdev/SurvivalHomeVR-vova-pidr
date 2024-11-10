using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs
{
	[AddComponentMenu("Input/Input Action Manager")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.InputActionManager.html")]
	public class InputActionManager : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Input action assets to affect when inputs are enabled or disabled.")]
		private List<InputActionAsset> m_ActionAssets;

		public List<InputActionAsset> actionAssets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public void EnableInput()
		{
		}

		public void DisableInput()
		{
		}
	}
}
