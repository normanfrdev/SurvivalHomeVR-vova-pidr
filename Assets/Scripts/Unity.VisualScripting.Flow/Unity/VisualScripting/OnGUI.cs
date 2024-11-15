using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(GUI))]
	[UnitOrder(0)]
	public sealed class OnGUI : GlobalEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		public OnGUI()
		{
			((GlobalEventUnit<>)(object)this)._002Ector();
		}
	}
}
