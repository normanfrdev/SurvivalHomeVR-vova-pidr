using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class TransformExtensions
	{
		public static Pose GetLocalPose(this Transform transform)
		{
			return default(Pose);
		}

		public static Pose GetWorldPose(this Transform transform)
		{
			return default(Pose);
		}

		public static void SetLocalPose(this Transform transform, Pose pose)
		{
		}

		public static void SetWorldPose(this Transform transform, Pose pose)
		{
		}

		public static Pose TransformPose(this Transform transform, Pose pose)
		{
			return default(Pose);
		}

		public static Pose InverseTransformPose(this Transform transform, Pose pose)
		{
			return default(Pose);
		}

		public static Ray InverseTransformRay(this Transform transform, Ray ray)
		{
			return default(Ray);
		}
	}
}
