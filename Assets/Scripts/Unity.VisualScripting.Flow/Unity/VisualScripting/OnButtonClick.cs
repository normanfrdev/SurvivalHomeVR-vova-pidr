using System;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(Button))]
	[UnitOrder(1)]
	public sealed class OnButtonClick : GameObjectEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public override Type MessageListenerType => null;

		public OnButtonClick()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
