using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnButtonInput : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		[DoNotSerialize]
		[PortLabel("Name")]
		public ValueInput buttonName
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
		public ValueInput action
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

		public OnButtonInput()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
