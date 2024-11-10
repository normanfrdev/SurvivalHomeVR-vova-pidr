using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Graphs/Graph Nodes")]
	public abstract class GetGraphs<TGraph, TGraphAsset, TMachine> : Unit where TGraph : class, IGraph, new() where TGraphAsset : Macro<TGraph> where TMachine : Machine<TGraph, TGraphAsset>
	{
		[DoNotSerialize]
		[PortLabelHidden]
		[NullMeansSelf]
		public ValueInput gameObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		[DoNotSerialize]
		[PortLabel("Graphs")]
		[PortLabelHidden]
		public ValueOutput graphList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected override void Definition()
		{
		}

		private List<TGraphAsset> Get(Flow flow)
		{
			return null;
		}
	}
}
