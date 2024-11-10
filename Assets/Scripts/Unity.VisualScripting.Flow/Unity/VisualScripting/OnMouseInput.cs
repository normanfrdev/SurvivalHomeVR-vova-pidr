using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Input")]
	public sealed class OnMouseInput : MachineEventUnit<EmptyEventArgs>, IMouseEventUnit
	{
		protected override string hookName => null;

		[DoNotSerialize]
		public ValueInput button
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

		public OnMouseInput()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
