using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnMouseOver : GameObjectEventUnit<EmptyEventArgs>, IMouseEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnMouseOver()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
