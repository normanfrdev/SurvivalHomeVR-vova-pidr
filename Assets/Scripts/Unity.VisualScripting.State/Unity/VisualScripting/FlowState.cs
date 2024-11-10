using System;
using System.ComponentModel;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	[TypeIcon(typeof(FlowGraph))]
	[DisplayName("Script State")]
	public sealed class FlowState : NesterState<FlowGraph, ScriptGraphAsset>, IGraphEventListener
	{
		public FlowState()
		{
			((NesterState<, >)(object)this)._002Ector();
		}

		public FlowState(ScriptGraphAsset macro)
		{
			((NesterState<, >)(object)this)._002Ector();
		}

		protected override void OnEnterImplementation(Flow flow)
		{
		}

		protected override void OnExitImplementation(Flow flow)
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

		public static FlowState WithEnterUpdateExit()
		{
			return null;
		}

		public static FlowGraph GraphWithEnterUpdateExit()
		{
			return null;
		}
	}
}
