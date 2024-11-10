using System.Collections;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Dictionaries")]
	[UnitSurtitle("Dictionary")]
	[UnitShortTitle("Contains Key")]
	[TypeIcon(typeof(IDictionary))]
	public sealed class DictionaryContainsKey : Unit
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
		[PortLabelHidden]
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
		public ValueOutput contains
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

		private bool Contains(Flow flow)
		{
			return false;
		}
	}
}
