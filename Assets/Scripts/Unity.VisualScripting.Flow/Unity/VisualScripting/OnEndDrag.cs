using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(OnDrag))]
	[UnitOrder(18)]
	public sealed class OnEndDrag : PointerEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
