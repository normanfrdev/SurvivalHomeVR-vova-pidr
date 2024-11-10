using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class StateGraphData : GraphData<StateGraph>, IGraphEventListenerData, IGraphData
	{
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

		public StateGraphData(StateGraph definition)
		{
			((GraphData<TGraph>)(object)this)._002Ector((TGraph)default(_00210));
		}
	}
}
