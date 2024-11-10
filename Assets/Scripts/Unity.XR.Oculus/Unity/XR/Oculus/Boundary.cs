using UnityEngine;

namespace Unity.XR.Oculus
{
	public static class Boundary
	{
		public enum BoundaryType
		{
			OuterBoundary = 0,
			PlayArea = 1
		}

		public static bool GetBoundaryConfigured()
		{
			return false;
		}

		public static bool GetBoundaryDimensions(BoundaryType boundaryType, out Vector3 dimensions)
		{
			dimensions = default(Vector3);
			return false;
		}

		public static bool GetBoundaryVisible()
		{
			return false;
		}

		public static void SetBoundaryVisible(bool boundaryVisible)
		{
		}
	}
}
