using System;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Serializable]
	public struct InteractionState
	{
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Value;

		[SerializeField]
		private bool m_Active;

		private bool m_ActivatedThisFrame;

		private bool m_DeactivatedThisFrame;

		public float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool active
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool activatedThisFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool deactivatedThisFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("deActivatedThisFrame has been deprecated. Use deactivatedThisFrame instead. (UnityUpgradable) -> deactivatedThisFrame", true)]
		public bool deActivatedThisFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void SetFrameState(bool isActive)
		{
		}

		public void SetFrameState(bool isActive, float newValue)
		{
		}

		public void SetFrameDependent(bool wasActive)
		{
		}

		public void ResetFrameDependent()
		{
		}

		[Obsolete("Reset has been renamed. Use ResetFrameDependent instead. (UnityUpgradable) -> ResetFrameDependent()", true)]
		public void Reset()
		{
		}
	}
}
