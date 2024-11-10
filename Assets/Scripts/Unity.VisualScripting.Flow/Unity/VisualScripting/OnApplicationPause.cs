namespace Unity.VisualScripting
{
	[UnitCategory("Events/Application")]
	public sealed class OnApplicationPause : GlobalEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnApplicationPause()
		{
			((GlobalEventUnit<>)(object)this)._002Ector();
		}
	}
}
