using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	public abstract class UnifiedVariableUnit : Unit, IUnifiedVariableUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable]
		public VariableKind kind
		{
			[CompilerGenerated]
			get
			{
				return default(VariableKind);
			}
			[CompilerGenerated]
			set
			{
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

		[DoNotSerialize]
		[PortLabelHidden]
		[NullMeansSelf]
		public ValueInput @object
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

		protected override void Definition()
		{
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
