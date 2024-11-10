namespace Unity.VisualScripting
{
	[UnitCategory("Events/Lifecycle")]
	[UnitOrder(7)]
	public sealed class OnDestroy : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public override void StopListening(GraphStack stack)
		{
		}

		private protected override void InternalTrigger(GraphReference reference, EmptyEventArgs args)
		{
		}

		public OnDestroy()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
