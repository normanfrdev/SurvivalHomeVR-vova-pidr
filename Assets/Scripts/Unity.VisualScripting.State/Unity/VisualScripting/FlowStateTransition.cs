using System;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public sealed class FlowStateTransition : NesterStateTransition<FlowGraph, ScriptGraphAsset>, IGraphEventListener
	{
		public FlowStateTransition()
		{
			((NesterStateTransition<, >)(object)this)._002Ector();
		}

		public FlowStateTransition(IState source, IState destination)
		{
			((NesterStateTransition<, >)(object)this)._002Ector();
		}

		public static FlowStateTransition WithDefaultTrigger(IState source, IState destination)
		{
			return null;
		}

		public static FlowGraph GraphWithDefaultTrigger()
		{
			return null;
		}

		public override void OnEnter(Flow flow)
		{
		}

		public override void OnExit(Flow flow)
		{
		}

		public void StartListening(GraphStack stack)
		{
		}

		public void StopListening(GraphStack stack)
		{
		}

		public bool IsListening(GraphPointer pointer)
		{
			return false;
		}

		public override FlowGraph DefaultGraph()
		{
			return null;
		}
	}
}
