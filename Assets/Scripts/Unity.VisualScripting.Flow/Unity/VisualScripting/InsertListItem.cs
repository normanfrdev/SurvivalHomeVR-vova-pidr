using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Lists")]
	[UnitSurtitle("List")]
	[UnitShortTitle("Insert Item")]
	[UnitOrder(3)]
	[TypeIcon(typeof(AddListItem))]
	public sealed class InsertListItem : Unit
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
		public ValueInput index
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
		public ValueInput item
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

		public ControlOutput Insert(Flow flow)
		{
			return null;
		}
	}
}
