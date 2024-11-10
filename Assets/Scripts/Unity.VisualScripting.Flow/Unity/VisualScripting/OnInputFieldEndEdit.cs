using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(InputField))]
	[UnitOrder(3)]
	public sealed class OnInputFieldEndEdit : GameObjectEventUnit<string>
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

		public OnInputFieldEndEdit()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
