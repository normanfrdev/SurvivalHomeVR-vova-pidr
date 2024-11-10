using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitSurtitle("Custom Event")]
	[UnitShortTitle("Trigger")]
	[TypeIcon(typeof(CustomEvent))]
	[UnitCategory("Events")]
	[UnitOrder(1)]
	public sealed class TriggerCustomEvent : Unit
	{
		[SerializeAs("argumentCount")]
		private int _argumentCount;

		[DoNotSerialize]
		public List<ValueInput> arguments
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
		[Inspectable]
		[UnitHeaderInspectable("Arguments")]
		public int argumentCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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
		[PortLabelHidden]
		public ValueInput name
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
		[NullMeansSelf]
		public ValueInput target
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

		private ControlOutput Trigger(Flow flow)
		{
			return null;
		}
	}
}
