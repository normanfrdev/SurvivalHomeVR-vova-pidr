using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(401)]
	public abstract class Normalize<T> : Unit
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

		private T Operation(Flow flow)
		{
			return default(T);
		}

		public abstract T Operation(T input);
	}
}
