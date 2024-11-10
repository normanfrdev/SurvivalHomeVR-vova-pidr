using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(OnDrag))]
	[UnitOrder(16)]
	public sealed class OnBeginDrag : PointerEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
