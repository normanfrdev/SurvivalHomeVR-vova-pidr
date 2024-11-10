using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Hierarchy")]
	public sealed class OnTransformParentChanged : GameObjectEventUnit<EmptyEventArgs>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnTransformParentChanged()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
