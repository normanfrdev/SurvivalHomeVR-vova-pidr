namespace Unity.VisualScripting
{
	public sealed class AnyState : State
	{
		[DoNotSerialize]
		public override bool canBeDestination => false;

		public override void OnExit(Flow flow, StateExitReason reason)
		{
		}

		public override void OnBranchTo(Flow flow, IState destination)
		{
		}
	}
}
