using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnKeyboardInput : MachineEventUnit<EmptyEventArgs>
	{
		protected override string hookName => null;

		[DoNotSerialize]
		public ValueInput key
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

		public OnKeyboardInput()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
