namespace Unity.VisualScripting
{
	[UnitCategory("Events/Application")]
	public sealed class OnApplicationFocus : GlobalEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnApplicationFocus()
		{
			((GlobalEventUnit<>)(object)this)._002Ector();
		}
	}
}
