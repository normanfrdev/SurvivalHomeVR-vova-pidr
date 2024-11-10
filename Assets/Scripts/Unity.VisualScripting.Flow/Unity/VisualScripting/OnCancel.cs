using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(25)]
	public sealed class OnCancel : GenericGuiEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
