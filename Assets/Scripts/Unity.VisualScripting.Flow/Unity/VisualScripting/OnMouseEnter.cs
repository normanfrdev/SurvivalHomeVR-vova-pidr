using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnMouseEnter : GameObjectEventUnit<EmptyEventArgs>, IMouseEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnMouseEnter()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
