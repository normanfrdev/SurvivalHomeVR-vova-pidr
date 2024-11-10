using System;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[Serializable]
	public abstract class XRTargetEvaluator : IDisposable
	{
		[HideInInspector]
		[SerializeField]
		private XRTargetFilter m_Filter;

		[HideInInspector]
		[SerializeField]
		[XRTargetEvaluatorEnabled]
		private bool m_Enabled;

		[Tooltip("The weight curve of this evaluator. Use this curve to configure the returned score.\n\nThe x-axis is the normalized score (calculated in CalculateNormalizedScore) and the y-axis is the returned score of this evaluator.")]
		[SerializeField]
		private AnimationCurve m_Weight;

		private bool m_IsAwake;

		private bool m_IsEnabled;

		private bool m_IsRegistered;

		public XRTargetFilter filter => null;

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AnimationCurve weight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool disposed => false;

		internal static bool IsInstanceType(Type evaluatorType)
		{
			return false;
		}

		internal static XRTargetEvaluator CreateInstance(Type evaluatorType, XRTargetFilter filter)
		{
			return null;
		}

		private void RegisterHandlers()
		{
		}

		private void UnregisterHandlers()
		{
		}

		internal void AwakeInternal()
		{
		}

		internal void DisposeInternal()
		{
		}

		internal void EnableInternal()
		{
		}

		internal void DisableInternal()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDispose()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Reset()
		{
		}

		public float GetWeightedScore(IXRInteractor interactor, IXRInteractable target)
		{
			return 0f;
		}

		protected abstract float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target);

		public void Dispose()
		{
		}
	}
}
