using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnMouseDrag : GameObjectEventUnit<EmptyEventArgs>, IMouseEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnMouseDrag()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
