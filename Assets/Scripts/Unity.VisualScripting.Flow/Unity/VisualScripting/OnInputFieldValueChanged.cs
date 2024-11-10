using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(InputField))]
	[UnitOrder(2)]
	public sealed class OnInputFieldValueChanged : GameObjectEventUnit<string>
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

		protected override void AssignArguments(Flow flow, string value)
		{
		}

		public OnInputFieldValueChanged()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
