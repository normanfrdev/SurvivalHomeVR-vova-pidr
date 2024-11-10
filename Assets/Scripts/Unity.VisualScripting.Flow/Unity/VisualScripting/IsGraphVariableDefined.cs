using System;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Graph")]
	public sealed class IsGraphVariableDefined : IsVariableDefinedUnit, IGraphVariableUnit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public IsGraphVariableDefined()
		{
		}

		public IsGraphVariableDefined(string defaultName)
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
