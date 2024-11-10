using System;

namespace Unity.XR.PXR
{
	public struct PxrAnchorEntityLoadInfo
	{
		public uint maxResult;

		public ulong timeout;

		public PxrPersistLocation location;

		public IntPtr include;

		public IntPtr exclude;
	}
}
