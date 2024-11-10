using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(ScrollRect))]
	[UnitOrder(7)]
	public sealed class OnScrollRectValueChanged : GameObjectEventUnit<Vector2>
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

		protected override void AssignArguments(Flow flow, Vector2 value)
		{
		}

		public OnScrollRectValueChanged()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
