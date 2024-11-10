using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(303)]
	[TypeIcon(typeof(Add<>))]
	public abstract class Sum<T> : MultiInputUnit<T>
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput sum
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

		protected Sum()
		{
			((MultiInputUnit<>)(object)this)._002Ector();
		}
	}
}
