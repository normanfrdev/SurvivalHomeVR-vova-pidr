using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(17)]
	public sealed class OnDrag : PointerEventUnit
	{
		protected override string hookName => null;

		public override Type MessageListenerType => null;
	}
}
