using System;
using System.Collections.Generic;
using Unity.Jobs;
using Unity.XR.CoreUtils.Bindings;
using Unity.XR.CoreUtils.Bindings.Variables;
using Unity.XR.CoreUtils.Collections;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class BaseAffordanceStateProvider : MonoBehaviour
	{
		[SerializeField]
		[Range(0f, 5f)]
		[Tooltip("Duration of transition in seconds. 0 means no smoothing.")]
		private float m_TransitionDuration;

		private readonly BindableVariable<AffordanceStateData> m_AffordanceStateData;

		private readonly HashSetList<IAsyncAffordanceStateReceiver> m_AsyncAffordanceReceivers;

		private readonly HashSetList<ISynchronousAffordanceStateReceiver> m_SynchronousAffordanceReceivers;

		private readonly List<JobHandle> m_ScheduledJobs;

		private readonly BindingsGroup m_BindingsGroup;

		private float m_TimeSinceLastStateUpdate;

		private bool m_IsFirstFrame;

		private bool m_CompletingTweens;

		private float m_InterpolationSpeed;

		private float m_MaxTransitionDuration;

		public float transitionDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isCurrentlyTransitioning => false;

		public IReadOnlyBindableVariable<AffordanceStateData> currentAffordanceStateData => null;

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void BindToProviders()
		{
		}

		protected virtual void ClearBindings()
		{
		}

		protected void AddBinding(IEventBinding binding)
		{
		}

		public void UpdateAffordanceState(AffordanceStateData newAffordanceStateData)
		{
		}

		private void OnAffordanceStateUpdated(AffordanceStateData newAffordanceStateData)
		{
		}

		public bool RegisterAffordanceReceiver(IAffordanceStateReceiver receiver)
		{
			return false;
		}

		private bool RegisterAffordanceReceiver(IAsyncAffordanceStateReceiver receiver)
		{
			return false;
		}

		private bool RegisterAffordanceReceiver(ISynchronousAffordanceStateReceiver receiver)
		{
			return false;
		}

		public bool UnregisterAffordanceReceiver(IAffordanceStateReceiver receiver)
		{
			return false;
		}

		private bool UnregisterAffordanceReceiver(IAsyncAffordanceStateReceiver receiver)
		{
			return false;
		}

		private bool UnregisterAffordanceReceiver(ISynchronousAffordanceStateReceiver receiver)
		{
			return false;
		}

		private bool CompleteJobs()
		{
			return false;
		}

		private void DoTween(float tweenTarget)
		{
		}

		private void RefreshTransitionDuration()
		{
		}
	}
}
