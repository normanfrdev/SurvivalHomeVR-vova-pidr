using System.Collections;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Lists")]
	[UnitOrder(7)]
	public sealed class MergeLists : MultiInputUnit<IEnumerable>
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput list
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

		public IList Merge(Flow flow)
		{
			return null;
		}

		public MergeLists()
		{
			((MultiInputUnit<>)(object)this)._002Ector();
		}
	}
}
