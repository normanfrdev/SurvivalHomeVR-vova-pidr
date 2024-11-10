using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(Toggle))]
	[UnitOrder(5)]
	public sealed class OnToggleValueChanged : GameObjectEventUnit<bool>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput value
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Definition()
		{
		}

		protected override void AssignArguments(Flow flow, bool value)
		{
		}

		public OnToggleValueChanged()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
