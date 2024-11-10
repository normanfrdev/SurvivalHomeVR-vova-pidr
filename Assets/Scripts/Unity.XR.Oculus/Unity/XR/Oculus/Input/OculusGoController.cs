using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace Unity.XR.Oculus.Input
{
	[Preserve]
	[InputControlLayout(hideInUI = true, displayName = "Oculus Go Controller", commonUsages = new string[] { "LeftHand", "RightHand" })]
	public class OculusGoController : GearVRTrackedController
	{
	}
}
