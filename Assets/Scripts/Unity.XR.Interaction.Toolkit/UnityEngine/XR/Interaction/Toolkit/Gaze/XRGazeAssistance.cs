using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Gaze
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/XR Gaze Assistance", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance.html")]
	[DefaultExecutionOrder(-29980)]
	[BurstCompile]
	public class XRGazeAssistance : MonoBehaviour, IXRAimAssist
	{
		[Serializable]
		public sealed class InteractorData
		{
			[SerializeField]
			[RequireInterface(typeof(IXRRayProvider))]
			[Tooltip("The interactor that can fall back to gaze data.")]
			private Object m_Interactor;

			[SerializeField]
			[Tooltip("Changes mediation behavior to account for teleportation controls.")]
			private bool m_TeleportRay;

			private bool m_Initialized;

			private IXRRayProvider m_RayProvider;

			private IXRSelectInteractor m_SelectInteractor;

			private bool m_RestoreVisuals;

			private XRInteractorLineVisual m_LineVisual;

			private bool m_HasLineVisual;

			private Transform m_OriginalRayOrigin;

			private Transform m_OriginalAttach;

			private Transform m_OriginalVisualLineOrigin;

			private bool m_OriginalOverrideVisualLineOrigin;

			private Transform m_FallbackRayOrigin;

			private Transform m_FallbackAttach;

			private Transform m_FallbackVisualLineOrigin;

			public Object interactor
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool teleportRay
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool fallback
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal void Initialize()
			{
			}

			internal void UpdateFallbackRayOrigin(Transform gazeTransform)
			{
			}

			internal void UpdateLineVisualOrigin()
			{
			}

			internal bool UpdateFallbackState(Transform gazeTransform, float fallbackDivergence, bool selectionLocked)
			{
				return false;
			}

			internal void RestoreVisuals()
			{
			}
		}

		public delegate void GetAssistedVelocityInternal_00000EFD_0024PostfixBurstDelegate(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity);

		internal static class GetAssistedVelocityInternal_00000EFD_0024BurstDirectCall
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

			public static void Invoke(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity)
			{
				adjustedVelocity = default(Vector3);
			}
		}

		private const float k_MinAttachDistance = 0.5f;

		private const float k_MinFallbackDivergence = 0f;

		private const float k_MaxFallbackDivergence = 90f;

		private const float k_MinAimAssistRequiredAngle = 0f;

		private const float k_MaxAimAssistRequiredAngle = 90f;

		[SerializeField]
		[Tooltip("Eye data source used as fallback data and to determine if fallback data should be used.")]
		private XRGazeInteractor m_GazeInteractor;

		[SerializeField]
		[Range(0f, 90f)]
		[Tooltip("How far an interactor must point away from the user's view area before eye gaze will be used instead.")]
		private float m_FallbackDivergence;

		[SerializeField]
		[Tooltip("If the eye reticle should be hidden when all interactors are using their original data.")]
		private bool m_HideCursorWithNoActiveRays;

		[SerializeField]
		[Tooltip("Interactors that can fall back to gaze data.")]
		private List<InteractorData> m_RayInteractors;

		[SerializeField]
		[Tooltip("How far projectiles can aim outside of eye gaze and still be considered for aim assist.")]
		[Range(0f, 90f)]
		private float m_AimAssistRequiredAngle;

		[SerializeField]
		[Tooltip("How fast a projectile must be moving to be considered for aim assist.")]
		private float m_AimAssistRequiredSpeed;

		[SerializeField]
		[Tooltip("How much of the corrected aim velocity to use, as a percentage.")]
		[Range(0f, 1f)]
		private float m_AimAssistPercent;

		[SerializeField]
		[Tooltip("How much additional speed a projectile can receive from aim assistance, as a percentage.")]
		private float m_AimAssistMaxSpeedPercent;

		private InteractorData m_SelectingInteractorData;

		private XRInteractorReticleVisual m_GazeReticleVisual;

		private bool m_HasGazeReticleVisual;

		public XRGazeInteractor gazeInteractor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float fallbackDivergence
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hideCursorWithNoActiveRays
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<InteractorData> rayInteractors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float aimAssistRequiredAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float aimAssistRequiredSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float aimAssistPercent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float aimAssistMaxSpeedPercent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Initialize()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Start()
		{
		}

		protected void Update()
		{
		}

		protected void LateUpdate()
		{
		}

		[BeforeRenderOrder(95)]
		private void OnBeforeRender()
		{
		}

		public Vector3 GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity)
		{
			return default(Vector3);
		}

		public Vector3 GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity, float maxAngle)
		{
			return default(Vector3);
		}

		[BurstCompile]
		private static void GetAssistedVelocityInternal(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity)
		{
			adjustedVelocity = default(Vector3);
		}

		Vector3 IXRAimAssist.GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity)
		{
			return default(Vector3);
		}

		Vector3 IXRAimAssist.GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity, float maxAngle)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		public static void GetAssistedVelocityInternal_0024BurstManaged(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity)
		{
			adjustedVelocity = default(Vector3);
		}
	}
}
