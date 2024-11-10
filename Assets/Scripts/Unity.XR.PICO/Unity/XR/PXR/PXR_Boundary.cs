using UnityEngine;

namespace Unity.XR.PXR
{
	public class PXR_Boundary
	{
		public static void SetVisible(bool value)
		{
		}

		public static bool GetVisible()
		{
			return false;
		}

		public static bool GetConfigured()
		{
			return false;
		}

		public static bool GetEnabled()
		{
			return false;
		}

		public static PxrBoundaryTriggerInfo TestNode(BoundaryTrackingNode node, BoundaryType boundaryType)
		{
			return default(PxrBoundaryTriggerInfo);
		}

		public static PxrBoundaryTriggerInfo TestPoint(PxrVector3f point, BoundaryType boundaryType)
		{
			return default(PxrBoundaryTriggerInfo);
		}

		public static Vector3[] GetGeometry(BoundaryType boundaryType)
		{
			return null;
		}

		public static Vector3 GetDimensions(BoundaryType boundaryType)
		{
			return default(Vector3);
		}

		public static void EnableSeeThroughManual(bool value)
		{
		}

		public static PxrTrackingState GetSeeThroughTrackingState()
		{
			return default(PxrTrackingState);
		}

		public static void SetGuardianSystemDisable(bool value)
		{
		}

		public static void UseGlobalPose(bool value)
		{
		}
	}
}
