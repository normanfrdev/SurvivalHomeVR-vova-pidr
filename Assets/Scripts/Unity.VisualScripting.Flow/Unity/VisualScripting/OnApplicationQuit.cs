namespace Unity.VisualScripting
{
	[UnitCategory("Events/Application")]
	public sealed class OnApplicationQuit : GlobalEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnApplicationQuit()
		{
			((GlobalEventUnit<>)(object)this)._002Ector();
		}
	}
}
