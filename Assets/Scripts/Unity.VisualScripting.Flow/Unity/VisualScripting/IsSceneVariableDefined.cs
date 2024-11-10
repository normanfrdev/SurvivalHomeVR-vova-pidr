using System;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Scene")]
	public sealed class IsSceneVariableDefined : IsVariableDefinedUnit, ISceneVariableUnit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public IsSceneVariableDefined()
		{
		}

		public IsSceneVariableDefined(string defaultName)
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
