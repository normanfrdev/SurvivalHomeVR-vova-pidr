using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(101)]
	public abstract class Add<T> : Unit
	{
		[DoNotSerialize]
		public ValueInput a
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
		public ValueInput b
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
		[PortLabel("A + B")]
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

		[DoNotSerialize]
		protected virtual T defaultB => default(T);

		protected override void Definition()
		{
		}

		private T Operation(Flow flow)
		{
			return default(T);
		}

		public abstract T Operation(T a, T b);
	}
}
