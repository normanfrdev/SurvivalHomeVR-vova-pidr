using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	[Obsolete("Use the new unified variable nodes instead.")]
	public abstract class VariableUnit : Unit, IVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[DoNotSerialize]
		public string defaultName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput name
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

		protected VariableUnit()
		{
		}

		protected VariableUnit(string defaultName)
		{
		}

		protected abstract VariableDeclarations GetDeclarations(Flow flow);

		protected override void Definition()
		{
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
