namespace UnityEngine.XR.OpenXR.NativeTypes
{
	internal struct XrPosef
	{
		private XrQuaternionf orientation;

		private XrVector3f position;

		public XrPosef(Vector3 vec3, Quaternion quaternion)
		{
		}
	}
}
