using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Animation")]
	public sealed class OnAnimatorMove : GameObjectEventUnit<EmptyEventArgs>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnAnimatorMove()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
