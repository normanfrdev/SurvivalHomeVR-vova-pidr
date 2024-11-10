using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	public class PXR_EyeTracking
	{
		private static InputDevice curDevice;

		public static bool GetHeadPosMatrix(out Matrix4x4 matrix)
		{
			matrix = default(Matrix4x4);
			return false;
		}

		private static bool GetEyeTrackingDevice(out InputDevice device)
		{
			device = default(InputDevice);
			return false;
		}

		public static bool GetCombineEyeGazePoint(out Vector3 point)
		{
			point = default(Vector3);
			return false;
		}

		public static bool GetCombineEyeGazeVector(out Vector3 vector)
		{
			vector = default(Vector3);
			return false;
		}

		public static bool GetLeftEyeGazeOpenness(out float openness)
		{
			openness = default(float);
			return false;
		}

		public static bool GetRightEyeGazeOpenness(out float openness)
		{
			openness = default(float);
			return false;
		}

		public static bool GetLeftEyePoseStatus(out uint status)
		{
			status = default(uint);
			return false;
		}

		public static bool GetRightEyePoseStatus(out uint status)
		{
			status = default(uint);
			return false;
		}

		public static bool GetCombinedEyePoseStatus(out uint status)
		{
			status = default(uint);
			return false;
		}

		public static bool GetLeftEyePositionGuide(out Vector3 position)
		{
			position = default(Vector3);
			return false;
		}

		public static bool GetRightEyePositionGuide(out Vector3 position)
		{
			position = default(Vector3);
			return false;
		}

		public static bool GetFoveatedGazeDirection(out Vector3 direction)
		{
			direction = default(Vector3);
			return false;
		}

		public static bool GetFoveatedGazeTrackingState(out uint state)
		{
			state = default(uint);
			return false;
		}
	}
}
