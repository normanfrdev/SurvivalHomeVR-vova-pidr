using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Input
{
	[Preserve]
	[InputControlLayout(displayName = "OpenXR Action Map")]
	public abstract class OpenXRDevice : UnityEngine.InputSystem.InputDevice
	{
		protected override void FinishSetup()
		{
		}
	}
}
