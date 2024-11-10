using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(104)]
	public abstract class Divide<T> : Unit
	{
		[DoNotSerialize]
		[PortLabel("A")]
		public ValueInput dividend
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
		[PortLabel("B")]
		public ValueInput divisor
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
		[PortLabel("A ÷ B")]
		public ValueOutput quotient
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
		protected virtual T defaultDivisor => default(T);

		[DoNotSerialize]
		protected virtual T defaultDividend => default(T);

		protected override void Definition()
		{
		}

		public abstract T Operation(T divident, T divisor);

		public T Operation(Flow flow)
		{
			return default(T);
		}
	}
}
