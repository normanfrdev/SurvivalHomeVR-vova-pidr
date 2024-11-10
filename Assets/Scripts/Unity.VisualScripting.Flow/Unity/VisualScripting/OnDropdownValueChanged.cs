using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/GUI")]
	[TypeIcon(typeof(Dropdown))]
	[UnitOrder(4)]
	public sealed class OnDropdownValueChanged : GameObjectEventUnit<int>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		[DoNotSerialize]
		public ValueOutput index
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

		[DoNotSerialize]
		public ValueOutput text
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

		protected override void AssignArguments(Flow flow, int index)
		{
		}

		public OnDropdownValueChanged()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
