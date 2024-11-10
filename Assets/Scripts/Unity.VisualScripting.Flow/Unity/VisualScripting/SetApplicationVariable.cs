using System;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Application")]
	public sealed class SetApplicationVariable : SetVariableUnit, IApplicationVariableUnit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public SetApplicationVariable()
		{
		}

		public SetApplicationVariable(string defaultName)
		{
		}

		protected override VariableDeclarations GetDeclarations(Flow flow)
		{
			return null;
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
