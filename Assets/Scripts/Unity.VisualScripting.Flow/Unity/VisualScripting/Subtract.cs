using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(102)]
	public abstract class Subtract<T> : Unit
	{
		[DoNotSerialize]
		[PortLabel("A")]
		public ValueInput minuend
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
		public ValueInput subtrahend
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
		[PortLabel("A − B")]
		public ValueOutput difference
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
		protected virtual T defaultMinuend => default(T);

		[DoNotSerialize]
		protected virtual T defaultSubtrahend => default(T);

		protected override void Definition()
		{
		}

		public abstract T Operation(T a, T b);

		public T Operation(Flow flow)
		{
			return default(T);
		}
	}
}
