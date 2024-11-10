using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.OpenXR.Input
{
	[Obsolete("OpenXR.Input.Pose is deprecated, Please use UnityEngine.InputSystem.XR.PoseState instead", false)]
	public struct Pose
	{
		public bool isTracked
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public InputTrackingState trackingState
		{
			[CompilerGenerated]
			readonly get
			{
				return default(InputTrackingState);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 position
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Quaternion rotation
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 velocity
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 angularVelocity
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
