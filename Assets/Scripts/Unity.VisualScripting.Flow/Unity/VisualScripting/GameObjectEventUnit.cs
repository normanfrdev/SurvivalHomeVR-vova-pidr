using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class GameObjectEventUnit<TArgs> : EventUnit<TArgs>, IGameObjectEventUnit, IEventUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IGraphEventListener
	{
		public new class Data : EventUnit<TArgs>.Data
		{
			public GameObject target;

			public Data()
			{
				((EventUnit<>.Data)(object)this)._002Ector();
			}
		}

		protected sealed override bool register => false;

		public abstract Type MessageListenerType { get; }

		[DoNotSerialize]
		[NullMeansSelf]
		[PortLabel("Target")]
		[PortLabelHidden]
		public ValueInput target
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

		protected virtual string hookName => null;

		public override IGraphElementData CreateData()
		{
			return null;
		}

		protected override void Definition()
		{
		}

		public override EventHook GetHook(GraphReference reference)
		{
			return default(EventHook);
		}

		private void UpdateTarget(GraphStack stack)
		{
		}

		protected void StartListening(GraphStack stack, bool updateTarget)
		{
		}

		public override void StartListening(GraphStack stack)
		{
		}

		protected GameObjectEventUnit()
		{
			((EventUnit<>)(object)this)._002Ector();
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
