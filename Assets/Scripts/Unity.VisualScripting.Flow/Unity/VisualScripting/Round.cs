using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(202)]
	public abstract class Round<TInput, TOutput> : Unit
	{
		public enum Rounding
		{
			Floor = 0,
			Ceiling = 1,
			AwayFromZero = 2
		}

		[Inspectable]
		[UnitHeaderInspectable]
		[Serialize]
		public Rounding rounding
		{
			[CompilerGenerated]
			get
			{
				return default(Rounding);
			}
			[CompilerGenerated]
			set
			{
			}
		}

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

		protected abstract TOutput Floor(TInput input);

		protected abstract TOutput AwayFromZero(TInput input);

		protected abstract TOutput Ceiling(TInput input);

		public TOutput Operation(Flow flow)
		{
			return default(TOutput);
		}
	}
}
