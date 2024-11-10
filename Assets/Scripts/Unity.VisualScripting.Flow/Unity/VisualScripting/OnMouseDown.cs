using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnMouseDown : GameObjectEventUnit<EmptyEventArgs>, IMouseEventUnit
	{
		protected override string hookName => null;

		public override Type MessageListenerType => null;

		public OnMouseDown()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
