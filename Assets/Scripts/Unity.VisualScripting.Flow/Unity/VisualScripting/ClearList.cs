using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Lists")]
	[UnitSurtitle("List")]
	[UnitShortTitle("Clear")]
	[UnitOrder(6)]
	[TypeIcon(typeof(RemoveListItem))]
	public sealed class ClearList : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ControlInput enter
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
		[PortLabel("List")]
		[PortLabelHidden]
		public ValueInput listInput
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
		[PortLabel("List")]
		[PortLabelHidden]
		public ValueOutput listOutput
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
		[PortLabelHidden]
		public ControlOutput exit
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

		public ControlOutput Clear(Flow flow)
		{
			return null;
		}
	}
}
