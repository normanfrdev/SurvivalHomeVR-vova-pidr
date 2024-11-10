using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnMouseUp : GameObjectEventUnit<EmptyEventArgs>, IMouseEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnMouseUp()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
