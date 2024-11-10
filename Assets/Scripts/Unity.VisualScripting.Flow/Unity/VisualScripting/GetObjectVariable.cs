using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Object")]
	public sealed class GetObjectVariable : GetVariableUnit, IObjectVariableUnit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
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

		public GetObjectVariable()
		{
		}

		public GetObjectVariable(string name)
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
