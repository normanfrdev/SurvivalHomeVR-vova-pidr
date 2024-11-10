using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Transformers
{
	[AddComponentMenu("XR/Transformers/XR Single Grab Free Transformer", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer.html")]
	public class XRSingleGrabFreeTransformer : XRBaseGrabTransformer
	{
		public override void Process(XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale)
		{
		}

		internal static void UpdateTarget(XRGrabInteractable grabInteractable, ref Pose targetPose)
		{
		}
	}
}
