using System;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Application")]
	public sealed class IsApplicationVariableDefined : IsVariableDefinedUnit, IApplicationVariableUnit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public IsApplicationVariableDefined()
		{
		}

		public IsApplicationVariableDefined(string defaultName)
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
