using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Graphs/Graph Nodes")]
	public abstract class GetGraph<TGraph, TGraphAsset, TMachine> : Unit where TGraph : class, IGraph, new() where TGraphAsset : Macro<TGraph> where TMachine : Machine<TGraph, TGraphAsset>
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
		[PortLabel("Graph")]
		[PortLabelHidden]
		public ValueOutput graphOutput
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

		private TGraphAsset Get(Flow flow)
		{
			return null;
		}
	}
}
