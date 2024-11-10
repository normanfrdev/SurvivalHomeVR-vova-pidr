namespace Unity.VisualScripting
{
	[UnitCategory("Events/State")]
	public class OnExitState : ManualEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnExitState()
		{
			((ManualEventUnit<TArgs>)(object)this)._002Ector();
		}
	}
}
