using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Transformers
{
	[AddComponentMenu("XR/Transformers/XR Dual Grab Free Transformer", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer.html")]
	public class XRDualGrabFreeTransformer : XRBaseGrabTransformer
	{
		public enum PoseContributor
		{
			First = 0,
			Second = 1,
			Average = 2
		}

		[SerializeField]
		private PoseContributor m_MultiSelectPosition;

		[SerializeField]
		private PoseContributor m_MultiSelectRotation;

		private Vector3 m_LastUp;

		public PoseContributor multiSelectPosition
		{
			get
			{
				return default(PoseContributor);
			}
			set
			{
			}
		}

		public PoseContributor multiSelectRotation
		{
			get
			{
				return default(PoseContributor);
			}
			set
			{
			}
		}

		protected override RegistrationMode registrationMode => default(RegistrationMode);

		internal Pose lastInteractorAttachPose
		{
			[CompilerGenerated]
			get
			{
				return default(Pose);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected virtual void OnDrawGizmosSelected()
		{
		}

		public override void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale)
		{
		}

		public override void Process(XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale)
		{
		}

		private void UpdateTarget(XRGrabInteractable grabInteractable, ref Pose targetPose)
		{
		}

		private void UpdateTargetMulti(XRGrabInteractable grabInteractable, ref Pose targetPose)
		{
		}
	}
}
