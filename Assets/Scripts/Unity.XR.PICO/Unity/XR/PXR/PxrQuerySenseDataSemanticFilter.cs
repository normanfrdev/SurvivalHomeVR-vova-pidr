using System;

namespace Unity.XR.PXR
{
	public struct PxrQuerySenseDataSemanticFilter
	{
		public PxrStructureType type;

		public uint semanticCount;

		public IntPtr semantics;
	}
}
