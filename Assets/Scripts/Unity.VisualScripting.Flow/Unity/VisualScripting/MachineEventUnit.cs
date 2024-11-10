namespace Unity.VisualScripting
{
	public abstract class MachineEventUnit<TArgs> : EventUnit<TArgs>
	{
		protected sealed override bool register => false;

		protected virtual string hookName => null;

		public override EventHook GetHook(GraphReference reference)
		{
			return default(EventHook);
		}

		protected MachineEventUnit()
		{
			((EventUnit<>)(object)this)._002Ector();
		}
	}
}
