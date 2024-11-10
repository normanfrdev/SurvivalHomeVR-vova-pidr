using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Dictionaries")]
	[UnitSurtitle("Dictionary")]
	[UnitShortTitle("Clear")]
	[UnitOrder(4)]
	[TypeIcon(typeof(RemoveDictionaryItem))]
	public sealed class ClearDictionary : Unit
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
		[PortLabel("Dictionary")]
		[PortLabelHidden]
		public ValueInput dictionaryInput
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
		[PortLabel("Dictionary")]
		[PortLabelHidden]
		public ValueOutput dictionaryOutput
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

		private ControlOutput Clear(Flow flow)
		{
			return null;
		}
	}
}
