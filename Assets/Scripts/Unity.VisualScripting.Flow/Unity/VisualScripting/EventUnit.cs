using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	[SpecialUnit]
	public abstract class EventUnit<TArgs> : Unit, IEventUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IGraphEventListener, IGraphElementWithData, IGraphEventHandler<TArgs>
	{
		public class Data : IGraphElementData
		{
			public EventHook hook;

			public Delegate handler;

			public bool isListening;

			public HashSet<Flow> activeCoroutines;
		}

		[Serialize]
		[Inspectable]
		[InspectorExpandTooltip]
		public bool coroutine
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

		[DoNotSerialize]
		[PortLabelHidden]
		public ControlOutput trigger
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
		protected abstract bool register { get; }

		public virtual IGraphElementData CreateData()
		{
			return null;
		}

		protected override void Definition()
		{
		}

		public virtual EventHook GetHook(GraphReference reference)
		{
			return default(EventHook);
		}

		public virtual void StartListening(GraphStack stack)
		{
		}

		public virtual void StopListening(GraphStack stack)
		{
		}

		public override void Uninstantiate(GraphReference instance)
		{
		}

		private static void StopAllCoroutines(HashSet<Flow> activeCoroutines)
		{
		}

		public bool IsListening(GraphPointer pointer)
		{
			return false;
		}

		public void Trigger(GraphReference reference, TArgs args)
		{
		}

		private protected virtual void InternalTrigger(GraphReference reference, TArgs args)
		{
		}

		protected virtual bool ShouldTrigger(Flow flow, TArgs args)
		{
			return false;
		}

		protected virtual void AssignArguments(Flow flow, TArgs args)
		{
		}

		private void Run(Flow flow)
		{
		}

		protected static bool CompareNames(Flow flow, ValueInput namePort, string calledName)
		{
			return false;
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
