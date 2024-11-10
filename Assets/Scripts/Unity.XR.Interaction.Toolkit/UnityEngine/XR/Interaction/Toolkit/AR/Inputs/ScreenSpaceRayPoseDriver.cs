using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

namespace UnityEngine.XR.Interaction.Toolkit.AR.Inputs
{
	[AddComponentMenu("XR/Input/Screen Space Ray Pose Driver", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AR.Inputs.ScreenSpaceRayPoseDriver.html")]
	[DefaultExecutionOrder(-31000)]
	public class ScreenSpaceRayPoseDriver : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The camera associated with the screen, and through which screen presses/touches will be interpreted.")]
		private Camera m_ControllerCamera;

		[SerializeField]
		private XRInputValueReader<Vector2> m_TapStartPositionInput;

		[SerializeField]
		private XRInputValueReader<Vector2> m_DragCurrentPositionInput;

		[SerializeField]
		[Tooltip("The input used to read the screen touch count value.")]
		private XRInputValueReader<int> m_ScreenTouchCountInput;

		private readonly UnityObjectReferenceCache<Transform> m_ParentTransformCache;

		private Vector2 m_TapStartPosition;

		public Camera controllerCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> tapStartPositionInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> dragCurrentPositionInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Update()
		{
		}

		private void ApplyPose(Vector2 screenPosition)
		{
		}
	}
}
