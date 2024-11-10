using System.Collections;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Dictionaries")]
	[UnitOrder(5)]
	public sealed class MergeDictionaries : MultiInputUnit<IDictionary>
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput dictionary
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

		public IDictionary Merge(Flow flow)
		{
			return null;
		}

		public MergeDictionaries()
		{
			((MultiInputUnit<>)(object)this)._002Ector();
		}
	}
}
