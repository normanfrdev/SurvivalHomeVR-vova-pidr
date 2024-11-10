using System;

namespace Unity.VisualScripting
{
	public sealed class OnCollisionEnter2D : CollisionEvent2DUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
