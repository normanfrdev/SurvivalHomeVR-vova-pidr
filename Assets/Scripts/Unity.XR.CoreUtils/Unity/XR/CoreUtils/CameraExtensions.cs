using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class CameraExtensions
	{
		private const float k_OneOverSqrt2 = 0.70710677f;

		public static float GetVerticalFieldOfView(this Camera camera, float aspectNeutralFieldOfView)
		{
			return 0f;
		}

		public static float GetHorizontalFieldOfView(this Camera camera)
		{
			return 0f;
		}

		public static float GetVerticalOrthographicSize(this Camera camera, float size)
		{
			return 0f;
		}
	}
}
