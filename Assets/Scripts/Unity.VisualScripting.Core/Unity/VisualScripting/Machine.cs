using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class Machine<TGraph, TMacro> : LudiqBehaviour, IMachine, IGraphRoot, IGraphParent, IGraphNester, IAotStubbable where TGraph : class, IGraph, new() where TMacro : Macro<TGraph>
	{
		[DoNotSerialize]
		private bool _alive;

		[DoNotSerialize]
		private bool _enabled;

		[DoNotSerialize]
		private GameObject threadSafeGameObject;

		[DoNotSerialize]
		private bool isReferenceCached;

		[DoNotSerialize]
		private GraphReference _reference;

		[Serialize]
		public GraphNest<TGraph, TMacro> nest
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DoNotSerialize]
		IGraphNest IGraphNester.nest => null;

		[DoNotSerialize]
		GameObject IMachine.threadSafeGameObject => null;

		[DoNotSerialize]
		protected GraphReference reference => null;

		[DoNotSerialize]
		protected bool hasGraph => false;

		[DoNotSerialize]
		public TGraph graph => null;

		[DoNotSerialize]
		public IGraphData graphData
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

		[DoNotSerialize]
		bool IGraphParent.isSerializationRoot => false;

		[DoNotSerialize]
		Object IGraphParent.serializedObject => null;

		[DoNotSerialize]
		IGraph IGraphParent.childGraph => null;

		public bool isDescriptionValid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnInstantiateWhileEnabled()
		{
		}

		protected virtual void OnUninstantiateWhileEnabled()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnValidate()
		{
		}

		public GraphPointer GetReference()
		{
			return null;
		}

		private void CacheReference()
		{
		}

		private void ClearCachedReference()
		{
		}

		public virtual void InstantiateNest()
		{
		}

		public virtual void UninstantiateNest()
		{
		}

		public virtual void TriggerAnimationEvent(AnimationEvent animationEvent)
		{
		}

		public virtual void TriggerUnityEvent(string name)
		{
		}

		public abstract TGraph DefaultGraph();

		IGraph IGraphParent.DefaultGraph()
		{
			return null;
		}
	}
}
