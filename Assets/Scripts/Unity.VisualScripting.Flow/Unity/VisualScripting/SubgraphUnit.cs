using System;
using System.ComponentModel;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(FlowGraph))]
	[UnitCategory("Nesting")]
	[UnitTitle("Subgraph")]
	[RenamedFrom("Bolt.SuperUnit")]
	[RenamedFrom("Unity.VisualScripting.SuperUnit")]
	[DisplayName("Subgraph Node")]
	public sealed class SubgraphUnit : NesterUnit<FlowGraph, ScriptGraphAsset>, IGraphEventListener, IGraphElementWithData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public sealed class Data : IGraphElementData
		{
			public bool isListening;
		}

		public IGraphElementData CreateData()
		{
			return null;
		}

		public SubgraphUnit()
		{
			((NesterUnit<, >)(object)this)._002Ector();
		}

		public SubgraphUnit(ScriptGraphAsset macro)
		{
			((NesterUnit<, >)(object)this)._002Ector();
		}

		public static SubgraphUnit WithInputOutput()
		{
			return null;
		}

		public static SubgraphUnit WithStartUpdate()
		{
			return null;
		}

		public override FlowGraph DefaultGraph()
		{
			return null;
		}

		protected override void Definition()
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

		public override void AfterAdd()
		{
		}

		public override void BeforeRemove()
		{
		}

		private void StopWatchingPortDefinitions()
		{
		}

		private void StartWatchingPortDefinitions()
		{
		}
	}
}
