using System;
using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/Locomotion/Legacy/Continuous Turn Provider (Action-based)", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.ActionBasedContinuousTurnProvider.html")]
	[Obsolete("ActionBasedContinuousTurnProvider has been deprecated in version 3.0.0. Use ContinuousTurnProvider instead.")]
	public class ActionBasedContinuousTurnProvider : ContinuousTurnProviderBase
	{
		[SerializeField]
		[Tooltip("The Input System Action that will be used to read Turn data from the left hand controller. Must be a Value Vector2 Control.")]
		private InputActionProperty m_LeftHandTurnAction;

		[SerializeField]
		[Tooltip("The Input System Action that will be used to read Turn data from the right hand controller. Must be a Value Vector2 Control.")]
		private InputActionProperty m_RightHandTurnAction;

		public InputActionProperty leftHandTurnAction
		{
			get
			{
				return default(InputActionProperty);
			}
			set
			{
			}
		}

		public InputActionProperty rightHandTurnAction
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
