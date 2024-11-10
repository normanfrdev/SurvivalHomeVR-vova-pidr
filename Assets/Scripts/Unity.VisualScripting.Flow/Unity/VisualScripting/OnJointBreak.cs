using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Physics")]
	public sealed class OnJointBreak : GameObjectEventUnit<float>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		[DoNotSerialize]
		public ValueOutput breakForce
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

		protected override void AssignArguments(Flow flow, float breakForce)
		{
		}

		public OnJointBreak()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
