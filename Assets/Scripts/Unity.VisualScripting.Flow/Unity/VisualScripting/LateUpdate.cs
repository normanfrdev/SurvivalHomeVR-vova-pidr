namespace Unity.VisualScripting
{
	[UnitCategory("Events/Lifecycle")]
	[UnitOrder(5)]
	[UnitTitle("On Late Update")]
	public sealed class LateUpdate : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public LateUpdate()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
