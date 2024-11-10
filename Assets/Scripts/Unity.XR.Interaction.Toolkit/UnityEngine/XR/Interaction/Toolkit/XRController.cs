using System;
using UnityEngine.Experimental.XR.Interaction;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("/XR Controller (Device-based)", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.XRController.html")]
	[Obsolete("XRController has been deprecated in version 3.0.0. Its functionality has been distributed into different components.")]
	public class XRController : XRBaseController
	{
		[SerializeField]
		private XRNode m_ControllerNode;

		private XRNode m_InputDeviceControllerNode;

		[SerializeField]
		private InputHelpers.Button m_SelectUsage;

		[SerializeField]
		private InputHelpers.Button m_ActivateUsage;

		[SerializeField]
		private InputHelpers.Button m_UIPressUsage;

		[SerializeField]
		private float m_AxisToPressThreshold;

		[SerializeField]
		private InputHelpers.Button m_RotateAnchorLeft;

		[SerializeField]
		private InputHelpers.Button m_RotateAnchorRight;

		[SerializeField]
		private InputHelpers.Button m_MoveObjectIn;

		[SerializeField]
		private InputHelpers.Button m_MoveObjectOut;

		[SerializeField]
		private InputHelpers.Axis2D m_DirectionalAnchorRotation;

		[SerializeField]
		private BasePoseProvider m_PoseProvider;

		private InputDevice m_InputDevice;

		public XRNode controllerNode
		{
			get
			{
				return default(XRNode);
			}
			set
			{
			}
		}

		public InputHelpers.Button selectUsage
		{
			get
			{
				return default(InputHelpers.Button);
			}
			set
			{
			}
		}

		public InputHelpers.Button activateUsage
		{
			get
			{
				return default(InputHelpers.Button);
			}
			set
			{
			}
		}

		public InputHelpers.Button uiPressUsage
		{
			get
			{
				return default(InputHelpers.Button);
			}
			set
			{
			}
		}

		public float axisToPressThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public InputHelpers.Button rotateObjectLeft
		{
			get
			{
				return default(InputHelpers.Button);
			}
			set
			{
			}
		}

		public InputHelpers.Button rotateObjectRight
		{
			get
			{
				return default(InputHelpers.Button);
			}
			set
			{
			}
		}

		public InputHelpers.Button moveObjectIn
		{
			get
			{
				return default(InputHelpers.Button);
			}
			set
			{
			}
		}

		public InputHelpers.Button moveObjectOut
		{
			get
			{
				return default(InputHelpers.Button);
			}
			set
			{
			}
		}

		public InputHelpers.Axis2D directionalAnchorRotation
		{
			get
			{
				return default(InputHelpers.Axis2D);
			}
			set
			{
			}
		}

		public BasePoseProvider poseProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputDevice inputDevice => default(InputDevice);

		protected override void Awake()
		{
		}

		protected override void UpdateTrackingInput(XRControllerState controllerState)
		{
		}

		protected override void UpdateInput(XRControllerState controllerState)
		{
		}

		protected virtual bool IsPressed(InputHelpers.Button button)
		{
			return false;
		}

		protected virtual float ReadValue(InputHelpers.Button button)
		{
			return 0f;
		}

		public override bool SendHapticImpulse(float amplitude, float duration)
		{
			return false;
		}
	}
}
