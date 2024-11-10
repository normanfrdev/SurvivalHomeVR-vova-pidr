using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(304)]
	public abstract class Average<T> : MultiInputUnit<T>
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput average
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

		public abstract T Operation(T a, T b);

		public abstract T Operation(IEnumerable<T> values);

		public T Operation(Flow flow)
		{
			return default(T);
		}

		protected Average()
		{
			((MultiInputUnit<>)(object)this)._002Ector();
		}
	}
}
