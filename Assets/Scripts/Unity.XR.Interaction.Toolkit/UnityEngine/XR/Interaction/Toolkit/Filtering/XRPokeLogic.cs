using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Bindings.Variables;
using Unity.XR.CoreUtils.Collections;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	internal class XRPokeLogic : IDisposable
	{
		private readonly BindableVariable<PokeStateData> m_PokeStateData;

		private Transform m_InitialTransform;

		private PokeThresholdData m_PokeThresholdData;

		private float m_SelectEntranceVectorDotThreshold;

		private readonly Dictionary<object, Vector3> m_LastHoverEnterLocalPosition;

		private readonly Dictionary<object, Transform> m_LastHoveredTransform;

		private readonly Dictionary<object, bool> m_HoldingHoverCheck;

		private readonly Dictionary<Transform, HashSetList<object>> m_HoveredInteractorsOnThisTransform;

		private readonly Dictionary<object, float> m_LastInteractorPressDepth;

		private const float k_DepthPercentActivationThreshold = 0.025f;

		private const float k_SquareVelocityHoverThreshold = 0.0001f;

		private float interactionAxisLength
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

		public IReadOnlyBindableVariable<PokeStateData> pokeStateData => null;

		public void Initialize(Transform associatedTransform, PokeThresholdData pokeThresholdData, Collider collider)
		{
		}

		public void SetPokeDepth(float pokeDepth)
		{
		}

		public void Dispose()
		{
		}

		public bool MeetsRequirementsForSelectAction(object interactor, Vector3 pokableAttachPosition, Vector3 pokerAttachPosition, float pokeInteractionOffset, Transform pokedTransform)
		{
			return false;
		}

		private Vector3 ComputeRotatedDepthEvaluationAxis(Transform associatedTransform, bool isWorldSpace = true)
		{
			return default(Vector3);
		}

		private float ComputeInteractionAxisLength(Bounds bounds)
		{
			return 0f;
		}

		public void OnHoverEntered(object interactor, Pose updatedPose, Transform pokedTransform)
		{
		}

		public void OnHoverExited(object interactor)
		{
		}

		private void ResetPokeStateData(Transform transform)
		{
		}

		private static Bounds ComputeBounds(Collider targetCollider, bool rotateBoundsScale = false, Space targetSpace = Space.World)
		{
			return default(Bounds);
		}

		private static Bounds BoundsLocalToWorld(Bounds targetBounds, Transform targetTransform, bool rotateBoundsScale = false)
		{
			return default(Bounds);
		}

		public void DrawGizmos()
		{
		}
	}
}
