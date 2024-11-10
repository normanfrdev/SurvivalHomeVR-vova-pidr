using System;
using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/Locomotion/Legacy/Snap Turn Provider (Action-based)", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider.html")]
	[Obsolete("ActionBasedSnapTurnProvider has been deprecated in version 3.0.0. Use SnapTurnProvider instead.")]
	public class ActionBasedSnapTurnProvider : SnapTurnProviderBase
	{
		[SerializeField]
		[Tooltip("The Input System Action that will be used to read Snap Turn data from the left hand controller. Must be a Value Vector2 Control.")]
		private InputActionProperty m_LeftHandSnapTurnAction;

		[SerializeField]
		[Tooltip("The Input System Action that will be used to read Snap Turn data from the right hand controller. Must be a Value Vector2 Control.")]
		private InputActionProperty m_RightHandSnapTurnAction;

		public InputActionProperty leftHandSnapTurnAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty rightHandSnapTurnAction
		{
			get
			{
				return default(InputActionProperty);
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

		protected override Vector2 ReadInput()
		{
			return default(Vector2);
		}

		private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value)
		{
		}
	}
}
