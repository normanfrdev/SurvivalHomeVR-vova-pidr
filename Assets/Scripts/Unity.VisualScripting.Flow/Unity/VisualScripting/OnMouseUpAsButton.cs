using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnMouseUpAsButton : GameObjectEventUnit<EmptyEventArgs>, IMouseEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnMouseUpAsButton()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
