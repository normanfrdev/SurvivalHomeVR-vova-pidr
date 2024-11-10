using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(20)]
	public sealed class OnScroll : PointerEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
