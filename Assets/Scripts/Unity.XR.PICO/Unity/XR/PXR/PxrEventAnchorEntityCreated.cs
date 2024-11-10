using System;

namespace Unity.XR.PXR
{
	public struct PxrEventAnchorEntityCreated
	{
		public ulong taskId;

		public PxrResult result;

		public ulong anchorHandle;

		public Guid uuid;
	}
}
