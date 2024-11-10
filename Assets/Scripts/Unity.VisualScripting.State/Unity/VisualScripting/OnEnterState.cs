namespace Unity.VisualScripting
{
	[UnitCategory("Events/State")]
	public class OnEnterState : ManualEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnEnterState()
		{
			((ManualEventUnit<TArgs>)(object)this)._002Ector();
		}
	}
}
