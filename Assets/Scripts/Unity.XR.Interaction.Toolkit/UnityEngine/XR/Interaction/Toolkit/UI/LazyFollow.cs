using Unity.Mathematics;
using Unity.XR.CoreUtils.Bindings;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.SmartTweenableVariables;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	[AddComponentMenu("XR/Lazy Follow", 22)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.UI.LazyFollow.html")]
	public class LazyFollow : MonoBehaviour
	{
		public enum PositionFollowMode
		{
			None = 0,
			Follow = 1
		}

		public enum RotationFollowMode
		{
			None = 0,
			LookAt = 1,
			LookAtWithWorldUp = 2,
			Follow = 3
		}

		private const float k_LowerSpeedVariance = 0f;

		private const float k_UpperSpeedVariance = 0.999f;

		[Header("Target Config")]
		[SerializeField]
		[Tooltip("(Optional) The object being followed. If not set, this will default to the main camera when this component is enabled.")]
		private Transform m_Target;

		[SerializeField]
		[Tooltip("The amount to offset the target's position when following. This position is relative/local to the target object.")]
		private Vector3 m_TargetOffset;

		[Space]
		[SerializeField]
		[Tooltip("If true, read the local transform of the target to lazy follow, otherwise read the world transform. If using look at rotation follow modes, only world-space follow is supported.")]
		private bool m_FollowInLocalSpace;

		[SerializeField]
		[Tooltip("If true, apply the target offset in local space. If false, apply the target offset in world space.")]
		private bool m_ApplyTargetInLocalSpace;

		[Header("General Follow Params")]
		[SerializeField]
		[Tooltip("Movement speed used when smoothing to new target. Lower values mean the lazy follow lags further behind the target.")]
		private float m_MovementSpeed;

		[SerializeField]
		[Range(0f, 0.999f)]
		[Tooltip("Adjust movement speed based on distance from the target using a tolerance percentage. 0% for constant speed.")]
		private float m_MovementSpeedVariancePercentage;

		[SerializeField]
		[Tooltip("Snap to target position when this component is enabled.")]
		private bool m_SnapOnEnable;

		[Header("Position Follow Params")]
		[SerializeField]
		[Tooltip("Determines the follow mode used to determine a new rotation. Look At is best used with the target being the main camera.")]
		private PositionFollowMode m_PositionFollowMode;

		[SerializeField]
		[Tooltip("Minimum distance from target before which a follow lazy follow starts.")]
		private float m_MinDistanceAllowed;

		[SerializeField]
		[Tooltip("Maximum distance from target before lazy follow targets, when time threshold is reached.")]
		private float m_MaxDistanceAllowed;

		[SerializeField]
		[Tooltip("Time required to elapse (in seconds) before the max distance allowed goes from the min distance to the max.")]
		private float m_TimeUntilThresholdReachesMaxDistance;

		[Header("Rotation Follow Params")]
		[SerializeField]
		[Tooltip("Determines the follow mode used to determine a new rotation. Look At is best used with the target being the main camera.")]
		private RotationFollowMode m_RotationFollowMode;

		[SerializeField]
		[Tooltip("Minimum angle offset (in degrees) from target before which lazy follow starts.")]
		private float m_MinAngleAllowed;

		[SerializeField]
		[Tooltip("Maximum angle offset (in degrees) from target before lazy follow targets, when time threshold is reached.")]
		private float m_MaxAngleAllowed;

		[SerializeField]
		[Tooltip("Time required to elapse (in seconds) before the max angle offset allowed goes from the min angle offset to the max.")]
		private float m_TimeUntilThresholdReachesMaxAngle;

		private float m_LowerMovementSpeed;

		private float m_UpperMovementSpeed;

		private readonly BindingsGroup m_BindingsGroup;

		private SmartFollowVector3TweenableVariable m_Vector3TweenableVariable;

		private SmartFollowQuaternionTweenableVariable m_QuaternionTweenableVariable;

		public Transform target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 targetOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool followInLocalSpace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool applyTargetInLocalSpace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float movementSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float movementSpeedVariancePercentage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool snapOnEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PositionFollowMode positionFollowMode
		{
			get
			{
				return default(PositionFollowMode);
			}
			set
			{
			}
		}

		public float minDistanceAllowed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxDistanceAllowed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float timeUntilThresholdReachesMaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RotationFollowMode rotationFollowMode
		{
			get
			{
				return default(RotationFollowMode);
			}
			set
			{
			}
		}

		public float minAngleAllowed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxAngleAllowed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float timeUntilThresholdReachesMaxAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected void OnValidate()
		{
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void LateUpdate()
		{
		}

		private void UpdatePosition(float3 position)
		{
		}

		private void UpdateRotation(Quaternion rotation)
		{
		}

		protected virtual bool TryGetThresholdTargetPosition(out Vector3 newTarget)
		{
			newTarget = default(Vector3);
			return false;
		}

		protected virtual bool TryGetThresholdTargetRotation(out Quaternion newTarget)
		{
			newTarget = default(Quaternion);
			return false;
		}

		private void ValidateFollowMode()
		{
		}

		private void UpdateUpperAndLowerSpeedBounds()
		{
		}
	}
}
