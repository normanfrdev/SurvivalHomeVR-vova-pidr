using System;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Obsolete("LocomotionPhase is deprecated in XRI 3.0.0 and will be removed in a future release. Use LocomotionState instead.", false)]
	public enum LocomotionPhase
	{
		[Obsolete("LocomotionPhase.Idle is deprecated and will be removed in a future release. Use LocomotionState.Idle instead.", false)]
		Idle = 0,
		[Obsolete("LocomotionPhase.Started is deprecated and will be removed in a future release. Use LocomotionState.Preparing instead.", false)]
		Started = 1,
		[Obsolete("LocomotionPhase.Moving is deprecated and will be removed in a future release. Use LocomotionState.Moving instead.", false)]
		Moving = 2,
		[Obsolete("LocomotionPhase.Done is deprecated and will be removed in a future release. Use LocomotionState.Ended instead.", false)]
		Done = 3
	}
}
