using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	public class PXR_ControllerAnimator : MonoBehaviour
	{
		private Animator controllerAnimator;

		public Transform primary2DAxisTran;

		public Transform gripTran;

		public Transform triggerTran;

		public PXR_Input.Controller controller;

		private InputDevice currentController;

		private Vector2 axis2D;

		private bool primaryButton;

		private bool secondaryButton;

		private bool menuButton;

		private float grip;

		private float trigger;

		private Vector3 originalGrip;

		private Vector3 originalTrigger;

		private Vector3 originalJoystick;

		public const string primary = "IsPrimaryDown";

		public const string secondary = "IsSecondaryDown";

		public const string media = "IsMediaDown";

		public const string menu = "IsMenuDown";

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
