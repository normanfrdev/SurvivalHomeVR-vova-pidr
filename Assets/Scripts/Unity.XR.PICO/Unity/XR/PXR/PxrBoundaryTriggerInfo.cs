namespace Unity.XR.PXR
{
	public struct PxrBoundaryTriggerInfo
	{
		public bool isTriggering;

		public float closestDistance;

		public PxrVector3f closestPoint;

		public PxrVector3f closestPointNormal;

		public bool valid;
	}
}
