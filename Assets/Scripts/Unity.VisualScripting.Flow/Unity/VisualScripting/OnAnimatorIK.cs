using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Animation")]
	public sealed class OnAnimatorIK : GameObjectEventUnit<int>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		[DoNotSerialize]
		public ValueOutput layerIndex
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

		protected override void AssignArguments(Flow flow, int layerIndex)
		{
		}

		public OnAnimatorIK()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
