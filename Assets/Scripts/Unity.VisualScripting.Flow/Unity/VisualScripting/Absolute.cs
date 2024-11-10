using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(201)]
	public abstract class Absolute<TInput> : Unit
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

		protected abstract TInput Operation(TInput input);

		public TInput Operation(Flow flow)
		{
			return default(TInput);
		}
	}
}
