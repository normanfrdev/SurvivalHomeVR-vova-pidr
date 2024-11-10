using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Transformers
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer.html")]
	[BurstCompile]
	public class XRSocketGrabTransformer : IXRGrabTransformer
	{
		public delegate float FastCalculateRadiusOffset_0000084F_0024PostfixBurstDelegate(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius);

		internal static class FastCalculateRadiusOffset_0000084F_0024BurstDirectCall
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

			public static float Invoke(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius)
			{
				return 0f;
			}
		}

		public delegate void FastComputeNewTrackedPose_00000850_0024PostfixBurstDelegate(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot);

		internal static class FastComputeNewTrackedPose_00000850_0024BurstDirectCall
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

			public static void Invoke(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot)
			{
				targetPos = default(float3);
				targetRot = default(quaternion);
			}
		}

		public delegate bool IsWithinRadius_00000851_0024PostfixBurstDelegate(in float3 a, in float3 b, float radius);

		internal static class IsWithinRadius_00000851_0024BurstDirectCall
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

			public static bool Invoke(in float3 a, in float3 b, float radius)
			{
				return false;
			}
		}

		public delegate void CalculateScaleToFit_00000852_0024PostfixBurstDelegate(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale);

		internal static class CalculateScaleToFit_00000852_0024BurstDirectCall
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

			public static void Invoke(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale)
			{
				newScale = default(float3);
			}
		}

		private const float k_SocketSnappingAxisTolerance = 0.01f;

		private readonly Dictionary<IXRInteractable, float3> m_InitialScale;

		private readonly Dictionary<IXRInteractable, float3> m_InteractableBoundsSize;

		public bool canProcess
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float socketSnappingRadius
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SocketScaleMode scaleMode
		{
			[CompilerGenerated]
			get
			{
				return default(SocketScaleMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float3 fixedScale
		{
			[CompilerGenerated]
			get
			{
				return default(float3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float3 targetBoundsSize
		{
			[CompilerGenerated]
			get
			{
				return default(float3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IXRInteractor socketInteractor
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void OnLink(XRGrabInteractable grabInteractable)
		{
		}

		public void OnGrab(XRGrabInteractable grabInteractable)
		{
		}

		public void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale)
		{
		}

		public void Process(XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale)
		{
		}

		private static void UpdateTargetWithoutScale(XRGrabInteractable grabInteractable, IXRInteractor interactor, float snappingRadius, ref Pose targetPose)
		{
		}

		private static void UpdateTargetWithScale(XRGrabInteractable grabInteractable, IXRInteractor interactor, float innerRadius, in float3 initialScale, in float3 initialBounds, in float3 targetScale, ref Pose targetPose, ref Vector3 localScale)
		{
		}

		public void OnUnlink(XRGrabInteractable grabInteractable)
		{
		}

		private bool RegisterInteractableScale(IXRInteractable targetInteractable, Vector3 scale)
		{
			return false;
		}

		private float3 ComputeSocketTargetScale(IXRInteractable interactable, in float3 initialInteractableScale)
		{
			return default(float3);
		}

		private static bool GetTargetPoseForInteractable(IXRInteractable interactable, IXRInteractor interactor, out Pose targetPose)
		{
			targetPose = default(Pose);
			return false;
		}

		[BurstCompile]
		private static float FastCalculateRadiusOffset(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius)
		{
			return 0f;
		}

		[BurstCompile]
		private static void FastComputeNewTrackedPose(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot)
		{
			targetPos = default(float3);
			targetRot = default(quaternion);
		}

		[BurstCompile]
		private static bool IsWithinRadius(in float3 a, in float3 b, float radius)
		{
			return false;
		}

		[BurstCompile]
		private static void CalculateScaleToFit(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale)
		{
			newScale = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static float FastCalculateRadiusOffset_0024BurstManaged(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void FastComputeNewTrackedPose_0024BurstManaged(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot)
		{
			targetPos = default(float3);
			targetRot = default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static bool IsWithinRadius_0024BurstManaged(in float3 a, in float3 b, float radius)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void CalculateScaleToFit_0024BurstManaged(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale)
		{
			newScale = default(float3);
		}
	}
}
