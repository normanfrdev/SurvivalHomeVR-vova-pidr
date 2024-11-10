using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(14)]
	public sealed class OnPointerEnter : PointerEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
