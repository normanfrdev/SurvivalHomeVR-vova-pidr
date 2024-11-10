namespace Unity.VisualScripting
{
	[TypeIcon(typeof(StateGraph))]
	public sealed class SuperState : NesterState<StateGraph, StateGraphAsset>, IGraphEventListener
	{
		public SuperState()
		{
			((NesterState<, >)(object)this)._002Ector();
		}

		public SuperState(StateGraphAsset macro)
		{
			((NesterState<, >)(object)this)._002Ector();
		}

		public static SuperState WithStart()
		{
			return null;
		}

		protected override void OnEnterImplementation(Flow flow)
		{
		}

		protected override void OnExitImplementation(Flow flow)
		{
		}

		public void StartListening(GraphStack stack)
		{
		}

		public void StopListening(GraphStack stack)
		{
		}

		public bool IsListening(GraphPointer pointer)
		{
			return false;
		}

		public override StateGraph DefaultGraph()
		{
			return null;
		}
	}
}
