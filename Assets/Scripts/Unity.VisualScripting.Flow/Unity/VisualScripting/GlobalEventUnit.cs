namespace Unity.VisualScripting
{
	public abstract class GlobalEventUnit<TArgs> : EventUnit<TArgs>
	{
		protected override bool register => false;

		protected virtual string hookName => null;

		public override EventHook GetHook(GraphReference reference)
		{
			return default(EventHook);
		}

		protected GlobalEventUnit()
		{
			((EventUnit<>)(object)this)._002Ector();
		}
	}
}
