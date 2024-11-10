using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitSurtitle("State")]
	[UnitCategory("Nesting")]
	[UnitShortTitle("Trigger Transition")]
	[TypeIcon(typeof(IStateTransition))]
	public sealed class TriggerStateTransition : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ControlInput trigger
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

		private ControlOutput Trigger(Flow flow)
		{
			return null;
		}
	}
}
