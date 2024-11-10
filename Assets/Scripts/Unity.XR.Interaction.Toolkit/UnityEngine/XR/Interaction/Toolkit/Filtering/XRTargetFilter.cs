using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[AddComponentMenu("XR/XR Target Filter", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Filtering.XRTargetFilter.html")]
	public sealed class XRTargetFilter : XRBaseTargetFilter, IEnumerable<XRTargetEvaluator>, IEnumerable
	{
		private static readonly LinkedPool<List<XRTargetEvaluator>> s_EvaluatorListPool;

		private static readonly Dictionary<IXRInteractable, float> s_InteractableFinalScoreMap;

		private static readonly Comparison<IXRInteractable> s_InteractableScoreComparison;

		private List<IXRInteractor> m_LinkedInteractors;

		[SerializeReference]
		private List<XRTargetEvaluator> m_Evaluators;

		private bool m_IsAwake;

		internal List<IXRInteractor> linkedInteractors => null;

		internal List<XRTargetEvaluator> evaluators => null;

		public int evaluatorCount => 0;

		internal bool isProcessing
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

		public override bool canProcess => false;

		public event Action<IXRInteractor> interactorLinked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IXRInteractor> interactorUnlinked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private static int InteractableScoreDescendingComparison(IXRInteractable x, IXRInteractable y)
		{
			return 0;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		internal void RegisterEvaluatorHandlers(XRTargetEvaluator evaluator)
		{
		}

		internal void UnregisterEvaluatorHandlers(XRTargetEvaluator evaluator)
		{
		}

		public void GetLinkedInteractors(List<IXRInteractor> results)
		{
		}

		public void GetEvaluators(List<XRTargetEvaluator> results)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<XRTargetEvaluator> GetEnumerator()
		{
			return null;
		}

		public XRTargetEvaluator GetEvaluatorAt(int index)
		{
			return null;
		}

		public XRTargetEvaluator GetEvaluator(Type type)
		{
			return null;
		}

		public T GetEvaluator<T>()
		{
			return default(T);
		}

		public void GetEnabledEvaluators(List<XRTargetEvaluator> results)
		{
		}

		public XRTargetEvaluator AddEvaluator(Type evaluatorType)
		{
			return null;
		}

		public T AddEvaluator<T>() where T : XRTargetEvaluator
		{
			return null;
		}

		public void RemoveEvaluatorAt(int index)
		{
		}

		public void RemoveEvaluator(XRTargetEvaluator evaluator)
		{
		}

		public void MoveEvaluatorTo(XRTargetEvaluator evaluator, int newIndex)
		{
		}

		public override void Link(IXRInteractor interactor)
		{
		}

		public override void Unlink(IXRInteractor interactor)
		{
		}

		public override void Process(IXRInteractor interactor, List<IXRInteractable> targets, List<IXRInteractable> results)
		{
		}
	}
}
