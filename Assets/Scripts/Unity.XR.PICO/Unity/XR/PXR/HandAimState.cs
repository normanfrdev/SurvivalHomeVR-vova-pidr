namespace Unity.XR.PXR
{
	public struct HandAimState
	{
		public HandAimStatus aimStatus;

		public Posef aimRayPose;

		private float pinchStrengthIndex;

		private float pinchStrengthMiddle;

		private float pinchStrengthRing;

		private float pinchStrengthLittle;

		public float touchStrengthRay;
	}
}
