namespace Unity.VisualScripting
{
	[UnitCategory("Events/Application")]
	public sealed class OnApplicationResume : GlobalEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnApplicationResume()
		{
			((GlobalEventUnit<>)(object)this)._002Ector();
		}
	}
}
