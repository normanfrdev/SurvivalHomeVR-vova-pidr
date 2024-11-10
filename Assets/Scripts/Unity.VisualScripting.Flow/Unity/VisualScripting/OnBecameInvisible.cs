using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Rendering")]
	public sealed class OnBecameInvisible : GameObjectEventUnit<EmptyEventArgs>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnBecameInvisible()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
