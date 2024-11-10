using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class FlowGraphData : GraphData<FlowGraph>, IGraphDataWithVariables, IGraphData, IGraphEventListenerData
	{
		public VariableDeclarations variables
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool isListening
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FlowGraphData(FlowGraph definition)
		{
			((GraphData<TGraph>)(object)this)._002Ector((TGraph)default(_00210));
		}
	}
}
