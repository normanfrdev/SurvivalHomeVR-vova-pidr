using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Hierarchy")]
	public sealed class OnTransformChildrenChanged : GameObjectEventUnit<EmptyEventArgs>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		public OnTransformChildrenChanged()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
