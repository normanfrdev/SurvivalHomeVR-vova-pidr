using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Object")]
	public sealed class IsObjectVariableDefined : IsVariableDefinedUnit, IObjectVariableUnit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[DoNotSerialize]
		[PortLabelHidden]
		[NullMeansSelf]
		public ValueInput source
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

		public IsObjectVariableDefined()
		{
		}

		public IsObjectVariableDefined(string name)
		{
		}

		protected override void Definition()
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
