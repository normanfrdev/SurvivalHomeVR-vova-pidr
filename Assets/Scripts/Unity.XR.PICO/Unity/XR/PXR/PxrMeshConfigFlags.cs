using System;

namespace Unity.XR.PXR
{
	[Flags]
	public enum PxrMeshConfigFlags : ulong
	{
		Semantic = 1uL,
		SemanticAlignWithVertex = 2uL
	}
}
