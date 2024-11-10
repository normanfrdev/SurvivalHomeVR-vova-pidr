using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Rendering")]
	public sealed class OnBecameVisible : GameObjectEventUnit<EmptyEventArgs>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnBecameVisible()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
