using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs
{
	[BurstCompile]
	[AddComponentMenu("XR/XR Transform Stabilizer", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.html")]
	[DefaultExecutionOrder(-29985)]
	public class XRTransformStabilizer : MonoBehaviour
	{
		public delegate void StabilizeTransform_00001081_0024PostfixBurstDelegate(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot);

		internal static class StabilizeTransform_00001081_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static void Invoke(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot)
			{
				resultPos = default(float3);
				resultRot = default(quaternion);
			}
		}

		public delegate void StabilizePosition_00001082_0024PostfixBurstDelegate(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos);

		internal static class StabilizePosition_00001082_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static void Invoke(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos)
			{
				resultPos = default(float3);
			}
		}

		public delegate void StabilizeOptimalRotation_00001083_0024PostfixBurstDelegate(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot);

		internal static class StabilizeOptimalRotation_00001083_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static void Invoke(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot)
			{
				resultRot = default(quaternion);
			}
		}

		public delegate float CalculateStabilizedLerp_00001084_0024PostfixBurstDelegate(float distance, float timeSlice);

		internal static class CalculateStabilizedLerp_00001084_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static float Invoke(float distance, float timeSlice)
			{
				return 0f;
			}
		}

		public delegate void CalculateRotationParams_00001085_0024PostfixBurstDelegate(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale);

		internal static class CalculateRotationParams_00001085_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static void Invoke(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale)
			{
				antiRotation = default(quaternion);
				scaleFactor = default(float);
				targetAngleScale = default(float);
			}
		}

		private const float k_90FPS = 1f / 90f;

		[SerializeField]
		[Tooltip("The Transform component whose position and rotation will be matched and stabilized.")]
		private Transform m_Target;

		[SerializeField]
		[RequireInterface(typeof(IXRRayProvider))]
		[Tooltip("Optional - When provided a ray, the stabilizer will calculate the rotation that keeps a ray's endpoint stable.")]
		private Object m_AimTargetObject;

		private IXRRayProvider m_AimTarget;

		[SerializeField]
		[Tooltip("If enabled, will read the target and apply stabilization in local space. Otherwise, in world space.")]
		private bool m_UseLocalSpace;

		[Header("Stabilization Parameters")]
		[SerializeField]
		[Tooltip("Maximum distance (in degrees) that stabilization will be applied.")]
		private float m_AngleStabilization;

		[SerializeField]
		[Tooltip("Maximum distance (in meters) that stabilization will be applied.")]
		private float m_PositionStabilization;

		private Transform m_ThisTransform;

		public Transform targetTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IXRRayProvider aimTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useLocalSpace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float angleStabilization
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float positionStabilization
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void Update()
		{
		}

		public static void ApplyStabilization(ref Transform toStabilize, in Transform target, float positionStabilization, float angleStabilization, float deltaTime, bool useLocalSpace = false)
		{
		}

		public static void ApplyStabilization(ref Transform toStabilize, in Transform target, in float3 targetEndpoint, float positionStabilization, float angleStabilization, float deltaTime, bool useLocalSpace = false)
		{
		}

		public static void ApplyStabilization(ref Transform toStabilize, in Transform target, in IXRRayProvider aimTarget, float positionStabilization, float angleStabilization, float deltaTime, bool useLocalSpace = false)
		{
		}

		private static void ProcessStabilization(Pose currentPose, Pose targetPose, Vector3 targetEndpoint, float positionStabilization, float angleStabilization, float deltaTime, float localScale, Transform toStabilize, bool useLocalSpace)
		{
		}

		private static void ProcessStabilizationWithoutAimTarget(Pose currentPose, Pose targetPose, float positionStabilization, float angleStabilization, float deltaTime, float localScale, Transform toStabilize, bool useLocalSpace)
		{
		}

		private static void CalculatePoses(Transform toStabilize, Transform target, bool useLocalSpace, out Pose currentPose, out Pose targetPose)
		{
			currentPose = default(Pose);
			targetPose = default(Pose);
		}

		private static float CalculateScaleFactor(Transform toStabilize, bool useLocalSpace)
		{
			return 0f;
		}

		[BurstCompile]
		private static void StabilizeTransform(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot)
		{
			resultPos = default(float3);
			resultRot = default(quaternion);
		}

		[BurstCompile]
		private static void StabilizePosition(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos)
		{
			resultPos = default(float3);
		}

		[BurstCompile]
		private static void StabilizeOptimalRotation(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot)
		{
			resultRot = default(quaternion);
		}

		[BurstCompile]
		private static float CalculateStabilizedLerp(float distance, float timeSlice)
		{
			return 0f;
		}

		[BurstCompile]
		private static void CalculateRotationParams(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale)
		{
			antiRotation = default(quaternion);
			scaleFactor = default(float);
			targetAngleScale = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void StabilizeTransform_0024BurstManaged(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot)
		{
			resultPos = default(float3);
			resultRot = default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void StabilizePosition_0024BurstManaged(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos)
		{
			resultPos = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void StabilizeOptimalRotation_0024BurstManaged(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot)
		{
			resultRot = default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static float CalculateStabilizedLerp_0024BurstManaged(float distance, float timeSlice)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void CalculateRotationParams_0024BurstManaged(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale)
		{
			antiRotation = default(quaternion);
			scaleFactor = default(float);
			targetAngleScale = default(float);
		}
	}
}
