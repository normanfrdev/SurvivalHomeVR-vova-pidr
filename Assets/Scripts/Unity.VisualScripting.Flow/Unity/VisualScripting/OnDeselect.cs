using System;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(23)]
	public sealed class OnDeselect : GenericGuiEventUnit
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;
	}
}
