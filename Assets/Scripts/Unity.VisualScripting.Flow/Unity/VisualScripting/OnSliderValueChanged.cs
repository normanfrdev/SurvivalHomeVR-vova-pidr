using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(Slider))]
	[UnitOrder(8)]
	public sealed class OnSliderValueChanged : GameObjectEventUnit<float>
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

		protected override void AssignArguments(Flow flow, float value)
		{
		}

		public OnSliderValueChanged()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
