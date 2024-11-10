namespace Unity.VisualScripting
{
	[UnitCategory("Events/Lifecycle")]
	[UnitOrder(1)]
	public sealed class OnEnable : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnEnable()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
