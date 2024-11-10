namespace Unity.VisualScripting
{
	[TypeIcon(typeof(StateGraph))]
	public class GetStateGraphs : GetGraphs<StateGraph, StateGraphAsset, StateMachine>
	{
		public GetStateGraphs()
		{
			((GetGraphs<TGraph, TGraphAsset, TMachine>)(object)this)._002Ector();
		}
	}
}
