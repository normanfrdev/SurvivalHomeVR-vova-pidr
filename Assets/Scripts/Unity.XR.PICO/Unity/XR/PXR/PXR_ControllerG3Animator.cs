using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	public class PXR_ControllerG3Animator : MonoBehaviour
	{
		public Transform triggerTran;

		public Transform menuTran;

		public Transform touchPadTran;

		public PXR_ControllerPower controllerPower;

		private bool primaryAxisState;

		private bool menuButtonState;

		private float trigger;

		private Vector3 menu;

		private Vector3 originTrigger;

		private Vector3 touchPadPos;

		private InputDevice currentController;

		private int handness;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
