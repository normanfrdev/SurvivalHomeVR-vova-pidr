using System;

namespace Unity.VisualScripting
{
	public sealed class OnCollisionExit : CollisionEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
