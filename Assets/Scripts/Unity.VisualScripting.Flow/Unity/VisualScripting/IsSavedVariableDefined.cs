using System;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Save")]
	public sealed class IsSavedVariableDefined : IsVariableDefinedUnit, ISavedVariableUnit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public IsSavedVariableDefined()
		{
		}

		public IsSavedVariableDefined(string defaultName)
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
