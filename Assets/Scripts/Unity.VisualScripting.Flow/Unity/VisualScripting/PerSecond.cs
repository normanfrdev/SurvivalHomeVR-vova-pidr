using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(601)]
	public abstract class PerSecond<T> : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput input
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
		public ValueOutput output
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

		public abstract T Operation(T input);

		public T Operation(Flow flow)
		{
			return default(T);
		}
	}
}
