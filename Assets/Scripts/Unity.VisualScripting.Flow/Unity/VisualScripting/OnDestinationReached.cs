using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Navigation")]
	public sealed class OnDestinationReached : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		[DoNotSerialize]
		public ValueInput threshold
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
		public ValueInput requireSuccess
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

		protected override bool ShouldTrigger(Flow flow, EmptyEventArgs args)
		{
			return false;
		}

		public OnDestinationReached()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
