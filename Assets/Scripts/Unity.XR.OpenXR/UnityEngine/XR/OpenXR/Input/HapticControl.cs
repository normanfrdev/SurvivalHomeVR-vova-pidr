using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Input
{
	[Preserve]
	public class HapticControl : InputControl<Haptic>
	{
		public HapticControl()
		{
			((InputControl<TValue>)(object)this)._002Ector();
		}

		public unsafe override Haptic ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Haptic);
		}
	}
}
