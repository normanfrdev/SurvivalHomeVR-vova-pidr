namespace Unity.VisualScripting
{
	[UnitCategory("Events/Lifecycle")]
	[UnitOrder(6)]
	public sealed class OnDisable : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnDisable()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
