using System;

namespace Unity.VisualScripting
{
	public sealed class OnCollisionStay : CollisionEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
