namespace Unity.VisualScripting
{
	[UnitCategory("Events/Lifecycle")]
	[UnitOrder(2)]
	[UnitTitle("On Start")]
	public sealed class Start : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public Start()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
