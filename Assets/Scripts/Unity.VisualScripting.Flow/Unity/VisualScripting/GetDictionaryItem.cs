using System.Collections;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Dictionaries")]
	[UnitSurtitle("Dictionary")]
	[UnitShortTitle("Get Item")]
	[UnitOrder(0)]
	[TypeIcon(typeof(IDictionary))]
	public sealed class GetDictionaryItem : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput dictionary
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
		[PortLabelHidden]
		public ValueOutput value
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

		private object Get(Flow flow)
		{
			return null;
		}
	}
}
