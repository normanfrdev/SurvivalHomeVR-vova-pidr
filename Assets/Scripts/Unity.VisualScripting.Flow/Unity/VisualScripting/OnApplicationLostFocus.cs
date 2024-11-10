namespace Unity.VisualScripting
{
	[UnitCategory("Events/Application")]
	public sealed class OnApplicationLostFocus : GlobalEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnApplicationLostFocus()
		{
			((GlobalEventUnit<>)(object)this)._002Ector();
		}
	}
}
