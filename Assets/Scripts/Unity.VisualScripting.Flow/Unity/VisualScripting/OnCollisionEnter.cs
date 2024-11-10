using System;

namespace Unity.VisualScripting
{
	public sealed class OnCollisionEnter : CollisionEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
