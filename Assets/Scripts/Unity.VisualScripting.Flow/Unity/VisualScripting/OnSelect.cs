using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(22)]
	public sealed class OnSelect : GenericGuiEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
