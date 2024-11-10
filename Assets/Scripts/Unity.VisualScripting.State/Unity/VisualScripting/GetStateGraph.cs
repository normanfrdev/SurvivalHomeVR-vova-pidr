namespace Unity.VisualScripting
{
	[TypeIcon(typeof(StateGraph))]
	public class GetStateGraph : GetGraph<StateGraph, StateGraphAsset, StateMachine>
	{
		public GetStateGraph()
		{
			((GetGraph<TGraph, TGraphAsset, TMachine>)(object)this)._002Ector();
		}
	}
}
