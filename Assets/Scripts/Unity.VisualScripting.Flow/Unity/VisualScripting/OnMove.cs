using System;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[UnitOrder(21)]
	public sealed class OnMove : GameObjectEventUnit<AxisEventData>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput data
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

		protected override void AssignArguments(Flow flow, AxisEventData data)
		{
		}

		public OnMove()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
