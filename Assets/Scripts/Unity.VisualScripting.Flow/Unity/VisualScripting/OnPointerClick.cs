using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(11)]
	public sealed class OnPointerClick : PointerEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
