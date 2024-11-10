using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit
{
	internal static class SortingHelpers
	{
		private class InteractableBasedEvaluator : IInteractorDistanceEvaluator
		{
			public float EvaluateDistance(IXRInteractor interactor, IXRInteractable interactable)
			{
				return 0f;
			}
		}

		private class ClosestPointOnColliderEvaluator : IInteractorDistanceEvaluator
		{
			public float EvaluateDistance(IXRInteractor interactor, IXRInteractable interactable)
			{
				return 0f;
			}
		}

		[BurstCompile]
		private class SquareDistanceAttachPointEvaluator : IInteractorDistanceEvaluator
		{
			public delegate float SqDistanceToInteractable_0000159C_0024PostfixBurstDelegate(in float3 attachPosition, in float3 interactablePosition);

			internal static class SqDistanceToInteractable_0000159C_0024BurstDirectCall
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

				public static float Invoke(in float3 attachPosition, in float3 interactablePosition)
				{
					return 0f;
				}
			}

			public float EvaluateDistance(IXRInteractor interactor, IXRInteractable interactable)
			{
				return 0f;
			}

			[BurstCompile]
			private static float SqDistanceToInteractable(in float3 attachPosition, in float3 interactablePosition)
			{
				return 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[BurstCompile]
			public static float SqDistanceToInteractable_0024BurstManaged(in float3 attachPosition, in float3 interactablePosition)
			{
				return 0f;
			}
		}

		private static readonly Dictionary<IXRInteractable, float> s_InteractableDistanceSqrMap;

		private static readonly Comparison<IXRInteractable> s_InteractableDistanceComparison;

		public static readonly IInteractorDistanceEvaluator squareDistanceAttachPointEvaluator;

		public static readonly IInteractorDistanceEvaluator interactableBasedEvaluator;

		public static readonly IInteractorDistanceEvaluator closestPointOnColliderEvaluator;

		public static void Sort<T>(IList<T> hits, IComparer<T> comparer) where T : struct
		{
		}

		public static void Sort<T>(IList<T> hits, IComparer<T> comparer, int count) where T : struct
		{
		}

		public static void SortByDistanceToInteractor(IXRInteractor interactor, List<IXRInteractable> unsortedTargets, List<IXRInteractable> results)
		{
		}

		public static void SortByDistanceToInteractor(IXRInteractor interactor, List<IXRInteractable> unsortedTargets, List<IXRInteractable> results, IInteractorDistanceEvaluator distanceEvaluator)
		{
		}

		public static void SortByDistanceToInteractor(IXRInteractor interactor, List<IXRInteractable> interactablesToSort)
		{
		}

		public static void SortByDistanceToInteractor(IXRInteractor interactor, List<IXRInteractable> interactablesToSort, IInteractorDistanceEvaluator distanceEvaluator)
		{
		}

		private static int InteractableDistanceComparison(IXRInteractable x, IXRInteractable y)
		{
			return 0;
		}

		public static void Initialize_0024SquareDistanceAttachPointEvaluator_SqDistanceToInteractable_0000159C_0024BurstDirectCall()
		{
		}
	}
}
