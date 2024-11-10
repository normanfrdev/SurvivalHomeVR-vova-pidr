using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	public class RotationAxisLockGrabTransformer : XRBaseGrabTransformer
	{
		[SerializeField]
		[Tooltip("Defines which rotation axes are allowed when an object is grabbed. Axes not selected will maintain their initial rotation.")]
		private XRGeneralGrabTransformer.ManipulationAxes m_PermittedRotationAxis;

		private Vector3 m_InitialEulerRotation;

		protected override RegistrationMode registrationMode => default(RegistrationMode);

		public override void OnLink(XRGrabInteractable grabInteractable)
		{
		}

		public override void Process(XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale)
		{
		}
	}
}
